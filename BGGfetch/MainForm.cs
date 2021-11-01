﻿
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
        FetchForm fetchForm = null;

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

        void FetchFormFormClosing(object sender, FormClosingEventArgs e)
        {
            this.fetchedCountToolStripStatusLabel.Text = $"{this.fetchForm.Count}";

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

            this.fetchForm = new FetchForm(new List<string>(this.gameTextBox.Lines), this.directoryTextBox.Text)
            {
                Icon = this.Icon
            };

            this.fetchForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FetchFormFormClosing);

            this.fetchForm.ShowDialog();
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

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void FreeReleasesPublicDomainWeeklycomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void SourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
    }
}
