
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Linq;

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
        /// The search retries.
        /// </summary>
        int searchRetries = 0;

        /// <summary>
        /// The game list.
        /// </summary>
        List<string> gameList;

        /// <summary>
        /// The directory.
        /// </summary>
        string directory;

        /// <summary>
        /// The web client.
        /// </summary>
        WebClient searchWebClient = new WebClient();

        /// <summary>
        /// The download web client.
        /// </summary>
        WebClient downloadWebClient = new WebClient();

        /// <summary>
        /// The html.
        /// </summary>
        string html = string.Empty;

        /// <summary>
        /// The xml.
        /// </summary>
        string xml = string.Empty;

        /// <summary>
        /// The data table.
        /// </summary>
        DataTable dataTable = new DataTable();

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

            this.gameList = gameList;

            this.directory = directory;

            searchWebClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnSearchDownloadStringCompleted);
        }

        /// <summary>
        /// Handles the search download string completed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnSearchDownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                this.html = e.Result;

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                doc.LoadHtml(e.Result);

                var table = doc.DocumentNode.SelectSingleNode("//table");
                var tableRows = table.SelectNodes("tr");
                var columns = tableRows[0].SelectNodes("th");

                // Set headers
                foreach (HtmlNode col in doc.DocumentNode.SelectNodes("//table[@id='collectionitems']//tr/th"))
                {
                    this.dataTable.Columns.Add(col.InnerText.Trim());
                }

                // Set content
                foreach (HtmlNode row in doc.DocumentNode.SelectNodes("//table[@id='collectionitems']//tr"))
                {
                    DataRow dataRow = this.dataTable.NewRow();

                    int i = 0;

                    bool hasCells = false;

                    foreach (var col in row.Descendants("td"))
                    {
                        dataRow[i] = col.InnerText.Trim()/*.Replace(Environment.NewLine, " ").Replace("\t", string.Empty)*/;

                        i++;

                        hasCells = true;
                    }

                    if (hasCells)
                    { this.dataTable.Rows.Add(dataRow); }
                }

                this.gameDataGridView.DataSource = null;
                this.gameDataGridView.DataSource = this.dataTable;

                // reset search retries
                this.searchRetries = 0;
            }
            else
            {
                // Raise
                this.searchRetries++;

                // Retry
                this.ProcessSearchToListView();
            }
        }

        /// <summary>
        /// Processes the search.
        /// </summary>
        private void ProcessSearchToListView()
        {
            if (this.gameList.Count > 0)
            {
                this.Text = $"Fetching search results.{ (this.searchRetries > 0 ? $"Retries: {this.searchRetries}" : string.Empty)}";

                this.searchWebClient.DownloadStringAsync(new Uri($"https://boardgamegeek.com/geeksearch.php?action=search&objecttype=boardgame&q={Uri.EscapeDataString(this.gameList[0])}"));
            }
            else
            {
                this.gameDataGridView.Enabled = false;
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
            this.ProcessSearchToListView();
        }

        /// <summary>
        /// Timers the tick.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void TimerTick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Games the data grid view cell content click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void GameDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
