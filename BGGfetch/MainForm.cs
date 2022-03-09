
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using HtmlAgilityPack;
using Microsoft.VisualBasic;
using PublicDomain;

namespace BGGfetch
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The last download date time.
        /// </summary>
        private DateTime lastXmlApiDownloadDateTime = DateTime.Now;

        /// <summary>
        /// The fetch timer.
        /// </summary>
        private System.Timers.Timer fetchTimer = new System.Timers.Timer(250);

        /// <summary>
        /// The game search web client.
        /// </summary>
        private WebClient gameSearchWebClient = new WebClient();

        /// <summary>
        /// The game info web client.
        /// </summary>
        private WebClient gameInfoWebClient = new WebClient();

        /// <summary>
        /// The image web client.
        /// </summary>
        private WebClient imageWebClient = new WebClient();

        /// <summary>
        /// The directory.
        /// </summary>
        private string directory;

        /// <summary>
        /// The file path.
        /// </summary>
        private string filePath;

        /// <summary>
        /// The fetched count.
        /// </summary>
        private int fetchedCount = 0;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// The description prepend.
        /// </summary>
        private string descriptionPrepend = string.Empty;

        /// <summary>
        /// The game search list box selected item.
        /// </summary>
        private string gameSearchListBoxSelectedItem = String.Empty;

        /// <summary>
        /// The target URI.
        /// </summary>
        private Uri targetUri = null;

        /// <summary>
        /// The image URI.
        /// </summary>
        private Uri imageUri = null;

        /// <summary>
        /// The fetched image path.
        /// </summary>
        private string fetchedImagePath = string.Empty;

        /// <summary>
        /// The data table.
        /// </summary>
        private DataTable dataTable = new DataTable();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:BGGfetch.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainIsToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            // SSL fix
            System.Net.ServicePointManager.Expect100Continue = true;
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            /* Data table */

            DataColumn column1 = new DataColumn();
            DataColumn column2 = new DataColumn();
            DataColumn column3 = new DataColumn();
            column1.DataType = System.Type.GetType("System.Int32");
            column2.DataType = System.Type.GetType("System.String");
            column3.DataType = System.Type.GetType("System.String");  // Originally System.Type.GetType("System.Int32"). Changed to accomodate (n/a)
            column1.ColumnName = "ID";
            column2.ColumnName = "Name";
            column3.ColumnName = "Year";
            dataTable.Columns.Add(column1);
            dataTable.Columns.Add(column2);
            dataTable.Columns.Add(column3);

            /* Settings data */

            // Saved settings flag
            bool prevSettingsData = false;

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());

                // Center form
                this.CenterToScreen();
            }
            else
            {
                // Set flag
                prevSettingsData = true;
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            // Check for previous settings
            if (prevSettingsData)
            {
                // Set values
                this.directoryTextBox.Text = this.settingsData.Directory;
                this.Location = this.settingsData.Location;
                this.Size = this.settingsData.Size;
            }

            // Check radio button
            switch (this.settingsData.SortRadioButton)
            {
                case "rawRadioButton":
                    this.rawRadioButton.Checked = true;

                    break;

                case "idRadioButton":
                    this.idRadioButton.Checked = true;

                    break;

                case "yearRadioButton":
                    this.yearRadioButton.Checked = true;

                    break;

                case "nameRadioButton":
                    this.nameRadioButton.Checked = true;

                    break;
            }

            // Desc
            this.descCheckBox.Checked = this.settingsData.Desc;

            /* WebClients */

            this.gameSearchWebClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnGameSearchDownloadStringCompleted);
            this.gameSearchWebClient.Proxy = null;

            this.gameInfoWebClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnGameInfoDownloadStringCompleted);
            this.gameInfoWebClient.Proxy = null;

            this.imageWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadFileCompleted);
            this.imageWebClient.Proxy = null;

            /* Timer  */

            this.fetchTimer.AutoReset = false;

            this.fetchTimer.Elapsed += new ElapsedEventHandler(OnTimerElapsedAsync);

            this.fetchTimer.Start();
        }

        /// <summary>
        /// Handles the browse button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = string.Empty;

            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                this.directoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.gameTextBox.Clear();

            this.directoryTextBox.Clear();

            this.fetchedCount = 0;
            this.fetchedCountToolStripStatusLabel.Text = "0";

            this.gameInfoRichTextBox.Clear();
            this.gameImagePictureBox.Image = null;

            this.gameTextBox.Focus();
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                try
                {
                    // Declare lines string builder
                    var lineStringBuilder = new StringBuilder();

                    // Read all lines 
                    foreach (var line in File.ReadAllLines(this.openFileDialog.FileName))
                    {
                        // Append line
                        lineStringBuilder.AppendLine(line);
                    }

                    this.gameTextBox.Text = lineStringBuilder.ToString(); // TODO Can be simplified without StringBuilder
                }
                catch (Exception exception)
                {
                    // Inform user
                    MessageBox.Show($"Error when opening \"{Path.GetFileName(this.openFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Open file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the save tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.saveFileDialog.FileName = string.Empty;
            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    File.WriteAllLines(this.saveFileDialog.FileName, this.gameTextBox.Lines.Cast<string>().ToList()); // TODO Can be simplified (.Text)
                }
            }
            catch (Exception exception)
            {
                // Inform user
                MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Inform user
            MessageBox.Show($"Saved {this.gameTextBox.Lines.Length} items to \"{Path.GetFileName(this.saveFileDialog.FileName)}\"", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"HtmlAgilityPack library by zzzprojects - MIT License{Environment.NewLine}" +
                $"https://github.com/zzzprojects/html-agility-pack{Environment.NewLine}{Environment.NewLine}" +
                $"Frisbee icon by Clker-Free-Vector-Images - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/frisbee-flying-saucer-circle-round-295056/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: Mouser{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #65, Week #09 @ March 06, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the free releases public domain is tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainIsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=51939.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/bggfetch/");
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the directory text box drag drop.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDirectoryTextBoxDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var possibleDirectory = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Directory.Exists(possibleDirectory[0]))
                {
                    this.directoryTextBox.Text = possibleDirectory[0];
                }
            }
        }

        /// <summary>
        /// Handles the directory text box drag enter.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDirectoryTextBoxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// Gets the name of the valid directory.
        /// </summary>
        /// <returns>The valid directory name.</returns>
        /// <param name="directoryName">Directory name.</param>
        private string GetValidDirectoryName(string directoryName)
        {
            var invalidCharList = new List<char>();

            invalidCharList.AddRange(Path.GetInvalidFileNameChars());

            invalidCharList.AddRange(Path.GetInvalidPathChars());

            foreach (var c in invalidCharList)
            {
                directoryName = directoryName.Replace(c.ToString(), string.Empty);
            }

            return directoryName;
        }

        /// <summary>
        /// Handles the timer elapsed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        public void OnTimerElapsedAsync(object sender, ElapsedEventArgs e)
        {
            // Diff check
            TimeSpan timeDiff = DateTime.Now - this.lastXmlApiDownloadDateTime;

            // API seconds
            if (timeDiff.TotalMilliseconds < this.settingsData.ApiDelay)
            {
                string secondsDiff = Math.Truncate(timeDiff.TotalSeconds).ToString();

                if (secondsDiff != this.ApiCountToolStripStatusLabel.Text)
                {
                    this.ApiCountToolStripStatusLabel.Text = secondsDiff;
                }

                goto exitAndRestart;
            }
            else
            {
                if (this.ApiCountToolStripStatusLabel.Text != "OK")
                {
                    this.ApiCountToolStripStatusLabel.Text = "OK";
                }
            }

        exitAndRestart:
            this.fetchTimer.Start();
        }

        /// <summary>
        /// Handles the game search download string completed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGameSearchDownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            // Check for cancel or error
            if (!e.Cancelled && e.Error == null && this.targetUri != null)
            {
                // Declare success flag
                bool success = false;

                // Clear data table
                this.dataTable.Rows.Clear();

                // Set XML contents
                string xml = (string)e.Result;

                // Populate search XML
                this.gameXmlTextBox.Text = xml;

                // Process fetched XML

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                doc.LoadHtml(xml);

                /* Extract fields */

                var boardgames = doc.DocumentNode.SelectNodes("//boardgame");

                foreach (var game in boardgames)
                {
                    DataRow row = this.dataTable.NewRow();

                    /* Set values */

                    row["ID"] = Convert.ToInt32(game.Attributes["objectid"].Value);

                    // May not have year
                    try
                    {
                        row["Year"] = $"({game.ChildNodes["yearpublished"].InnerText})"; // Originally: Convert.ToInt32(game.ChildNodes["yearpublished"].InnerText). Changed to accomodate (n/a)-
                    }
                    catch (Exception ex)
                    {
                        row["Year"] = "(n/a)";
                    }

                    // Name
                    try
                    {
                        row["Name"] = WebUtility.HtmlDecode(game.ChildNodes["name"].InnerText);
                    }
                    catch (Exception ex)
                    {
                        row["Name"] = "(n/a)";
                    }

                    // Add to data table
                    this.dataTable.Rows.Add(row);
                }

                // Populate list box
                this.SortedDataTableToListBox();

                // Advise user
                this.resultToolStripStatusLabel.Text = "Please click a game to process";

                // Update fetched count
                this.fetchedCount++;
                this.fetchedCountToolStripStatusLabel.Text = this.fetchedCount.ToString();

                // Populate search xml text box
                this.searcXmlhTextBox.Text = xml;

                // Set flag
                success = true;
            }
            else
            {
                MessageBox.Show("OnGameSearchDownloadStringCompleted error");
            }

            // Enable
            this.gameTextBox.Enabled = true;
            this.fetchButton.Enabled = true;
        }

        /// <summary>
        /// Sorteds the data table to list box.
        /// </summary>
        private void SortedDataTableToListBox()
        {
            // Check for datatable rows
            if (this.dataTable.Rows.Count == 0)
            {
                // Halt flow
                return;
            }

            // Prevent drawing
            this.gameSearchListBox.BeginUpdate();

            // Clear list box
            this.gameSearchListBox.Items.Clear();

            // Set sorted datatable
            DataTable sortedDataTable = this.dataTable.Clone();

            sortedDataTable.Columns["ID"].DataType = System.Type.GetType("System.Int32");
            sortedDataTable.Columns["Name"].DataType = System.Type.GetType("System.String");
            sortedDataTable.Columns["Year"].DataType = System.Type.GetType("System.String");

            // Check for desc
            if (this.descCheckBox.Checked)
            {
                for (int i = this.dataTable.Rows.Count - 1; i >= 0; i--)
                {
                    sortedDataTable.ImportRow(this.dataTable.Rows[i]);
                }
            }
            else
            {
                foreach (DataRow dataRow in this.dataTable.Rows)
                {
                    sortedDataTable.ImportRow(dataRow);
                }
            }

            sortedDataTable.AcceptChanges();

            // Set data view
            DataView dataView = sortedDataTable.DefaultView;

            // Sort data table
            if (this.settingsData.SortRadioButton != "rawRadioButton")
            {
                // Sort by radio button
                switch (this.settingsData.SortRadioButton)
                {
                    case "idRadioButton":
                        dataView.Sort = $"ID{(this.descCheckBox.Checked ? " DESC" : string.Empty)}";

                        break;

                    case "yearRadioButton":
                        dataView.Sort = $"Year{(this.descCheckBox.Checked ? " DESC" : string.Empty)}";

                        break;

                    case "nameRadioButton":
                        dataView.Sort = $"Name{(this.descCheckBox.Checked ? " DESC" : string.Empty)}";

                        break;
                }
            }

            sortedDataTable = dataView.ToTable();

            // Data table to list box
            for (int i = 0; i < sortedDataTable.Rows.Count; i++)
            {
                // Add item
                this.gameSearchListBox.Items.Add($"{sortedDataTable.Rows[i]["ID"]} {sortedDataTable.Rows[i]["Name"]} {sortedDataTable.Rows[i]["Year"]}");
            }

            // Resume drawing
            this.gameSearchListBox.EndUpdate();
        }

        /// <summary>
        /// Handles the game info download string completed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGameInfoDownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            // Enable
            this.gameSearchListBox.Enabled = true;

            // Split list item
            var item = this.gameSearchListBoxSelectedItem.Split(new char[] { ' ' }, 2);

            // Set vars
            var id = item[0];
            var title = item[1];

            // Set XML contents
            string xml = (string)e.Result;

            // Set new datetime
            this.lastXmlApiDownloadDateTime = DateTime.Now;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(xml);

            // TODO Desription [Node detection/handling can be improved]

            // Prepend designers
            var boardgamedesigners = doc.DocumentNode.SelectNodes("//boardgamedesigner");

            List<string> boardgamedesignerList = new List<string>();

            if (boardgamedesigners != null && boardgamedesigners.Any())
            {
                foreach (var designer in boardgamedesigners)
                {
                    boardgamedesignerList.Add(designer.InnerText);
                }

                this.descriptionPrepend += $"Designer{(boardgamedesignerList.Count > 1 ? "s" : string.Empty)}:{Environment.NewLine}{string.Join(Environment.NewLine, boardgamedesignerList)}";
            }

            // Prepend mechanics
            var boardgamemechanics = doc.DocumentNode.SelectNodes("//boardgamemechanic");

            List<string> boardgamemechanicList = new List<string>();

            if (boardgamemechanics != null && boardgamemechanics.Any())
            {
                foreach (var mechanic in boardgamemechanics)
                {
                    boardgamemechanicList.Add(mechanic.InnerText);
                }

                this.descriptionPrepend += $"{(boardgamedesignerList.Count > 0 ? Environment.NewLine + Environment.NewLine : string.Empty)}Mechanic{(boardgamemechanicList.Count > 1 ? "s" : string.Empty)}:{Environment.NewLine}{string.Join(Environment.NewLine, boardgamemechanicList)}";
            }

            // Description 

            string description;

            try
            {
                var desriptionNode = doc.DocumentNode.SelectSingleNode("//description");

                description = WebUtility.HtmlDecode(desriptionNode.InnerText);

                description = description.Replace("<br/>", Environment.NewLine).Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&quot;", "\"").Replace("&apos;", "'");
            }
            catch (Exception ex)
            {
                description = "Game description is not present.";
            }

            // Set description
            this.gameInfoRichTextBox.Text = this.descriptionPrepend + Environment.NewLine + Environment.NewLine + description;

            // Reset prepend description variable
            this.descriptionPrepend = string.Empty;

            // TODO Image [Node detection/handling can be improved]

            this.imageUri = null;

            try
            {
                var image = doc.DocumentNode.SelectSingleNode("//image");

                this.imageUri = new Uri(image.InnerHtml);

                this.filePath = Path.Combine(this.directory, this.GetValidDirectoryName($"{title}_{Path.GetFileName(image.InnerHtml)}"));
            }
            catch (Exception ex)
            {
                // TODO Image not present [Advise user or log]
            }

            if (this.imageUri != null)
            {
                // Load previous if it exists
                if (File.Exists(this.filePath))
                {
                    // Load picture
                    this.gameImagePictureBox.Image = Image.FromFile(this.filePath);
                }
                else
                {
                    // Advise user
                    this.resultToolStripStatusLabel.Text = $"Fetching image for \"{title}\"...";

                    // Download image
                    this.imageWebClient.DownloadFileAsync(this.imageUri, this.filePath);
                }
            }

            // Populate game result xml text box
            this.gameXmlTextBox.Text = xml;

            // Advise user
            this.resultToolStripStatusLabel.Text = $"Fetched info and image for \"{title.Substring(0, 25)}\"...";

            // Set flag
            //success = true;
        }

        /// <summary>
        /// Handles the download file completed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            /*// Check for cancel or error
            if (!e.Cancelled && e.Error == null)
            {
                // Halt flow
                return;
            }*/

            // Try to load
            if (File.Exists(this.filePath))
            {
                // Load picture
                this.gameImagePictureBox.Image = Image.FromFile(this.filePath);
            }
            else
            {
                // Download image (Retry)
                this.imageWebClient.DownloadFileAsync(this.imageUri, this.filePath);
            }
        }

        /// <summary>
        /// Handles the image picture box mouse move event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGameImagePictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var files = new string[] { this.filePath };

                this.gameImagePictureBox.DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Focus game search text box
            this.gameTextBox.Focus();
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            /* Setiings data values */

            // Set values
            this.settingsData.Directory = this.directoryTextBox.Text;
            this.settingsData.Location = this.Location;
            this.settingsData.Size = this.Size;

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Handles the fetch button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFetchButtonClick(object sender, EventArgs e)
        {
            // Check api is ready
            if (this.ApiCountToolStripStatusLabel.Text != "OK")
            {
                MessageBox.Show("Please retry after API delay.", "API", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.gameTextBox.Focus();

                return;
            }

            // Something to work with
            if (this.gameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a game to search.", "Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.gameTextBox.Focus();

                return;
            }

            // Valid directory
            if (!Directory.Exists(this.directoryTextBox.Text))
            {
                MessageBox.Show("Target save directory must exist.", "Directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.directoryTextBox.Focus();

                return;
            }

            // Disable
            this.gameTextBox.Enabled = false;
            this.fetchButton.Enabled = false;

            // Set variables
            this.directory = this.directoryTextBox.Text;

            // Reset
            this.gameInfoRichTextBox.Clear();
            this.gameImagePictureBox.Image = null;
            this.gameSearchListBox.Items.Clear();
            this.searcXmlhTextBox.Clear();
            this.gameXmlTextBox.Clear();

            /* Search game */

            // Advise user
            this.resultToolStripStatusLabel.Text = $"Searching for: \"{this.gameTextBox.Text}\"...";

            // Focus search XML tab
            this.rawTabControl.SelectedTab = this.searchXmlTabPage;

            try
            {
                // Set target uri
                this.targetUri = new Uri($"https://www.boardgamegeek.com/xmlapi/search?search={Uri.EscapeDataString(this.gameTextBox.Text)}");

                // Set new datetime
                this.lastXmlApiDownloadDateTime = DateTime.Now;

                // Download xml for game id
                this.gameSearchWebClient.DownloadStringAsync(this.targetUri);
            }
            catch (Exception ex)
            {
                // Log to file
                File.AppendAllText("BGGfetch-log.txt", $"{Environment.NewLine}{Environment.NewLine}Game search XML exception message:{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}");

                // Advise user
                this.resultToolStripStatusLabel.Text = $"Exception while searching. Please retry.";

                // Enable
                this.gameTextBox.Enabled = true;
                this.fetchButton.Enabled = true;
            }
        }

        /// <summary>
        /// Ons the game search list box selected index changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGameSearchListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure there's a selected item
            if (this.gameSearchListBox.SelectedIndex == -1)
            {
                return;
            }

            // Check api is ready
            if (this.ApiCountToolStripStatusLabel.Text != "OK")
            {
                MessageBox.Show("Please retry after API delay.", "API", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.gameTextBox.Focus();

                return;
            }

            /* Download info */

            // Set selected item 
            this.gameSearchListBoxSelectedItem = this.gameSearchListBox.SelectedItem.ToString();

            // Focus game XML tab
            this.rawTabControl.SelectedTab = this.gameXmlTabPage;

            try
            {
                // Disable
                this.gameSearchListBox.Enabled = false;

                // Split list item
                var item = this.gameSearchListBoxSelectedItem.Split(new char[] { ' ' }, 2);

                // Set vars
                var id = item[0];
                var title = item[1];

                this.resultToolStripStatusLabel.Text = $"Downloading info: \"{title.Substring(0, 25)}\"...";

                // Set target uri
                this.targetUri = new Uri($"https://www.boardgamegeek.com/xmlapi/boardgame/{id}");

                // Set new datetime
                this.lastXmlApiDownloadDateTime = DateTime.Now;

                // Download xml for game id
                this.gameInfoWebClient.DownloadStringAsync(this.targetUri);
            }
            catch (Exception ex)
            {
                // Log to file
                File.AppendAllText("BGGfetch-log.txt", $"{Environment.NewLine}{Environment.NewLine}Image XML exception message:{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.Message}");

                // Advise user
                this.resultToolStripStatusLabel.Text = $"Exception while searching. Please retry.";

                // Enable
                this.gameSearchListBox.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the radio button checked changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            // Save to settings data
            this.settingsData.SortRadioButton = ((RadioButton)sender).Name;

            // Refresh list box
            this.SortedDataTableToListBox();
        }

        /// <summary>
        /// Ons the desc check box checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDescCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // Save to settings data
            this.settingsData.Desc = this.descCheckBox.Checked;

            // Refresh list box
            this.SortedDataTableToListBox();
        }

        /// <summary>
        /// Handles the API Delay tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAPIDelayToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Get raw value
            string userValue = Interaction.InputBox("Set API Delay (in milliseconds)", "Edit delay", this.settingsData.ApiDelay.ToString());

            // Check length
            if (userValue.Length == 0)
            {
                // Advise user
                // MessageBox.Show("Empty API delay value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Halt flow
                return;
            }

            try
            {
                // Get new value
                int apiDelay = Convert.ToInt32(userValue);

                // Set API delay
                this.settingsData.ApiDelay = apiDelay;
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"API delay update error:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
