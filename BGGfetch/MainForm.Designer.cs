
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
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.splitContainer = new System.Windows.Forms.SplitContainer();
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.gameDataGridView = new System.Windows.Forms.DataGridView();
        	this.gameInfoTextBox = new System.Windows.Forms.TextBox();
        	this.gameImagePictureBox = new System.Windows.Forms.PictureBox();
        	this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.gamesLabel = new System.Windows.Forms.Label();
        	this.directoryLabel = new System.Windows.Forms.Label();
        	this.fetchButton = new System.Windows.Forms.Button();
        	this.gameTextBox = new System.Windows.Forms.TextBox();
        	this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        	this.browseButton = new System.Windows.Forms.Button();
        	this.directoryTextBox = new System.Windows.Forms.TextBox();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
        	this.splitContainer.Panel1.SuspendLayout();
        	this.splitContainer.Panel2.SuspendLayout();
        	this.splitContainer.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.gameImagePictureBox)).BeginInit();
        	this.tableLayoutPanel2.SuspendLayout();
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
        	this.mainMenuStrip.Size = new System.Drawing.Size(584, 24);
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
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Visible = false;
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
        	this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Visible = false;
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
        	this.toolStripSeparator.Visible = false;
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
        	this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.saveToolStripMenuItem.Text = "&Save";
        	this.saveToolStripMenuItem.Visible = false;
        	this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToolStripMenuItemClick);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 440);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(584, 22);
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
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 1;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Controls.Add(this.splitContainer, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 2;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 416);
        	this.tableLayoutPanel1.TabIndex = 42;
        	// 
        	// splitContainer
        	// 
        	this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer.Location = new System.Drawing.Point(3, 163);
        	this.splitContainer.Name = "splitContainer";
        	// 
        	// splitContainer.Panel1
        	// 
        	this.splitContainer.Panel1.Controls.Add(this.splitContainer1);
        	// 
        	// splitContainer.Panel2
        	// 
        	this.splitContainer.Panel2.Controls.Add(this.gameImagePictureBox);
        	this.splitContainer.Size = new System.Drawing.Size(578, 250);
        	this.splitContainer.SplitterDistance = 304;
        	this.splitContainer.SplitterWidth = 6;
        	this.splitContainer.TabIndex = 44;
        	this.splitContainer.TabStop = false;
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer1.Name = "splitContainer1";
        	this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.gameDataGridView);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.gameInfoTextBox);
        	this.splitContainer1.Size = new System.Drawing.Size(304, 250);
        	this.splitContainer1.SplitterDistance = 135;
        	this.splitContainer1.SplitterWidth = 6;
        	this.splitContainer1.TabIndex = 0;
        	this.splitContainer1.TabStop = false;
        	// 
        	// gameDataGridView
        	// 
        	this.gameDataGridView.AllowUserToAddRows = false;
        	this.gameDataGridView.AllowUserToDeleteRows = false;
        	this.gameDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        	this.gameDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.gameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameDataGridView.Location = new System.Drawing.Point(0, 0);
        	this.gameDataGridView.MultiSelect = false;
        	this.gameDataGridView.Name = "gameDataGridView";
        	this.gameDataGridView.ReadOnly = true;
        	this.gameDataGridView.RowHeadersVisible = false;
        	this.gameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.gameDataGridView.Size = new System.Drawing.Size(304, 135);
        	this.gameDataGridView.TabIndex = 2;
        	this.gameDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGameDataGridViewCellClick);
        	// 
        	// gameInfoTextBox
        	// 
        	this.gameInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameInfoTextBox.Location = new System.Drawing.Point(0, 0);
        	this.gameInfoTextBox.Multiline = true;
        	this.gameInfoTextBox.Name = "gameInfoTextBox";
        	this.gameInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.gameInfoTextBox.Size = new System.Drawing.Size(304, 109);
        	this.gameInfoTextBox.TabIndex = 5;
        	// 
        	// gameImagePictureBox
        	// 
        	this.gameImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameImagePictureBox.Location = new System.Drawing.Point(0, 0);
        	this.gameImagePictureBox.Name = "gameImagePictureBox";
        	this.gameImagePictureBox.Size = new System.Drawing.Size(268, 250);
        	this.gameImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.gameImagePictureBox.TabIndex = 5;
        	this.gameImagePictureBox.TabStop = false;
        	// 
        	// tableLayoutPanel2
        	// 
        	this.tableLayoutPanel2.ColumnCount = 1;
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.Controls.Add(this.gamesLabel, 0, 0);
        	this.tableLayoutPanel2.Controls.Add(this.directoryLabel, 0, 2);
        	this.tableLayoutPanel2.Controls.Add(this.fetchButton, 0, 5);
        	this.tableLayoutPanel2.Controls.Add(this.gameTextBox, 0, 1);
        	this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
        	this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        	this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        	this.tableLayoutPanel2.RowCount = 6;
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
        	this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 154);
        	this.tableLayoutPanel2.TabIndex = 43;
        	// 
        	// gamesLabel
        	// 
        	this.gamesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gamesLabel.Location = new System.Drawing.Point(3, 0);
        	this.gamesLabel.Name = "gamesLabel";
        	this.gamesLabel.Size = new System.Drawing.Size(572, 25);
        	this.gamesLabel.TabIndex = 0;
        	this.gamesLabel.Text = "&Game:";
        	this.gamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// directoryLabel
        	// 
        	this.directoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.directoryLabel.Location = new System.Drawing.Point(3, 55);
        	this.directoryLabel.Name = "directoryLabel";
        	this.directoryLabel.Size = new System.Drawing.Size(572, 25);
        	this.directoryLabel.TabIndex = 1;
        	this.directoryLabel.Text = "&Directory:";
        	this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// fetchButton
        	// 
        	this.fetchButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fetchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.fetchButton.Location = new System.Drawing.Point(3, 111);
        	this.fetchButton.Name = "fetchButton";
        	this.fetchButton.Size = new System.Drawing.Size(572, 40);
        	this.fetchButton.TabIndex = 3;
        	this.fetchButton.Text = "&FETCH INFO";
        	this.fetchButton.UseVisualStyleBackColor = true;
        	this.fetchButton.Click += new System.EventHandler(this.OnFetchButtonClick);
        	// 
        	// gameTextBox
        	// 
        	this.gameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gameTextBox.Location = new System.Drawing.Point(3, 28);
        	this.gameTextBox.Name = "gameTextBox";
        	this.gameTextBox.Size = new System.Drawing.Size(572, 24);
        	this.gameTextBox.TabIndex = 0;
        	this.gameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	// 
        	// tableLayoutPanel3
        	// 
        	this.tableLayoutPanel3.ColumnCount = 2;
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
        	this.tableLayoutPanel3.Controls.Add(this.browseButton, 1, 0);
        	this.tableLayoutPanel3.Controls.Add(this.directoryTextBox, 0, 0);
        	this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 80);
        	this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
        	this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        	this.tableLayoutPanel3.RowCount = 1;
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 24);
        	this.tableLayoutPanel3.TabIndex = 4;
        	// 
        	// browseButton
        	// 
        	this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.browseButton.Location = new System.Drawing.Point(405, 1);
        	this.browseButton.Margin = new System.Windows.Forms.Padding(1);
        	this.browseButton.Name = "browseButton";
        	this.browseButton.Size = new System.Drawing.Size(172, 22);
        	this.browseButton.TabIndex = 2;
        	this.browseButton.Text = "&Browse";
        	this.browseButton.UseVisualStyleBackColor = true;
        	this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
        	// 
        	// directoryTextBox
        	// 
        	this.directoryTextBox.AllowDrop = true;
        	this.directoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryTextBox.Location = new System.Drawing.Point(1, 1);
        	this.directoryTextBox.Margin = new System.Windows.Forms.Padding(1);
        	this.directoryTextBox.Name = "directoryTextBox";
        	this.directoryTextBox.Size = new System.Drawing.Size(402, 20);
        	this.directoryTextBox.TabIndex = 1;
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.fetchButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(584, 462);
        	this.Controls.Add(this.tableLayoutPanel1);
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
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.splitContainer.Panel1.ResumeLayout(false);
        	this.splitContainer.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
        	this.splitContainer.ResumeLayout(false);
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	this.splitContainer1.Panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.gameImagePictureBox)).EndInit();
        	this.tableLayoutPanel2.ResumeLayout(false);
        	this.tableLayoutPanel2.PerformLayout();
        	this.tableLayoutPanel3.ResumeLayout(false);
        	this.tableLayoutPanel3.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.TextBox gameInfoTextBox;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ApiCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ApiToolStripStatusLabel;
        private System.Windows.Forms.PictureBox gameImagePictureBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
