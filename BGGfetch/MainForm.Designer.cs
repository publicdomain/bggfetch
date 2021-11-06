
namespace BGGfetch
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchMaximixedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainWeeklycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.gamesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fetchedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fetchedCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.browseButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.minimizeToolStripMenuItem,
                                    this.fileToolStripMenuItem,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 41;
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.minimizeToolStripMenuItem.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.saveToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.fetchMaximixedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // fetchMaximixedToolStripMenuItem
            // 
            this.fetchMaximixedToolStripMenuItem.Checked = true;
            this.fetchMaximixedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fetchMaximixedToolStripMenuItem.Name = "fetchMaximixedToolStripMenuItem";
            this.fetchMaximixedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fetchMaximixedToolStripMenuItem.Text = "&Fetch maximixed";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainWeeklycomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainWeeklycomToolStripMenuItem
            // 
            this.freeReleasesPublicDomainWeeklycomToolStripMenuItem.Name = "freeReleasesPublicDomainWeeklycomToolStripMenuItem";
            this.freeReleasesPublicDomainWeeklycomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.freeReleasesPublicDomainWeeklycomToolStripMenuItem.Text = "&Free releases @ PublicDomainGift.com";
            this.freeReleasesPublicDomainWeeklycomToolStripMenuItem.Click += new System.EventHandler(this.FreeReleasesPublicDomainWeeklycomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.SourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.gamesToolStripStatusLabel,
                                    this.gameCountToolStripStatusLabel,
                                    this.fetchedToolStripStatusLabel,
                                    this.fetchedCountToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 364);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 40;
            // 
            // gamesToolStripStatusLabel
            // 
            this.gamesToolStripStatusLabel.Name = "gamesToolStripStatusLabel";
            this.gamesToolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.gamesToolStripStatusLabel.Text = "Games:";
            // 
            // gameCountToolStripStatusLabel
            // 
            this.gameCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gameCountToolStripStatusLabel.Name = "gameCountToolStripStatusLabel";
            this.gameCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.gameCountToolStripStatusLabel.Text = "0";
            // 
            // fetchedToolStripStatusLabel
            // 
            this.fetchedToolStripStatusLabel.Name = "fetchedToolStripStatusLabel";
            this.fetchedToolStripStatusLabel.Size = new System.Drawing.Size(52, 17);
            this.fetchedToolStripStatusLabel.Text = "Fetched:";
            // 
            // fetchedCountToolStripStatusLabel
            // 
            this.fetchedCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchedCountToolStripStatusLabel.Name = "fetchedCountToolStripStatusLabel";
            this.fetchedCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.fetchedCountToolStripStatusLabel.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gamesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.directoryLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.gameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 340);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // gamesLabel
            // 
            this.gamesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLabel.Location = new System.Drawing.Point(3, 0);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(278, 25);
            this.gamesLabel.TabIndex = 0;
            this.gamesLabel.Text = "&Games:";
            this.gamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directoryLabel
            // 
            this.directoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryLabel.Location = new System.Drawing.Point(3, 241);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(278, 25);
            this.directoryLabel.TabIndex = 1;
            this.directoryLabel.Text = "&Directory:";
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(3, 298);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(278, 39);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "&START FETCHING";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // gameTextBox
            // 
            this.gameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTextBox.Location = new System.Drawing.Point(3, 28);
            this.gameTextBox.Multiline = true;
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.Size = new System.Drawing.Size(278, 210);
            this.gameTextBox.TabIndex = 3;
            this.gameTextBox.TextChanged += new System.EventHandler(this.GameTextBoxTextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.directoryTextBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 266);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 25);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Location = new System.Drawing.Point(199, 1);
            this.browseButton.Margin = new System.Windows.Forms.Padding(1);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(84, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryTextBox.Location = new System.Drawing.Point(1, 1);
            this.directoryTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(196, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open games file";
            // 
            // SaveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save games file";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Open high-res directory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BGGfetch";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fetchMaximixedToolStripMenuItem;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel fetchedCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fetchedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel gameCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel gamesToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainWeeklycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
