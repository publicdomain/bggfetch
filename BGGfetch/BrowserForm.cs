
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace BGGfetch
{
    /// <summary>
    /// Description of BrowserForm.
    /// </summary>
    public partial class BrowserForm : Form
    {
        List<string> gameList = new List<string>();

        string directoryPath;

        int index = 0;

        public int Index
        {
            get
            {
                return index;
            }
        }

        public BrowserForm(List<string> gameList, string directoryPath)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();

            this.gameList = gameList;

            this.directoryPath = directoryPath;

            this.webBrowser.ScriptErrorsSuppressed = true;

            this.Text = $"Select target game from search results";

            this.webBrowser.Url = new Uri($"https://boardgamegeek.com/geeksearch.php?action=search&objecttype=boardgame&q={Uri.EscapeDataString(this.gameList[0])}");
        }

        void WebBrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.browserToolStripStatusLabel.Text = this.webBrowser.Url.ToString();

            // Game
            if (this.webBrowser.Url.ToString().StartsWith("https://boardgamegeek.com/boardgame/", StringComparison.InvariantCulture))
            {
                this.Text = $"Auto-processing game | {this.webBrowser.DocumentTitle}";

                HtmlElementCollection links = webBrowser.Document.Links;

                foreach (HtmlElement link in links)
                {
                    if (link.InnerText.Contains("Cover Artwork"))
                    {
                        this.webBrowser.Url = new Uri(link.GetAttribute("href").ToString());

                        break;
                    }
                }
            }

            // Cover artwork
            if (this.webBrowser.Url.ToString().StartsWith("https://boardgamegeek.com/image/", StringComparison.InvariantCulture))
            {
                this.Text = $"Auto-processing cover artwork | {this.webBrowser.DocumentTitle}";

                HtmlElementCollection links = webBrowser.Document.Links;

                foreach (HtmlElement link in links)
                {
                    if (link.InnerHtml.Contains("original ("))
                    {
                        this.webBrowser.Url = new Uri(link.GetAttribute("href").ToString());
                    }
                }
            }

            // High-res image
            if (this.webBrowser.Url.ToString().StartsWith("https://cf.geekdo-images.com/", StringComparison.InvariantCulture))
            {
                this.Text = $"Fetching high-res image | {this.webBrowser.DocumentTitle}";

                Uri uri = new Uri(webBrowser.Document.Images[0].GetAttribute("src"));

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(uri, Path.Combine(directoryPath, Path.GetFileName(uri.AbsolutePath)));
                }

                this.index++;

                if (index == this.gameList.Count)
                {
                    this.Close();

                    return;
                }
                else
                {
                    this.Text = $"Select target game from search results";

                    this.webBrowser.Url = new Uri($"https://boardgamegeek.com/geeksearch.php?action=search&objecttype=boardgame&q={Uri.EscapeDataString(this.gameList[this.index])}");
                }
            }
        }

        void BrowserFormFormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
