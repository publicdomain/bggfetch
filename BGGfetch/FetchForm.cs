
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.ComponentModel;
using System.Timers;

namespace BGGfetch
{
    /// <summary>
    /// Description of FetchForm.
    /// </summary>
    public partial class FetchForm : Form
    {
        /// <summary>
        /// The count.
        /// </summary>
        int count = 0;

        /// <summary>
        /// The game list.
        /// </summary>
        List<string> gameList;

        /// <summary>
        /// The directory.
        /// </summary>
        string directory;

        /// <summary>
        /// The file path.
        /// </summary>
        string filePath;

        /// <summary>
        /// The data table.
        /// </summary>
        DataTable dataTable = null;

        /// <summary>
        /// The last download date time.
        /// </summary>
        DateTime lastXmlApiDownloadDateTime = DateTime.Now;

        /// <summary>
        /// The game download row list.
        /// </summary>
        List<string> gameDownloadRowList = new List<string>();

        /// <summary>
        /// The downloaded image list.
        /// </summary>
        List<string> downloadedImageList = new List<string>();

        /// <summary>
        /// The image timer.
        /// </summary>
        System.Timers.Timer imageTimer = new System.Timers.Timer(1000);

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get
            {
                return count;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:BGGfetch.FetchForm"/> class.
        /// </summary>
        public FetchForm(List<string> gameList, string directory)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // SSL fix
            System.Net.ServicePointManager.Expect100Continue = true;
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            this.gameList = gameList;

            this.directory = directory;

            imageTimer.AutoReset = false;

            imageTimer.Elapsed += new ElapsedEventHandler(OnTimerElapsedAsync);
        }


        /// <summary>
        /// Prepare the specified inputString.
        /// </summary>
        /// <returns>The prepare.</returns>
        /// <param name="inputString">Input string.</param>
        private static string Clean(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return inputString;
            }

            return Regex.Replace(inputString.Trim(), @"\t|\n|\r", string.Empty);
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
        /// Processes the search.
        /// </summary>
        private async void ProcessSearchToDataGridViewAsync()
        {
            if (this.gameList.Count > 0)
            {
                this.gameDownloadRowList.Clear();

                var html = string.Empty;

                var retries = 0;

            retrylabel:

                //#this.Text = $"Fetching search results for \"{this.gameList[0]}\"...{ (retries > 0 ? $" Retries: {retries}" : string.Empty)}";

                WebClient webClient = new WebClient
                {
                    Proxy = null
                };

                /* Parse */

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                HtmlNode table = null;

                try
                {
                    html = await webClient.DownloadStringTaskAsync(new Uri($"https://boardgamegeek.com/geeksearch.php?action=search&objecttype=boardgame&q={Uri.EscapeDataString(this.gameList[0])}"));

                    doc.LoadHtml(html);

                    table = doc.DocumentNode.SelectSingleNode("//table[@id='collectionitems']");
                }
                catch
                {
                    // Retry until fetched or window closes
                    retries++;

                    goto retrylabel;
                }

                var tableRows = table.SelectNodes("tr");
                var columns = tableRows[0].SelectNodes("th");

                this.dataTable = new DataTable();

                // Set headers
                foreach (HtmlNode col in doc.DocumentNode.SelectNodes("//table[@id='collectionitems']/tr/th"))
                {
                    this.dataTable.Columns.Add(col.InnerText.Trim());
                }

                // Set content
                foreach (HtmlNode row in doc.DocumentNode.SelectNodes("//table[@id='collectionitems']/tr"))
                {
                    DataRow dataRow = this.dataTable.NewRow();

                    int i = 0;

                    bool hasCells = false;

                    foreach (var col in row.Descendants("td"))
                    {
                        var aTitle = col.SelectSingleNode(".//a");

                        var spanYear = col.SelectSingleNode(".//span");

                        if (spanYear != null && !aTitle.InnerText.Contains("Shop"))
                        {
                            var pDesc = col.SelectSingleNode(".//p");

                            var id = new DirectoryInfo(aTitle.GetAttributeValue("href", string.Empty)).Parent.Name;
                            var title = Clean(aTitle.InnerText);
                            var year = $" {Clean(spanYear.InnerText)}";
                            var description = pDesc != null ? $"{Environment.NewLine}{Clean(pDesc.InnerText)}" : string.Empty;
                            var fullTitle = $"{title}{year}";

                            // Set row
                            dataRow[i] = $"{title}{year}{description}";

                            // Add to list
                            this.gameDownloadRowList.Add($"{id} | {fullTitle}");
                        }
                        else
                        {
                            dataRow[i] = col.InnerText.Trim();
                        }

                        i++;

                        hasCells = true;
                    }

                    if (hasCells)
                    {
                        this.dataTable.Rows.Add(dataRow);
                    }
                }

                this.gameDataGridView.DataSource = null;
                this.gameDataGridView.DataSource = this.dataTable;
                this.gameDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.gameDataGridView.AutoResizeColumns();
                this.gameDataGridView.Refresh();
                this.gameDataGridView.ClearSelection();
                this.gameDataGridView.CurrentCell = null;

                // Advise user
                this.Text = "Please click next gane title cell to process";
            }
            else
            {
                this.Text = "All games searched.";
            }
        }

        /// <summary>
        /// Fetchs the form load.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void FetchFormLoad(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Fetchs the form shown.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void FetchFormShown(object sender, EventArgs e)
        {
            this.ProcessSearchToDataGridViewAsync();
        }

        /// <summary>
        /// Games the data grid view cell content click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void GameDataGridViewCellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            // Blank it
            this.gameDataGridView.DataSource = null;

            // Add to download list
            this.downloadListBox.Items.Add(this.gameDownloadRowList[e.RowIndex]);

            // Start the image download timer
            this.imageTimer.Start();

            if (this.gameList.Count > 0)
            {
                // Remove from game list
                this.gameList.RemoveAt(0);

                this.ProcessSearchToDataGridViewAsync();
            }
            else
            {
                this.Text = "All games searched.";
            }
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
                this.imageTimer.Stop();

                return;
            }

            // Diff check
            TimeSpan timeDiff = DateTime.Now - this.lastXmlApiDownloadDateTime;

            if (timeDiff.TotalSeconds < 5)
            {
                return;
            }

            /* Download image */

            try
            {
                var xml = string.Empty;

                var item = this.downloadListBox.Items[0].ToString().Split(new string[] { " | " }, StringSplitOptions.None);

                var id = item[0];
                var title = item[1];

                this.browserToolStripStatusLabel.Text = $"Downloading image for: \"{title}\"...";

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

                var image = doc.DocumentNode.SelectSingleNode("//image");

                var directoryPath = Path.Combine(this.directory, this.GetValidDirectoryName(title));

                this.filePath = Path.Combine(directoryPath, Path.GetFileName(image.InnerHtml));

                Directory.CreateDirectory(directoryPath);

                await webClient.DownloadFileTaskAsync(new Uri(image.InnerHtml), this.filePath);

                if (File.Exists(this.filePath))
                {
                    // Success
                    this.downloadListBox.Items.RemoveAt(0);
                }
            }
            catch
            {
                // Let it fall through for next iteration
            }

            if (this.downloadListBox.Items.Count > 0)
            {
                // Next item
                this.imageTimer.Start();
            }
            else
            {
                // All done
                this.downloadListBox.Enabled = false;

                this.browserToolStripStatusLabel.Text = "All queued game images downloaded.";
            }
        }
    }
}
