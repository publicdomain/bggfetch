
namespace BGGfetch
{
    partial class FetchForm
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
        	this.browserStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.browserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.gameDataGridView = new System.Windows.Forms.DataGridView();
        	this.downloadListBox = new System.Windows.Forms.ListBox();
        	this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.browserStatusStrip.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
        	this.tableLayoutPanel.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// browserStatusStrip
        	// 
        	this.browserStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.browserToolStripStatusLabel});
        	this.browserStatusStrip.Location = new System.Drawing.Point(0, 420);
        	this.browserStatusStrip.Name = "browserStatusStrip";
        	this.browserStatusStrip.Size = new System.Drawing.Size(711, 22);
        	this.browserStatusStrip.TabIndex = 3;
        	this.browserStatusStrip.Text = "statusStrip1";
        	// 
        	// browserToolStripStatusLabel
        	// 
        	this.browserToolStripStatusLabel.Name = "browserToolStripStatusLabel";
        	this.browserToolStripStatusLabel.Size = new System.Drawing.Size(149, 17);
        	this.browserToolStripStatusLabel.Text = "Waiting for added games...";
        	// 
        	// gameDataGridView
        	// 
        	this.gameDataGridView.AllowUserToAddRows = false;
        	this.gameDataGridView.AllowUserToDeleteRows = false;
        	this.gameDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        	this.gameDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.gameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.gameDataGridView.Location = new System.Drawing.Point(3, 3);
        	this.gameDataGridView.Name = "gameDataGridView";
        	this.gameDataGridView.ReadOnly = true;
        	this.gameDataGridView.RowHeadersVisible = false;
        	this.gameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.gameDataGridView.Size = new System.Drawing.Size(705, 288);
        	this.gameDataGridView.TabIndex = 0;
        	this.gameDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameDataGridViewCellContentClickAsync);
        	// 
        	// downloadListBox
        	// 
        	this.downloadListBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.downloadListBox.FormattingEnabled = true;
        	this.downloadListBox.Location = new System.Drawing.Point(3, 297);
        	this.downloadListBox.Name = "downloadListBox";
        	this.downloadListBox.Size = new System.Drawing.Size(705, 120);
        	this.downloadListBox.TabIndex = 1;
        	// 
        	// tableLayoutPanel
        	// 
        	this.tableLayoutPanel.ColumnCount = 1;
        	this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel.Controls.Add(this.downloadListBox, 0, 1);
        	this.tableLayoutPanel.Controls.Add(this.gameDataGridView, 0, 0);
        	this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel.Name = "tableLayoutPanel";
        	this.tableLayoutPanel.RowCount = 2;
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
        	this.tableLayoutPanel.Size = new System.Drawing.Size(711, 420);
        	this.tableLayoutPanel.TabIndex = 4;
        	// 
        	// FetchForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(711, 442);
        	this.Controls.Add(this.tableLayoutPanel);
        	this.Controls.Add(this.browserStatusStrip);
        	this.Name = "FetchForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Loading...";
        	this.Load += new System.EventHandler(this.FetchFormLoad);
        	this.Shown += new System.EventHandler(this.FetchFormShown);
        	this.browserStatusStrip.ResumeLayout(false);
        	this.browserStatusStrip.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
        	this.tableLayoutPanel.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListBox downloadListBox;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.ToolStripStatusLabel browserToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip browserStatusStrip;
    }
}
