
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
        	this.components = new System.ComponentModel.Container();
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
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.freeReleasesPublicDomainIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.ApiToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.ApiCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.fetchedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.fetchedCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.resultToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        	this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        	this.gameInfoRichTextBox = new System.Windows.Forms.RichTextBox();
        	this.gamesLabel = new System.Windows.Forms.Label();
        	this.directoryLabel = new System.Windows.Forms.Label();
        	this.fetchButton = new System.Windows.Forms.Button();
        	this.gameTextBox = new System.Windows.Forms.TextBox();
        	this.browseButton = new System.Windows.Forms.Button();
        	this.directoryTextBox = new System.Windows.Forms.TextBox();
        	this.mainTabControl = new System.Windows.Forms.TabControl();
        	this.searchTabPage = new System.Windows.Forms.TabPage();
        	this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.gameDataGridView = new System.Windows.Forms.DataGridView();
        	this.searchTabButton = new System.Windows.Forms.Button();
        	this.gameInfoTabPage = new System.Windows.Forms.TabPage();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.gameInfoPrevButton = new System.Windows.Forms.Button();
        	this.gameImagePictureBox = new System.Windows.Forms.PictureBox();
        	this.gameInfoNextButton = new System.Windows.Forms.Button();
        	this.searchXmlTabPage = new System.Windows.Forms.TabPage();
        	this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        	this.xmlGameResultTextBox = new System.Windows.Forms.TextBox();
        	this.searchXmlKabel = new System.Windows.Forms.Label();
        	this.imageXmlLabel = new System.Windows.Forms.Label();
        	this.xmlSearchTextBox = new System.Windows.Forms.TextBox();
        	this.xmlTabButton = new System.Windows.Forms.Button();
        	this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTabControl.SuspendLayout();
        	this.searchTabPage.SuspendLayout();
        	this.searchTableLayoutPanel.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
        	this.gameInfoTabPage.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameImagePictureBox)).BeginInit();
        	this.searchXmlTabPage.SuspendLayout();
        	this.tableLayoutPanel3.SuspendLayout();
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
        	this.mainMenuStrip.Size = new System.Drawing.Size(414, 24);
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
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
        	this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Visible = false;
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
        	this.toolStripSeparator.Visible = false;
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
        	this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.saveToolStripMenuItem.Text = "&Save";
        	this.saveToolStripMenuItem.Visible = false;
        	this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToolStripMenuItemClick);
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
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.freeReleasesPublicDomainIsToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// freeReleasesPublicDomainIsToolStripMenuItem
        	// 
        	this.freeReleasesPublicDomainIsToolStripMenuItem.Name = "freeReleasesPublicDomainIsToolStripMenuItem";
        	this.freeReleasesPublicDomainIsToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.freeReleasesPublicDomainIsToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
        	this.freeReleasesPublicDomainIsToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainIsToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
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
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.ApiToolStripStatusLabel,
        	        	        	this.ApiCountToolStripStatusLabel,
        	        	        	this.toolStripStatusLabel2,
        	        	        	this.fetchedToolStripStatusLabel,
        	        	        	this.fetchedCountToolStripStatusLabel,
        	        	        	this.toolStripStatusLabel1,
        	        	        	this.resultToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 354);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(414, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 40;
        	// 
        	// ApiToolStripStatusLabel
        	// 
        	this.ApiToolStripStatusLabel.Name = "ApiToolStripStatusLabel";
        	this.ApiToolStripStatusLabel.Size = new System.Drawing.Size(28, 17);
        	this.ApiToolStripStatusLabel.Text = "API:";
        	// 
        	// ApiCountToolStripStatusLabel
        	// 
        	this.ApiCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.ApiCountToolStripStatusLabel.Name = "ApiCountToolStripStatusLabel";
        	this.ApiCountToolStripStatusLabel.Size = new System.Drawing.Size(24, 17);
        	this.ApiCountToolStripStatusLabel.Text = "OK";
        	// 
        	// toolStripStatusLabel2
        	// 
        	this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        	this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
        	this.toolStripStatusLabel2.Text = "|";
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
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
        	this.toolStripStatusLabel1.Text = "/";
        	// 
        	// resultToolStripStatusLabel
        	// 
        	this.resultToolStripStatusLabel.Name = "resultToolStripStatusLabel";
        	this.resultToolStripStatusLabel.Size = new System.Drawing.Size(161, 17);
        	this.resultToolStripStatusLabel.Text = "Waiting for a game to fetch...";
        	// 
        	// openFileDialog
        	// 
        	this.openFileDialog.DefaultExt = "txt";
        	this.openFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.openFileDialog.Title = "Open games file";
        	// 
        	// saveFileDialog
        	// 
        	this.saveFileDialog.DefaultExt = "txt";
        	this.saveFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.saveFileDialog.Title = "Save games file";
        	// 
        	// folderBrowserDialog
        	// 
        	this.folderBrowserDialog.Description = "Open high-res directory";
        	// 
        	// gameInfoRichTextBox
        	// 
        	this.gameInfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameInfoRichTextBox.Location = new System.Drawing.Point(28, 3);
        	this.gameInfoRichTextBox.Name = "gameInfoRichTextBox";
        	this.gameInfoRichTextBox.Size = new System.Drawing.Size(344, 143);
        	this.gameInfoRichTextBox.TabIndex = 3;
        	this.gameInfoRichTextBox.Text = "";
        	// 
        	// gamesLabel
        	// 
        	this.searchTableLayoutPanel.SetColumnSpan(this.gamesLabel, 2);
        	this.gamesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gamesLabel.Location = new System.Drawing.Point(3, 0);
        	this.gamesLabel.Name = "gamesLabel";
        	this.gamesLabel.Size = new System.Drawing.Size(369, 25);
        	this.gamesLabel.TabIndex = 0;
        	this.gamesLabel.Text = "&Game:";
        	this.gamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// directoryLabel
        	// 
        	this.searchTableLayoutPanel.SetColumnSpan(this.directoryLabel, 2);
        	this.directoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.directoryLabel.Location = new System.Drawing.Point(3, 50);
        	this.directoryLabel.Name = "directoryLabel";
        	this.directoryLabel.Size = new System.Drawing.Size(369, 25);
        	this.directoryLabel.TabIndex = 1;
        	this.directoryLabel.Text = "&Directory:";
        	this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// fetchButton
        	// 
        	this.searchTableLayoutPanel.SetColumnSpan(this.fetchButton, 2);
        	this.fetchButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fetchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.fetchButton.Location = new System.Drawing.Point(3, 103);
        	this.fetchButton.Name = "fetchButton";
        	this.fetchButton.Size = new System.Drawing.Size(369, 44);
        	this.fetchButton.TabIndex = 3;
        	this.fetchButton.Text = "&FETCH INFO";
        	this.fetchButton.UseVisualStyleBackColor = true;
        	this.fetchButton.Click += new System.EventHandler(this.OnFetchButtonClick);
        	// 
        	// gameTextBox
        	// 
        	this.searchTableLayoutPanel.SetColumnSpan(this.gameTextBox, 2);
        	this.gameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gameTextBox.Location = new System.Drawing.Point(3, 28);
        	this.gameTextBox.Name = "gameTextBox";
        	this.gameTextBox.Size = new System.Drawing.Size(369, 24);
        	this.gameTextBox.TabIndex = 0;
        	// 
        	// browseButton
        	// 
        	this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.browseButton.Location = new System.Drawing.Point(301, 76);
        	this.browseButton.Margin = new System.Windows.Forms.Padding(1);
        	this.browseButton.Name = "browseButton";
        	this.browseButton.Size = new System.Drawing.Size(73, 23);
        	this.browseButton.TabIndex = 2;
        	this.browseButton.Text = "&Browse";
        	this.browseButton.UseVisualStyleBackColor = true;
        	this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
        	// 
        	// directoryTextBox
        	// 
        	this.directoryTextBox.AllowDrop = true;
        	this.directoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryTextBox.Location = new System.Drawing.Point(1, 76);
        	this.directoryTextBox.Margin = new System.Windows.Forms.Padding(1);
        	this.directoryTextBox.Name = "directoryTextBox";
        	this.directoryTextBox.Size = new System.Drawing.Size(298, 20);
        	this.directoryTextBox.TabIndex = 1;
        	// 
        	// mainTabControl
        	// 
        	this.mainTabControl.Controls.Add(this.searchTabPage);
        	this.mainTabControl.Controls.Add(this.gameInfoTabPage);
        	this.mainTabControl.Controls.Add(this.searchXmlTabPage);
        	this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTabControl.Location = new System.Drawing.Point(0, 24);
        	this.mainTabControl.Name = "mainTabControl";
        	this.mainTabControl.SelectedIndex = 0;
        	this.mainTabControl.Size = new System.Drawing.Size(414, 330);
        	this.mainTabControl.TabIndex = 43;
        	// 
        	// searchTabPage
        	// 
        	this.searchTabPage.Controls.Add(this.searchTableLayoutPanel);
        	this.searchTabPage.Location = new System.Drawing.Point(4, 22);
        	this.searchTabPage.Name = "searchTabPage";
        	this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.searchTabPage.Size = new System.Drawing.Size(406, 304);
        	this.searchTabPage.TabIndex = 0;
        	this.searchTabPage.Text = "Search";
        	this.searchTabPage.UseVisualStyleBackColor = true;
        	// 
        	// searchTableLayoutPanel
        	// 
        	this.searchTableLayoutPanel.ColumnCount = 3;
        	this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
        	this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.searchTableLayoutPanel.Controls.Add(this.gameDataGridView, 0, 5);
        	this.searchTableLayoutPanel.Controls.Add(this.fetchButton, 0, 4);
        	this.searchTableLayoutPanel.Controls.Add(this.browseButton, 1, 3);
        	this.searchTableLayoutPanel.Controls.Add(this.directoryLabel, 0, 2);
        	this.searchTableLayoutPanel.Controls.Add(this.directoryTextBox, 0, 3);
        	this.searchTableLayoutPanel.Controls.Add(this.gamesLabel, 0, 0);
        	this.searchTableLayoutPanel.Controls.Add(this.gameTextBox, 0, 1);
        	this.searchTableLayoutPanel.Controls.Add(this.searchTabButton, 2, 0);
        	this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.searchTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
        	this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
        	this.searchTableLayoutPanel.RowCount = 6;
        	this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        	this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.searchTableLayoutPanel.Size = new System.Drawing.Size(400, 298);
        	this.searchTableLayoutPanel.TabIndex = 44;
        	// 
        	// gameDataGridView
        	// 
        	this.gameDataGridView.AllowUserToAddRows = false;
        	this.gameDataGridView.AllowUserToDeleteRows = false;
        	this.gameDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        	this.gameDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.searchTableLayoutPanel.SetColumnSpan(this.gameDataGridView, 2);
        	this.gameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameDataGridView.Location = new System.Drawing.Point(3, 153);
        	this.gameDataGridView.MultiSelect = false;
        	this.gameDataGridView.Name = "gameDataGridView";
        	this.gameDataGridView.ReadOnly = true;
        	this.gameDataGridView.RowHeadersVisible = false;
        	this.gameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.gameDataGridView.Size = new System.Drawing.Size(369, 142);
        	this.gameDataGridView.TabIndex = 4;
        	this.gameDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGameDataGridViewCellClick);
        	// 
        	// searchTabButton
        	// 
        	this.searchTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.searchTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.searchTabButton.Location = new System.Drawing.Point(376, 1);
        	this.searchTabButton.Margin = new System.Windows.Forms.Padding(1);
        	this.searchTabButton.Name = "searchTabButton";
        	this.searchTableLayoutPanel.SetRowSpan(this.searchTabButton, 6);
        	this.searchTabButton.Size = new System.Drawing.Size(23, 296);
        	this.searchTabButton.TabIndex = 5;
        	this.searchTabButton.Text = ">";
        	this.searchTabButton.UseVisualStyleBackColor = true;
        	this.searchTabButton.Click += new System.EventHandler(this.OnSearchTabButtonClick);
        	// 
        	// gameInfoTabPage
        	// 
        	this.gameInfoTabPage.Controls.Add(this.tableLayoutPanel1);
        	this.gameInfoTabPage.Location = new System.Drawing.Point(4, 22);
        	this.gameInfoTabPage.Name = "gameInfoTabPage";
        	this.gameInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.gameInfoTabPage.Size = new System.Drawing.Size(406, 304);
        	this.gameInfoTabPage.TabIndex = 2;
        	this.gameInfoTabPage.Text = "Game info";
        	this.gameInfoTabPage.UseVisualStyleBackColor = true;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 3;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel1.Controls.Add(this.gameInfoRichTextBox, 1, 0);
        	this.tableLayoutPanel1.Controls.Add(this.gameInfoPrevButton, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.gameImagePictureBox, 1, 1);
        	this.tableLayoutPanel1.Controls.Add(this.gameInfoNextButton, 2, 0);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 2;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 298);
        	this.tableLayoutPanel1.TabIndex = 4;
        	// 
        	// gameInfoPrevButton
        	// 
        	this.gameInfoPrevButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameInfoPrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gameInfoPrevButton.Location = new System.Drawing.Point(1, 1);
        	this.gameInfoPrevButton.Margin = new System.Windows.Forms.Padding(1);
        	this.gameInfoPrevButton.Name = "gameInfoPrevButton";
        	this.tableLayoutPanel1.SetRowSpan(this.gameInfoPrevButton, 2);
        	this.gameInfoPrevButton.Size = new System.Drawing.Size(23, 296);
        	this.gameInfoPrevButton.TabIndex = 4;
        	this.gameInfoPrevButton.Text = "<";
        	this.gameInfoPrevButton.UseVisualStyleBackColor = true;
        	this.gameInfoPrevButton.Click += new System.EventHandler(this.OnGameInfoPrevButtonClick);
        	// 
        	// gameImagePictureBox
        	// 
        	this.gameImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameImagePictureBox.Location = new System.Drawing.Point(28, 152);
        	this.gameImagePictureBox.Name = "gameImagePictureBox";
        	this.gameImagePictureBox.Size = new System.Drawing.Size(344, 143);
        	this.gameImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.gameImagePictureBox.TabIndex = 6;
        	this.gameImagePictureBox.TabStop = false;
        	// 
        	// gameInfoNextButton
        	// 
        	this.gameInfoNextButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameInfoNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gameInfoNextButton.Location = new System.Drawing.Point(376, 1);
        	this.gameInfoNextButton.Margin = new System.Windows.Forms.Padding(1);
        	this.gameInfoNextButton.Name = "gameInfoNextButton";
        	this.tableLayoutPanel1.SetRowSpan(this.gameInfoNextButton, 2);
        	this.gameInfoNextButton.Size = new System.Drawing.Size(23, 296);
        	this.gameInfoNextButton.TabIndex = 7;
        	this.gameInfoNextButton.Text = ">";
        	this.gameInfoNextButton.UseVisualStyleBackColor = true;
        	this.gameInfoNextButton.Click += new System.EventHandler(this.OnGameInfoNextButtonClick);
        	// 
        	// searchXmlTabPage
        	// 
        	this.searchXmlTabPage.Controls.Add(this.tableLayoutPanel3);
        	this.searchXmlTabPage.Location = new System.Drawing.Point(4, 22);
        	this.searchXmlTabPage.Name = "searchXmlTabPage";
        	this.searchXmlTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.searchXmlTabPage.Size = new System.Drawing.Size(406, 304);
        	this.searchXmlTabPage.TabIndex = 4;
        	this.searchXmlTabPage.Text = "XML";
        	this.searchXmlTabPage.UseVisualStyleBackColor = true;
        	// 
        	// tableLayoutPanel3
        	// 
        	this.tableLayoutPanel3.ColumnCount = 2;
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.Controls.Add(this.xmlGameResultTextBox, 1, 3);
        	this.tableLayoutPanel3.Controls.Add(this.searchXmlKabel, 1, 0);
        	this.tableLayoutPanel3.Controls.Add(this.imageXmlLabel, 1, 2);
        	this.tableLayoutPanel3.Controls.Add(this.xmlSearchTextBox, 1, 1);
        	this.tableLayoutPanel3.Controls.Add(this.xmlTabButton, 0, 0);
        	this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
        	this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        	this.tableLayoutPanel3.RowCount = 4;
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel3.Size = new System.Drawing.Size(400, 298);
        	this.tableLayoutPanel3.TabIndex = 2;
        	// 
        	// xmlGameResultTextBox
        	// 
        	this.xmlGameResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.xmlGameResultTextBox.Location = new System.Drawing.Point(28, 177);
        	this.xmlGameResultTextBox.Multiline = true;
        	this.xmlGameResultTextBox.Name = "xmlGameResultTextBox";
        	this.xmlGameResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.xmlGameResultTextBox.Size = new System.Drawing.Size(369, 118);
        	this.xmlGameResultTextBox.TabIndex = 3;
        	this.xmlGameResultTextBox.WordWrap = false;
        	// 
        	// searchXmlKabel
        	// 
        	this.searchXmlKabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.searchXmlKabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.searchXmlKabel.Location = new System.Drawing.Point(28, 0);
        	this.searchXmlKabel.Name = "searchXmlKabel";
        	this.searchXmlKabel.Size = new System.Drawing.Size(369, 25);
        	this.searchXmlKabel.TabIndex = 1;
        	this.searchXmlKabel.Text = "Search XML:";
        	this.searchXmlKabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// imageXmlLabel
        	// 
        	this.imageXmlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.imageXmlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.imageXmlLabel.Location = new System.Drawing.Point(28, 149);
        	this.imageXmlLabel.Name = "imageXmlLabel";
        	this.imageXmlLabel.Size = new System.Drawing.Size(369, 25);
        	this.imageXmlLabel.TabIndex = 2;
        	this.imageXmlLabel.Text = "Game XML:";
        	this.imageXmlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// xmlSearchTextBox
        	// 
        	this.xmlSearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.xmlSearchTextBox.Location = new System.Drawing.Point(28, 28);
        	this.xmlSearchTextBox.Multiline = true;
        	this.xmlSearchTextBox.Name = "xmlSearchTextBox";
        	this.xmlSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.xmlSearchTextBox.Size = new System.Drawing.Size(369, 118);
        	this.xmlSearchTextBox.TabIndex = 0;
        	this.xmlSearchTextBox.WordWrap = false;
        	// 
        	// xmlTabButton
        	// 
        	this.xmlTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.xmlTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.xmlTabButton.Location = new System.Drawing.Point(1, 1);
        	this.xmlTabButton.Margin = new System.Windows.Forms.Padding(1);
        	this.xmlTabButton.Name = "xmlTabButton";
        	this.tableLayoutPanel3.SetRowSpan(this.xmlTabButton, 4);
        	this.xmlTabButton.Size = new System.Drawing.Size(23, 296);
        	this.xmlTabButton.TabIndex = 4;
        	this.xmlTabButton.Text = "<";
        	this.xmlTabButton.UseVisualStyleBackColor = true;
        	this.xmlTabButton.Click += new System.EventHandler(this.OnXmlTabButtonClick);
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.fetchButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(414, 376);
        	this.Controls.Add(this.mainTabControl);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        	this.Text = "BGGfetch";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
        	this.Load += new System.EventHandler(this.OnMainFormLoad);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTabControl.ResumeLayout(false);
        	this.searchTabPage.ResumeLayout(false);
        	this.searchTableLayoutPanel.ResumeLayout(false);
        	this.searchTableLayoutPanel.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
        	this.gameInfoTabPage.ResumeLayout(false);
        	this.tableLayoutPanel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.gameImagePictureBox)).EndInit();
        	this.searchXmlTabPage.ResumeLayout(false);
        	this.tableLayoutPanel3.ResumeLayout(false);
        	this.tableLayoutPanel3.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button xmlTabButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label imageXmlLabel;
        private System.Windows.Forms.Label searchXmlKabel;
        private System.Windows.Forms.Button searchTabButton;
        private System.Windows.Forms.Button gameInfoNextButton;
        private System.Windows.Forms.Button gameInfoPrevButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox xmlGameResultTextBox;
        private System.Windows.Forms.TextBox xmlSearchTextBox;
        private System.Windows.Forms.TabPage searchXmlTabPage;
        private System.Windows.Forms.TabPage gameInfoTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.RichTextBox gameInfoRichTextBox;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ApiCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ApiToolStripStatusLabel;
        private System.Windows.Forms.PictureBox gameImagePictureBox;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel resultToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel fetchedCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fetchedToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainIsToolStripMenuItem;
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
