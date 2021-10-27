
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BGGfetch
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        BrowserForm browserForm = null;

        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();
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

        void BrowserFormFormClosing(object sender, FormClosingEventArgs e)
        {
            this.fetchedCountToolStripStatusLabel.Text = $"{this.browserForm.Index}";

            this.startButton.Enabled = true;
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

            this.startButton.Enabled = false;

            this.browserForm = new BrowserForm(new List<string>(this.gameTextBox.Lines), this.directoryTextBox.Text);
            this.browserForm.Icon = this.Icon;
            this.browserForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowserFormFormClosing);
            this.browserForm.ShowDialog();
        }

        void NewToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void FreeReleasesPublicDomainWeeklycomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void SourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
    }
}
