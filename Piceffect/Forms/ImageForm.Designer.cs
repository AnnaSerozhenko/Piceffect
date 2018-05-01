namespace Piceffect
{
	partial class ImageForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.PanelBox = new System.Windows.Forms.Panel();
			this.Picture = new System.Windows.Forms.PictureBox();
			this.View = new System.Windows.Forms.ToolStripMenuItem();
			this.RealSize = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.PanelBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(394, 24);
			this.MainMenu.TabIndex = 3;
			this.MainMenu.Text = "menuStrip1";
			// 
			// PanelBox
			// 
			this.PanelBox.AutoScroll = true;
			this.PanelBox.Controls.Add(this.Picture);
			this.PanelBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelBox.Location = new System.Drawing.Point(0, 24);
			this.PanelBox.Name = "PanelBox";
			this.PanelBox.Size = new System.Drawing.Size(394, 227);
			this.PanelBox.TabIndex = 4;
			// 
			// Picture
			// 
			this.Picture.Location = new System.Drawing.Point(0, 0);
			this.Picture.Name = "Picture";
			this.Picture.Size = new System.Drawing.Size(100, 50);
			this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Picture.TabIndex = 1;
			this.Picture.TabStop = false;
			// 
			// View
			// 
			this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RealSize});
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(44, 20);
			this.View.Text = "View";
			// 
			// RealSize
			// 
			this.RealSize.Name = "RealSize";
			this.RealSize.Size = new System.Drawing.Size(180, 22);
			this.RealSize.Text = "Real Size";
			this.RealSize.Click += new System.EventHandler(this.RealSize_Click);
			// 
			// ImageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 251);
			this.Controls.Add(this.PanelBox);
			this.Controls.Add(this.MainMenu);
			this.Name = "ImageForm";
			this.Text = "Piceffect";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ImageForm_Load);
			this.Resize += new System.EventHandler(this.ImageForm_Resize);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.PanelBox.ResumeLayout(false);
			this.PanelBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem View;
		private System.Windows.Forms.ToolStripMenuItem RealSize;
		private System.Windows.Forms.Panel PanelBox;
		private System.Windows.Forms.PictureBox Picture;
	}
}