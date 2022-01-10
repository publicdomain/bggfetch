
using System;
using System.Collections.Generic;
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
using PublicDomain;

namespace BGGfetch
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The data table.
        /// </summary>
        private DataTable dataTable = null;

        /// <summary>
        /// The last download date time.
        /// </summary>
        private DateTime lastXmlApiDownloadDateTime = DateTime.Now;

        /// <summary>
        /// The fetch timer.
        /// </summary>
        private System.Timers.Timer fetchTimer = new System.Timers.Timer(1000);

        /// <summary>
        /// The game list.
        /// </summary>
        private List<string> gameList;

        /// <summary>
        /// The download item.
        /// </summary>
        private string downloadItem = string.Empty;

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
                this.splitContainer.SplitterDistance = this.settingsData.VerticalSplit;
                this.splitContainer1.SplitterDistance = this.settingsData.HorizontalSplit;
            }

            /* Timer  */

            fetchTimer.AutoReset = false;

            fetchTimer.Elapsed += new ElapsedEventHandler(OnTimerElapsedAsync);

            this.fetchTimer.Start();
        }

        /// <summary>
        /// Handles the browse button click.
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
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.gameTextBox.Clear();

            this.directoryTextBox.Clear();

            this.fetchedCount = 0;
            this.fetchedCountToolStripStatusLabel.Text = "0";

            this.dataTable = null;
            this.gameDataGridView.DataSource = null;
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
        /// Handles the save tool strip menu item click.
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
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"MarkupConverter library by figuemon - Apache 2.0 License{Environment.NewLine}" +
                $"https://github.com/figuemon/MarkupConverter{Environment.NewLine}{Environment.NewLine}" +
                $"HtmlAgilityPack library by zzzprojects -  MIT License{Environment.NewLine}" +
                $"https://github.com/zzzprojects/html-agility-pack{Environment.NewLine}{Environment.NewLine}" +
                $"Speed limit icon by Clker-Free-Vector-Images- Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/speed-limit-car-safety-law-ahead-43796/{Environment.NewLine}{Environment.NewLine}" +
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
                $"Made for: Mouser{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #9, Week #01 @ January 09, 2022",
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
        /// Handles the free releases public domain is tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainIsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=51939.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
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
        /// Handles the game data grid view cell click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGameDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Clear previous game info and image
                this.gameInfoRichTextBox.Clear();
                this.gameImagePictureBox.Image = null;

                // Set download item
                this.downloadItem = $"{this.gameDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()} | {this.gameDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()} | {this.gameDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()}";

                // Start timer
                this.fetchTimer.Start();
            }
            catch
            {
                // Let it fall through
                ;
            }
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
        public async void OnTimerElapsedAsync(object sender, ElapsedEventArgs e)
        {
            // Diff check
            TimeSpan timeDiff = DateTime.Now - this.lastXmlApiDownloadDateTime;

            // API seconds
            if (timeDiff.TotalSeconds < 6)
            {
                this.ApiCountToolStripStatusLabel.Text = Math.Truncate(timeDiff.TotalSeconds).ToString();

                goto exitAndRestart;
            }
            else
            {
                this.ApiCountToolStripStatusLabel.Text = "OK";
            }

            // Check there's something to work with
            if (this.downloadItem.Length == 0)
            {
                goto exitAndRestart;
            }

            // Set success flag
            bool success = false;

            /* Search or fetch game info */

            var xml = string.Empty;

            var item = this.downloadItem.Split(new string[] { " | " }, StringSplitOptions.None);

            var action = item[0];

            // Discern by action
            if (action == "search")
            {
                /* Search game */

                try
                {
                    var title = item[1];

                    this.resultToolStripStatusLabel.Text = $"Searching for: \"{title}\"...";

                    WebClient webClient = new WebClient
                    {
                        Proxy = null
                    };

                    // Download xml for game id
                    xml = await webClient.DownloadStringTaskAsync(new Uri($"https://www.boardgamegeek.com/xmlapi/search?search={Uri.EscapeDataString(title)}"));
                    //# xml = File.ReadAllText("search.xml");

                    // Prepare data table
                    this.dataTable = new DataTable();

                    this.dataTable.Columns.Add("Id");
                    this.dataTable.Columns.Add("Year");
                    this.dataTable.Columns.Add("Title");

                    // Process fetched XML

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    doc.LoadHtml(xml);

                    var boardgames = doc.DocumentNode.SelectNodes("//boardgame");

                    foreach (var game in boardgames)
                    {
                        // Set new data row
                        DataRow dataRow = this.dataTable.NewRow();

                        /* Set values */
                        dataRow[0] = game.Attributes["objectid"].Value;

                        // May not have year
                        try
                        {
                            dataRow[1] = game.ChildNodes["yearpublished"].InnerText;
                        }
                        catch (Exception ex)
                        {
                            dataRow[1] = "n/a";
                        }

                        dataRow[2] = WebUtility.HtmlDecode(game.ChildNodes["name"].InnerText);

                        // Add to data table 
                        this.dataTable.Rows.Add(dataRow);
                    }

                    // TODO)DO Update data grid view [Check clear & refreshing]
                    this.gameDataGridView.DataSource = null;

                    // Sorting
                    this.gameDataGridView.DataSource = this.dataTable.DefaultView;
                    foreach (DataGridViewColumn column in this.gameDataGridView.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    // Resize columns
                    this.gameDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    this.gameDataGridView.AutoResizeColumns();
                    this.gameDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Refresh/reset
                    this.gameDataGridView.Refresh();
                    this.gameDataGridView.ClearSelection();
                    this.gameDataGridView.CurrentCell = null;

                    // Advise user
                    this.resultToolStripStatusLabel.Text = "Please click a gane to process";

                    // Update fetched count
                    this.fetchedCount++;
                    this.fetchedCountToolStripStatusLabel.Text = this.fetchedCount.ToString();

                    // Set flag
                    success = true;
                }
                catch (Exception ex)
                {
                    // Log to file
                    File.AppendAllText("BGGfetch-log.txt", $"{Environment.NewLine}{Environment.NewLine}Game search:{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                }
            }
            else
            {
                /* Download image */

                try
                {
                    var id = item[0];
                    var title = $"{item[2]}-{item[1]}";

                    this.resultToolStripStatusLabel.Text = $"Downloading game info: \"{title}\"...";

                    WebClient webClient = new WebClient
                    {
                        Proxy = null
                    };

                    // Download xml for game id
                    xml = await webClient.DownloadStringTaskAsync(new Uri($"https://www.boardgamegeek.com/xmlapi/boardgame/{id}"));
                    //# xml = File.ReadAllText("1406.xml");

                    // Set new datetime
                    this.lastXmlApiDownloadDateTime = DateTime.Now;

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    doc.LoadHtml(xml);


                    // TODO Desription [Node detection/handling can be improved]

                    try
                    {
                        var desriptionNode = doc.DocumentNode.SelectSingleNode("//description");

                        string description = WebUtility.HtmlDecode(desriptionNode.InnerText);

                        description = description.Replace("<br/>", Environment.NewLine).Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&quot;", "\"").Replace("&apos;", "'");

                        this.gameInfoRichTextBox.Text = description;
                    }
                    catch (Exception ex)
                    {
                        this.gameInfoRichTextBox.Text = "Description is not present.";
                    }

                    // TODO Image [Node detection/handling can be improved]

                    Uri imageUri = null;

                    try
                    {
                        var image = doc.DocumentNode.SelectSingleNode("//image");

                        imageUri = new Uri(image.InnerHtml);

                        this.filePath = Path.Combine(this.directory, this.GetValidDirectoryName($"{title}_{Path.GetFileName(image.InnerHtml)}"));
                    }
                    catch (Exception ex)
                    {
                        // TODO Image not present [Advise user or log]
                    }

                    if (imageUri != null)
                    {
                        // Advise user
                        this.resultToolStripStatusLabel.Text = $"Fetching image for \"{title}\"...";

                        // TODO can be deleted instead
                        if (!File.Exists(this.filePath))
                        {
                            await webClient.DownloadFileTaskAsync(imageUri, this.filePath);
                        }

                        // TODO can be refactored
                        if (File.Exists(this.filePath))
                        {
                            // Load picture
                            this.gameImagePictureBox.Image = Image.FromFile(this.filePath);
                        }
                    }

                    // Advise user
                    this.resultToolStripStatusLabel.Text = $"Downloaded info and image for \"{title}\"...";

                    // Set flag
                    success = true;
                }
                catch (Exception ex)
                {
                    // Log to file
                    File.AppendAllText("BGGfetch-log.txt", $"{Environment.NewLine}{Environment.NewLine}Download info:{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.Message}");
                }
            }

            // Check for success
            if (success)
            {
                // Clear download item
                this.downloadItem = string.Empty;

                // Set new datetime
                this.lastXmlApiDownloadDateTime = DateTime.Now;
            }

        exitAndRestart:
            fetchTimer.Start();
        }

        /// <summary>
        /// Handles the image picture box mouse move event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void GameImagePictureBoxMouseMove(object sender, MouseEventArgs e)
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
            // TODO Add code if needed.
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
            this.settingsData.VerticalSplit = this.splitContainer.SplitterDistance;
            this.settingsData.HorizontalSplit = this.splitContainer1.SplitterDistance;

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Handles the fetch button click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnFetchButtonClick(object sender, EventArgs e)
        {
            // Something to work with
            if (this.gameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a game to continue.", "Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            // Set variables
            this.gameList = new List<string>(this.gameTextBox.Lines);
            this.directory = this.directoryTextBox.Text;

            // Reset
            this.gameInfoRichTextBox.Clear();
            this.gameImagePictureBox.Image = null;
            this.dataTable = null;
            this.gameDataGridView.DataSource = null;

            // Add to download list box
            this.downloadItem = $"search | {this.gameTextBox.Text}";

            // Advise user
            this.resultToolStripStatusLabel.Text = $"Preparing to search \"{this.gameTextBox.Text}\"...";

            // Start timer
            fetchTimer.Start();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
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
