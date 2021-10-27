
namespace BGGfetch
{
	partial class BrowserForm
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
			if (disposing) {
				if (components != null) {
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
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.browserStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// browserStatusStrip
			// 
			this.browserStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.browserToolStripStatusLabel});
			this.browserStatusStrip.Location = new System.Drawing.Point(0, 420);
			this.browserStatusStrip.Name = "browserStatusStrip";
			this.browserStatusStrip.Size = new System.Drawing.Size(624, 22);
			this.browserStatusStrip.TabIndex = 0;
			this.browserStatusStrip.Text = "statusStrip1";
			// 
			// browserToolStripStatusLabel
			// 
			this.browserToolStripStatusLabel.Name = "browserToolStripStatusLabel";
			this.browserToolStripStatusLabel.Size = new System.Drawing.Size(62, 17);
			this.browserToolStripStatusLabel.Text = "Loading ...";
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(624, 420);
			this.webBrowser.TabIndex = 1;
			this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserDocumentCompleted);
			// 
			// BrowserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.browserStatusStrip);
			this.Name = "BrowserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading ...";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowserFormFormClosing);
			this.browserStatusStrip.ResumeLayout(false);
			this.browserStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.ToolStripStatusLabel browserToolStripStatusLabel;
		private System.Windows.Forms.StatusStrip browserStatusStrip;
	}
}
