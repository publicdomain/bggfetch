
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
        	this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aPIDelayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.fetchButton = new System.Windows.Forms.Button();
        	this.browseButton = new System.Windows.Forms.Button();
        	this.directoryLabel = new System.Windows.Forms.Label();
        	this.rawLabel = new System.Windows.Forms.Label();
        	this.directoryTextBox = new System.Windows.Forms.TextBox();
        	this.gamesLabel = new System.Windows.Forms.Label();
        	this.gameTextBox = new System.Windows.Forms.TextBox();
        	this.gameSearchListBox = new System.Windows.Forms.ListBox();
        	this.rawTabControl = new System.Windows.Forms.TabControl();
        	this.searchXmlTabPage = new System.Windows.Forms.TabPage();
        	this.searcXmlhTextBox = new System.Windows.Forms.TextBox();
        	this.gameXmlTabPage = new System.Windows.Forms.TabPage();
        	this.gameXmlTextBox = new System.Windows.Forms.TextBox();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.rawRadioButton = new System.Windows.Forms.RadioButton();
        	this.yearRadioButton = new System.Windows.Forms.RadioButton();
        	this.nameRadioButton = new System.Windows.Forms.RadioButton();
        	this.idRadioButton = new System.Windows.Forms.RadioButton();
        	this.descCheckBox = new System.Windows.Forms.CheckBox();
        	this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        	this.gameInfoRichTextBox = new System.Windows.Forms.RichTextBox();
        	this.gameImagePictureBox = new System.Windows.Forms.PictureBox();
        	this.gameInfoLabel = new System.Windows.Forms.Label();
        	this.gameImageLabel = new System.Windows.Forms.Label();
        	this.mainTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.tabControl1.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.rawTabControl.SuspendLayout();
        	this.searchXmlTabPage.SuspendLayout();
        	this.gameXmlTabPage.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.tableLayoutPanel3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameImagePictureBox)).BeginInit();
        	this.mainTableLayoutPanel2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.minimizeToolStripMenuItem,
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.toolsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(764, 24);
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
        	// toolsToolStripMenuItem
        	// 
        	this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.settingsToolStripMenuItem,
        	        	        	this.optionsToolStripMenuItem});
        	this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        	this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
        	this.toolsToolStripMenuItem.Text = "&Tools";
        	// 
        	// settingsToolStripMenuItem
        	// 
        	this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.aPIDelayToolStripMenuItem});
        	this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
        	this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.settingsToolStripMenuItem.Text = "&Settings";
        	// 
        	// aPIDelayToolStripMenuItem
        	// 
        	this.aPIDelayToolStripMenuItem.Name = "aPIDelayToolStripMenuItem";
        	this.aPIDelayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.aPIDelayToolStripMenuItem.Text = "&API Delay";
        	this.aPIDelayToolStripMenuItem.Click += new System.EventHandler(this.OnAPIDelayToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 494);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(764, 22);
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
        	this.resultToolStripStatusLabel.Size = new System.Drawing.Size(193, 17);
        	this.resultToolStripStatusLabel.Text = "Waiting for a search term to fetch...";
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
        	// tabControl1
        	// 
        	this.tabControl1.Controls.Add(this.tabPage1);
        	this.tabControl1.Controls.Add(this.tabPage2);
        	this.tabControl1.Location = new System.Drawing.Point(0, 0);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(200, 100);
        	this.tabControl1.TabIndex = 0;
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Location = new System.Drawing.Point(4, 22);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage1.Size = new System.Drawing.Size(192, 74);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "tabPage1";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Location = new System.Drawing.Point(4, 22);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage2.Size = new System.Drawing.Size(192, 74);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "tabPage2";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 2;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.mainTableLayoutPanel.Controls.Add(this.fetchButton, 0, 4);
        	this.mainTableLayoutPanel.Controls.Add(this.browseButton, 1, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.directoryLabel, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.rawLabel, 0, 7);
        	this.mainTableLayoutPanel.Controls.Add(this.directoryTextBox, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.gamesLabel, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.gameTextBox, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.gameSearchListBox, 0, 5);
        	this.mainTableLayoutPanel.Controls.Add(this.rawTabControl, 0, 8);
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 6);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 9;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(376, 464);
        	this.mainTableLayoutPanel.TabIndex = 45;
        	// 
        	// fetchButton
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.fetchButton, 2);
        	this.fetchButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fetchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.fetchButton.Location = new System.Drawing.Point(3, 103);
        	this.fetchButton.Name = "fetchButton";
        	this.fetchButton.Size = new System.Drawing.Size(370, 44);
        	this.fetchButton.TabIndex = 5;
        	this.fetchButton.Text = "&FETCH INFO";
        	this.fetchButton.UseVisualStyleBackColor = true;
        	this.fetchButton.Click += new System.EventHandler(this.OnFetchButtonClick);
        	// 
        	// browseButton
        	// 
        	this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.browseButton.Location = new System.Drawing.Point(301, 76);
        	this.browseButton.Margin = new System.Windows.Forms.Padding(1);
        	this.browseButton.Name = "browseButton";
        	this.browseButton.Size = new System.Drawing.Size(74, 23);
        	this.browseButton.TabIndex = 4;
        	this.browseButton.Text = "&Browse";
        	this.browseButton.UseVisualStyleBackColor = true;
        	this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
        	// 
        	// directoryLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.directoryLabel, 2);
        	this.directoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.directoryLabel.Location = new System.Drawing.Point(3, 50);
        	this.directoryLabel.Name = "directoryLabel";
        	this.directoryLabel.Size = new System.Drawing.Size(370, 25);
        	this.directoryLabel.TabIndex = 2;
        	this.directoryLabel.Text = "&Directory:";
        	this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// rawLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.rawLabel, 2);
        	this.rawLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.rawLabel.Location = new System.Drawing.Point(3, 336);
        	this.rawLabel.Name = "rawLabel";
        	this.rawLabel.Size = new System.Drawing.Size(370, 20);
        	this.rawLabel.TabIndex = 7;
        	this.rawLabel.Text = "&Raw:";
        	this.rawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// directoryTextBox
        	// 
        	this.directoryTextBox.AllowDrop = true;
        	this.directoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryTextBox.Location = new System.Drawing.Point(1, 76);
        	this.directoryTextBox.Margin = new System.Windows.Forms.Padding(1);
        	this.directoryTextBox.Name = "directoryTextBox";
        	this.directoryTextBox.Size = new System.Drawing.Size(298, 20);
        	this.directoryTextBox.TabIndex = 3;
        	this.directoryTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDirectoryTextBoxDragDrop);
        	this.directoryTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDirectoryTextBoxDragEnter);
        	// 
        	// gamesLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.gamesLabel, 2);
        	this.gamesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gamesLabel.Location = new System.Drawing.Point(3, 0);
        	this.gamesLabel.Name = "gamesLabel";
        	this.gamesLabel.Size = new System.Drawing.Size(370, 25);
        	this.gamesLabel.TabIndex = 0;
        	this.gamesLabel.Text = "&Search:";
        	this.gamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// gameTextBox
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.gameTextBox, 2);
        	this.gameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gameTextBox.Location = new System.Drawing.Point(3, 28);
        	this.gameTextBox.Name = "gameTextBox";
        	this.gameTextBox.Size = new System.Drawing.Size(370, 24);
        	this.gameTextBox.TabIndex = 1;
        	// 
        	// gameSearchListBox
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.gameSearchListBox, 2);
        	this.gameSearchListBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameSearchListBox.Location = new System.Drawing.Point(3, 153);
        	this.gameSearchListBox.Name = "gameSearchListBox";
        	this.gameSearchListBox.Size = new System.Drawing.Size(370, 155);
        	this.gameSearchListBox.TabIndex = 6;
        	this.gameSearchListBox.SelectedIndexChanged += new System.EventHandler(this.OnGameSearchListBoxSelectedIndexChanged);
        	// 
        	// rawTabControl
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.rawTabControl, 2);
        	this.rawTabControl.Controls.Add(this.searchXmlTabPage);
        	this.rawTabControl.Controls.Add(this.gameXmlTabPage);
        	this.rawTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rawTabControl.Location = new System.Drawing.Point(3, 359);
        	this.rawTabControl.Name = "rawTabControl";
        	this.rawTabControl.SelectedIndex = 0;
        	this.rawTabControl.Size = new System.Drawing.Size(370, 102);
        	this.rawTabControl.TabIndex = 8;
        	// 
        	// searchXmlTabPage
        	// 
        	this.searchXmlTabPage.Controls.Add(this.searcXmlhTextBox);
        	this.searchXmlTabPage.Location = new System.Drawing.Point(4, 22);
        	this.searchXmlTabPage.Name = "searchXmlTabPage";
        	this.searchXmlTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.searchXmlTabPage.Size = new System.Drawing.Size(362, 76);
        	this.searchXmlTabPage.TabIndex = 0;
        	this.searchXmlTabPage.Text = "Search XML";
        	this.searchXmlTabPage.UseVisualStyleBackColor = true;
        	// 
        	// searcXmlhTextBox
        	// 
        	this.searcXmlhTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.searcXmlhTextBox.Location = new System.Drawing.Point(3, 3);
        	this.searcXmlhTextBox.Multiline = true;
        	this.searcXmlhTextBox.Name = "searcXmlhTextBox";
        	this.searcXmlhTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.searcXmlhTextBox.Size = new System.Drawing.Size(356, 70);
        	this.searcXmlhTextBox.TabIndex = 0;
        	this.searcXmlhTextBox.WordWrap = false;
        	// 
        	// gameXmlTabPage
        	// 
        	this.gameXmlTabPage.Controls.Add(this.gameXmlTextBox);
        	this.gameXmlTabPage.Location = new System.Drawing.Point(4, 22);
        	this.gameXmlTabPage.Name = "gameXmlTabPage";
        	this.gameXmlTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.gameXmlTabPage.Size = new System.Drawing.Size(362, 76);
        	this.gameXmlTabPage.TabIndex = 1;
        	this.gameXmlTabPage.Text = "Game XML";
        	this.gameXmlTabPage.UseVisualStyleBackColor = true;
        	// 
        	// gameXmlTextBox
        	// 
        	this.gameXmlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameXmlTextBox.Location = new System.Drawing.Point(3, 3);
        	this.gameXmlTextBox.Multiline = true;
        	this.gameXmlTextBox.Name = "gameXmlTextBox";
        	this.gameXmlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.gameXmlTextBox.Size = new System.Drawing.Size(356, 70);
        	this.gameXmlTextBox.TabIndex = 3;
        	this.gameXmlTextBox.WordWrap = false;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 5;
        	this.mainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        	this.tableLayoutPanel1.Controls.Add(this.rawRadioButton, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.yearRadioButton, 1, 0);
        	this.tableLayoutPanel1.Controls.Add(this.nameRadioButton, 2, 0);
        	this.tableLayoutPanel1.Controls.Add(this.idRadioButton, 3, 0);
        	this.tableLayoutPanel1.Controls.Add(this.descCheckBox, 4, 0);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 311);
        	this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 1;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 25);
        	this.tableLayoutPanel1.TabIndex = 9;
        	// 
        	// rawRadioButton
        	// 
        	this.rawRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rawRadioButton.Location = new System.Drawing.Point(3, 3);
        	this.rawRadioButton.Name = "rawRadioButton";
        	this.rawRadioButton.Size = new System.Drawing.Size(69, 19);
        	this.rawRadioButton.TabIndex = 1;
        	this.rawRadioButton.TabStop = true;
        	this.rawRadioButton.Text = "&Raw";
        	this.rawRadioButton.UseVisualStyleBackColor = true;
        	this.rawRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// yearRadioButton
        	// 
        	this.yearRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.yearRadioButton.Location = new System.Drawing.Point(78, 3);
        	this.yearRadioButton.Name = "yearRadioButton";
        	this.yearRadioButton.Size = new System.Drawing.Size(69, 19);
        	this.yearRadioButton.TabIndex = 2;
        	this.yearRadioButton.Text = "&Year";
        	this.yearRadioButton.UseVisualStyleBackColor = true;
        	this.yearRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// nameRadioButton
        	// 
        	this.nameRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.nameRadioButton.Location = new System.Drawing.Point(153, 3);
        	this.nameRadioButton.Name = "nameRadioButton";
        	this.nameRadioButton.Size = new System.Drawing.Size(69, 19);
        	this.nameRadioButton.TabIndex = 3;
        	this.nameRadioButton.Text = "&Name";
        	this.nameRadioButton.UseVisualStyleBackColor = true;
        	this.nameRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// idRadioButton
        	// 
        	this.idRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.idRadioButton.Location = new System.Drawing.Point(228, 3);
        	this.idRadioButton.Name = "idRadioButton";
        	this.idRadioButton.Size = new System.Drawing.Size(69, 19);
        	this.idRadioButton.TabIndex = 4;
        	this.idRadioButton.TabStop = true;
        	this.idRadioButton.Text = "&ID";
        	this.idRadioButton.UseVisualStyleBackColor = true;
        	this.idRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// descCheckBox
        	// 
        	this.descCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.descCheckBox.Location = new System.Drawing.Point(303, 3);
        	this.descCheckBox.Name = "descCheckBox";
        	this.descCheckBox.Size = new System.Drawing.Size(70, 19);
        	this.descCheckBox.TabIndex = 5;
        	this.descCheckBox.Text = "&DESC";
        	this.descCheckBox.UseVisualStyleBackColor = true;
        	this.descCheckBox.CheckedChanged += new System.EventHandler(this.OnDescCheckBoxCheckedChanged);
        	// 
        	// tableLayoutPanel3
        	// 
        	this.tableLayoutPanel3.ColumnCount = 1;
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel3.Controls.Add(this.gameInfoRichTextBox, 0, 1);
        	this.tableLayoutPanel3.Controls.Add(this.gameImagePictureBox, 0, 3);
        	this.tableLayoutPanel3.Controls.Add(this.gameInfoLabel, 0, 0);
        	this.tableLayoutPanel3.Controls.Add(this.gameImageLabel, 0, 2);
        	this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel3.Location = new System.Drawing.Point(385, 3);
        	this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        	this.tableLayoutPanel3.RowCount = 4;
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 464);
        	this.tableLayoutPanel3.TabIndex = 2;
        	// 
        	// gameInfoRichTextBox
        	// 
        	this.gameInfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameInfoRichTextBox.Location = new System.Drawing.Point(3, 28);
        	this.gameInfoRichTextBox.Name = "gameInfoRichTextBox";
        	this.gameInfoRichTextBox.Size = new System.Drawing.Size(370, 201);
        	this.gameInfoRichTextBox.TabIndex = 10;
        	this.gameInfoRichTextBox.Text = "";
        	// 
        	// gameImagePictureBox
        	// 
        	this.gameImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameImagePictureBox.Location = new System.Drawing.Point(3, 260);
        	this.gameImagePictureBox.Name = "gameImagePictureBox";
        	this.gameImagePictureBox.Size = new System.Drawing.Size(370, 201);
        	this.gameImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.gameImagePictureBox.TabIndex = 6;
        	this.gameImagePictureBox.TabStop = false;
        	this.gameImagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnGameImagePictureBoxMouseMove);
        	// 
        	// gameInfoLabel
        	// 
        	this.gameInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.gameInfoLabel.Location = new System.Drawing.Point(3, 0);
        	this.gameInfoLabel.Name = "gameInfoLabel";
        	this.gameInfoLabel.Size = new System.Drawing.Size(370, 25);
        	this.gameInfoLabel.TabIndex = 9;
        	this.gameInfoLabel.Text = "&Game info:";
        	this.gameInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// gameImageLabel
        	// 
        	this.gameImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.gameImageLabel.Location = new System.Drawing.Point(3, 232);
        	this.gameImageLabel.Name = "gameImageLabel";
        	this.gameImageLabel.Size = new System.Drawing.Size(370, 25);
        	this.gameImageLabel.TabIndex = 11;
        	this.gameImageLabel.Text = "&Game image:";
        	this.gameImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// mainTableLayoutPanel2
        	// 
        	this.mainTableLayoutPanel2.ColumnCount = 2;
        	this.mainTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.mainTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.mainTableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
        	this.mainTableLayoutPanel2.Controls.Add(this.mainTableLayoutPanel, 0, 0);
        	this.mainTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel2.Name = "mainTableLayoutPanel2";
        	this.mainTableLayoutPanel2.RowCount = 1;
        	this.mainTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.mainTableLayoutPanel2.Size = new System.Drawing.Size(764, 470);
        	this.mainTableLayoutPanel2.TabIndex = 46;
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.fetchButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(764, 516);
        	this.Controls.Add(this.mainTableLayoutPanel2);
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
        	this.tabControl1.ResumeLayout(false);
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.mainTableLayoutPanel.PerformLayout();
        	this.rawTabControl.ResumeLayout(false);
        	this.searchXmlTabPage.ResumeLayout(false);
        	this.searchXmlTabPage.PerformLayout();
        	this.gameXmlTabPage.ResumeLayout(false);
        	this.gameXmlTabPage.PerformLayout();
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel3.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.gameImagePictureBox)).EndInit();
        	this.mainTableLayoutPanel2.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem aPIDelayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.RadioButton rawRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage gameXmlTabPage;
        private System.Windows.Forms.TabPage searchXmlTabPage;
        private System.Windows.Forms.TabControl rawTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label gameImageLabel;
        private System.Windows.Forms.Label gameInfoLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel2;
        private System.Windows.Forms.ListBox gameSearchListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label rawLabel;
        private System.Windows.Forms.TextBox gameXmlTextBox;
        private System.Windows.Forms.TextBox searcXmlhTextBox;
        private System.Windows.Forms.RichTextBox gameInfoRichTextBox;
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
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
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
