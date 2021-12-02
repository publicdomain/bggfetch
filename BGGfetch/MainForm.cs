
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
using ReadSharp;

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
        DataTable dataTable = null;

        /// <summary>
        /// The last download date time.
        /// </summary>
        DateTime lastXmlApiDownloadDateTime = DateTime.Now;

        /// <summary>
        /// The fetch timer.
        /// </summary>
        System.Timers.Timer fetchTimer = new System.Timers.Timer(1000);

        /// <summary>
        /// The game list.
        /// </summary>
        List<string> gameList;

        /// <summary>
        /// The index of the game list.
        /// </summary>
        int gameListIndex = 0;

        /// <summary>
        /// The directory.
        /// </summary>
        string directory;

        /// <summary>
        /// The file path.
        /// </summary>
        string filePath;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

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

            fetchTimer.AutoReset = true;

            fetchTimer.Elapsed += new ElapsedEventHandler(OnTimerElapsedAsync);

            fetchTimer.Start();
        }

        void GameTextBoxTextChanged(object sender, EventArgs e)
        {
            this.gameCountToolStripStatusLabel.Text = this.gameTextBox.Lines.Length.ToString();
        }

        void BrowseButtonClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = string.Empty;

            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                this.directoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        void StartButtonClick(object sender, EventArgs e)
        {
            // Something to work with
            if (this.gameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter at least one game to continue.", "Games", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            // Change to results tab
            this.tabControl.SelectTab(1);

            // Set variables
            this.gameList = new List<string>(this.gameTextBox.Lines);
            this.gameListIndex = 0;
            this.directory = this.directoryTextBox.Text;

            // Begin game search by triggering next game
            this.nextGameButton.PerformClick();

            // TODO Disable start button until finishing [Can be changed to "STOP FETCHING"]
            this.startButton.Enabled = false;
        }

        void NewToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.gameTextBox.Clear();

            this.directoryTextBox.Clear();

            this.gameTextBox.Focus();
        }

        void OpenToolStripMenuItemClick(object sender, EventArgs e)
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

        void SaveToolStripMenuItemClick(object sender, EventArgs e)
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

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("AboutToolStripMenuItemClick placeholder :)");
        }

        void FreeReleasesPublicDomainIsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        void OriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=51939.0");
        }

        void SourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
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

        void DirectoryTextBoxDragDrop(object sender, DragEventArgs e)
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

        void DirectoryTextBoxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        void GameDataGridViewClick(object sender, EventArgs e)
        {
            try
            {
                // Add to download list box
                this.downloadListBox.Items.Add($"{this.gameDataGridView.SelectedRows[0].Cells[0].Value.ToString()} | {this.gameDataGridView.SelectedRows[0].Cells[1].Value.ToString()} | {this.gameDataGridView.SelectedRows[0].Cells[2].Value.ToString()}");
            }
            catch
            {
                // Let it fall through
                ;
            }
        }

        void NextGameButtonClick(object sender, EventArgs e)
        {
            // Add to download list box
            this.downloadListBox.Items.Add($"search | {this.gameList[this.gameListIndex]}");

            // Raise index
            this.gameListIndex++;
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
        /// Ons the timer elapsed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        public async void OnTimerElapsedAsync(object sender, ElapsedEventArgs e)
        {
            // Basic checks
            if (this.downloadListBox.Items.Count == 0)
            {
                return;
            }

            // Diff check
            TimeSpan timeDiff = DateTime.Now - this.lastXmlApiDownloadDateTime;

            if (timeDiff.TotalSeconds < 5)
            {
                return;
            }

            /* Search or fetch game info */

            var xml = string.Empty;

            var item = this.downloadListBox.Items[0].ToString().Split(new string[] { " | " }, StringSplitOptions.None);

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

                    // Set new datetime
                    this.lastXmlApiDownloadDateTime = DateTime.Now;

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

                        // Set values
                        dataRow[0] = game.Attributes["objectid"].Value;
                        dataRow[1] = game.ChildNodes["yearpublished"].InnerText;
                        dataRow[2] = HtmlUtilities.ConvertToPlainText(game.ChildNodes["name"].InnerHtml);

                        // Add to data table 
                        this.dataTable.Rows.Add(dataRow);
                    }

                    // TODO)DO Update data grid view [Check clear & refreshing]
                    this.gameDataGridView.DataSource = null;
                    this.gameDataGridView.DataSource = this.dataTable;
                    this.gameDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    this.gameDataGridView.AutoResizeColumns();
                    this.gameDataGridView.Refresh();
                    this.gameDataGridView.ClearSelection();
                    this.gameDataGridView.CurrentCell = null;

                    // Remove from list
                    this.downloadListBox.Items.RemoveAt(0);

                    // Advise user
                    this.Text = "Please click a gane to process";
                }
                catch (Exception ex)
                {
                    // Let it fall through for next iteration
                    ;
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

                    // Set new datetime
                    this.lastXmlApiDownloadDateTime = DateTime.Now;

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    doc.LoadHtml(xml);

                    // Desription

                    var desription = doc.DocumentNode.SelectSingleNode("//description");

                    this.gameInfoTextBox.Text = HtmlUtilities.ConvertToPlainText(desription.InnerHtml);

                    // Image

                    var image = doc.DocumentNode.SelectSingleNode("//image");

                    this.filePath = Path.Combine(this.directory, this.GetValidDirectoryName($"{title}_{Path.GetFileName(image.InnerHtml)}"));

                    await webClient.DownloadFileTaskAsync(new Uri(image.InnerHtml), this.filePath);

                    if (File.Exists(this.filePath))
                    {
                        // Load picture
                        this.gameImagePictureBox.Image = Image.FromFile(this.filePath);

                        // Success
                        this.downloadListBox.Items.RemoveAt(0);
                    }
                }
                catch
                {
                    // Let it fall through for next iteration
                }
            }

            // Check iif all games have been processed
            if (this.downloadListBox.Items.Count == 0 && this.gameListIndex == this.gameList.Count - 1)
            {
                this.resultToolStripStatusLabel.Text = "All games have been fetched.";

                // Re-enable start button
                this.startButton.Enabled = true;
            }
        }

        void GameImagePictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var files = new string[] { this.filePath };

                this.gameImagePictureBox.DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy | DragDropEffects.Move);

            }
        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
