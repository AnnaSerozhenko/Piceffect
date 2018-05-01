namespace Piceffect
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileMI = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMI = new System.Windows.Forms.ToolStripMenuItem();
			this.EditMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ProcessMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AdminPanelMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AccountMI = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ManualMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMI = new System.Windows.Forms.ToolStripMenuItem();
			this.LogoutMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Tabs = new System.Windows.Forms.TabControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabCorrection = new System.Windows.Forms.TabPage();
			this.CorrectionType = new System.Windows.Forms.ComboBox();
			this.CorrectionTypeLabel = new System.Windows.Forms.Label();
			this.TabGamma = new System.Windows.Forms.TabPage();
			this.TabNoise = new System.Windows.Forms.TabPage();
			this.TabWave = new System.Windows.Forms.TabPage();
			this.TabGlass = new System.Windows.Forms.TabPage();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.TotalProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.Apply = new System.Windows.Forms.Button();
			this.Effect = new System.Windows.Forms.ComboBox();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.ImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Fullsize = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseImage = new System.Windows.Forms.ToolStripMenuItem();
			this.ResetChanges = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveFile = new System.Windows.Forms.SaveFileDialog();
			this.SaveImage = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.TabCorrection.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.ImageMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Font = new System.Drawing.Font("Arial", 9F);
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMI,
            this.EditMI,
            this.ToolsMI,
            this.HelpMI,
            this.LogoutMI});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(634, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// FileMI
			// 
			this.FileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMI});
			this.FileMI.Name = "FileMI";
			this.FileMI.Size = new System.Drawing.Size(39, 20);
			this.FileMI.Text = "File";
			// 
			// OpenMI
			// 
			this.OpenMI.Name = "OpenMI";
			this.OpenMI.Size = new System.Drawing.Size(180, 22);
			this.OpenMI.Text = "&Open";
			this.OpenMI.Click += new System.EventHandler(this.OpenMI_Click);
			// 
			// EditMI
			// 
			this.EditMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMI,
            this.ProcessMI});
			this.EditMI.Name = "EditMI";
			this.EditMI.Size = new System.Drawing.Size(40, 20);
			this.EditMI.Text = "Edit";
			// 
			// ShowMI
			// 
			this.ShowMI.Checked = true;
			this.ShowMI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowMI.Name = "ShowMI";
			this.ShowMI.Size = new System.Drawing.Size(180, 22);
			this.ShowMI.Text = "Show Result";
			this.ShowMI.Click += new System.EventHandler(this.ShowMI_Click);
			// 
			// ProcessMI
			// 
			this.ProcessMI.Checked = true;
			this.ProcessMI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ProcessMI.Name = "ProcessMI";
			this.ProcessMI.Size = new System.Drawing.Size(180, 22);
			this.ProcessMI.Text = "Process All";
			this.ProcessMI.Click += new System.EventHandler(this.ProcessMI_Click);
			// 
			// ToolsMI
			// 
			this.ToolsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMI,
            this.SettingsMI,
            this.AdminPanelMI});
			this.ToolsMI.Name = "ToolsMI";
			this.ToolsMI.Size = new System.Drawing.Size(49, 20);
			this.ToolsMI.Text = "Tools";
			// 
			// AdminPanelMI
			// 
			this.AdminPanelMI.Name = "AdminPanelMI";
			this.AdminPanelMI.Size = new System.Drawing.Size(180, 22);
			this.AdminPanelMI.Text = "Admin Panel";
			this.AdminPanelMI.Click += new System.EventHandler(this.AdminPanelMI_Click);
			// 
			// SettingsMI
			// 
			this.SettingsMI.Name = "SettingsMI";
			this.SettingsMI.Size = new System.Drawing.Size(180, 22);
			this.SettingsMI.Text = "Settings";
			this.SettingsMI.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// AccountMI
			// 
			this.AccountMI.Name = "AccountMI";
			this.AccountMI.Size = new System.Drawing.Size(180, 22);
			this.AccountMI.Text = "Account";
			this.AccountMI.Click += new System.EventHandler(this.AccountMI_Click);
			// 
			// HelpMI
			// 
			this.HelpMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualMI,
            this.AboutMI});
			this.HelpMI.Name = "HelpMI";
			this.HelpMI.Size = new System.Drawing.Size(45, 20);
			this.HelpMI.Text = "Help";
			// 
			// ManualMI
			// 
			this.ManualMI.Name = "ManualMI";
			this.ManualMI.Size = new System.Drawing.Size(180, 22);
			this.ManualMI.Text = "Manual";
			// 
			// AboutMI
			// 
			this.AboutMI.Name = "AboutMI";
			this.AboutMI.Size = new System.Drawing.Size(180, 22);
			this.AboutMI.Text = "About Piceffect";
			// 
			// LogoutMI
			// 
			this.LogoutMI.Name = "LogoutMI";
			this.LogoutMI.Size = new System.Drawing.Size(57, 20);
			this.LogoutMI.Text = "Logout";
			this.LogoutMI.Click += new System.EventHandler(this.LogoutMI_Click);
			// 
			// Tabs
			// 
			this.Tabs.Font = new System.Drawing.Font("Arial", 9F);
			this.Tabs.Location = new System.Drawing.Point(12, 31);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new System.Drawing.Size(360, 200);
			this.Tabs.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabCorrection);
			this.tabControl1.Controls.Add(this.TabGamma);
			this.tabControl1.Controls.Add(this.TabNoise);
			this.tabControl1.Controls.Add(this.TabWave);
			this.tabControl1.Controls.Add(this.TabGlass);
			this.tabControl1.Location = new System.Drawing.Point(378, 31);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(245, 172);
			this.tabControl1.TabIndex = 2;
			// 
			// TabCorrection
			// 
			this.TabCorrection.Controls.Add(this.CorrectionType);
			this.TabCorrection.Controls.Add(this.CorrectionTypeLabel);
			this.TabCorrection.Location = new System.Drawing.Point(4, 22);
			this.TabCorrection.Name = "TabCorrection";
			this.TabCorrection.Padding = new System.Windows.Forms.Padding(4);
			this.TabCorrection.Size = new System.Drawing.Size(237, 146);
			this.TabCorrection.TabIndex = 0;
			this.TabCorrection.Text = "Correction";
			this.TabCorrection.UseVisualStyleBackColor = true;
			// 
			// CorrectionType
			// 
			this.CorrectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CorrectionType.FormattingEnabled = true;
			this.CorrectionType.Items.AddRange(new object[] {
            "Linear",
            "Nonlinear"});
			this.CorrectionType.Location = new System.Drawing.Point(47, 7);
			this.CorrectionType.Name = "CorrectionType";
			this.CorrectionType.Size = new System.Drawing.Size(183, 21);
			this.CorrectionType.TabIndex = 1;
			// 
			// CorrectionTypeLabel
			// 
			this.CorrectionTypeLabel.AutoSize = true;
			this.CorrectionTypeLabel.Location = new System.Drawing.Point(7, 10);
			this.CorrectionTypeLabel.Name = "CorrectionTypeLabel";
			this.CorrectionTypeLabel.Size = new System.Drawing.Size(34, 13);
			this.CorrectionTypeLabel.TabIndex = 0;
			this.CorrectionTypeLabel.Text = "Type:";
			// 
			// TabGamma
			// 
			this.TabGamma.Location = new System.Drawing.Point(4, 22);
			this.TabGamma.Name = "TabGamma";
			this.TabGamma.Padding = new System.Windows.Forms.Padding(4);
			this.TabGamma.Size = new System.Drawing.Size(237, 146);
			this.TabGamma.TabIndex = 1;
			this.TabGamma.Text = "Gamma";
			this.TabGamma.UseVisualStyleBackColor = true;
			// 
			// TabNoise
			// 
			this.TabNoise.Location = new System.Drawing.Point(4, 22);
			this.TabNoise.Name = "TabNoise";
			this.TabNoise.Padding = new System.Windows.Forms.Padding(4);
			this.TabNoise.Size = new System.Drawing.Size(237, 146);
			this.TabNoise.TabIndex = 2;
			this.TabNoise.Text = "Noise";
			this.TabNoise.UseVisualStyleBackColor = true;
			// 
			// TabWave
			// 
			this.TabWave.Location = new System.Drawing.Point(4, 22);
			this.TabWave.Name = "TabWave";
			this.TabWave.Padding = new System.Windows.Forms.Padding(4);
			this.TabWave.Size = new System.Drawing.Size(237, 146);
			this.TabWave.TabIndex = 3;
			this.TabWave.Text = "Wave";
			this.TabWave.UseVisualStyleBackColor = true;
			// 
			// TabGlass
			// 
			this.TabGlass.Location = new System.Drawing.Point(4, 22);
			this.TabGlass.Name = "TabGlass";
			this.TabGlass.Padding = new System.Windows.Forms.Padding(4);
			this.TabGlass.Size = new System.Drawing.Size(237, 146);
			this.TabGlass.TabIndex = 4;
			this.TabGlass.Text = "Glass";
			this.TabGlass.UseVisualStyleBackColor = true;
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalProgress});
			this.StatusBar.Location = new System.Drawing.Point(0, 239);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(634, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 3;
			this.StatusBar.Text = "statusStrip1";
			// 
			// TotalProgress
			// 
			this.TotalProgress.Name = "TotalProgress";
			this.TotalProgress.Size = new System.Drawing.Size(100, 16);
			// 
			// Apply
			// 
			this.Apply.Location = new System.Drawing.Point(543, 208);
			this.Apply.Name = "Apply";
			this.Apply.Size = new System.Drawing.Size(80, 23);
			this.Apply.TabIndex = 4;
			this.Apply.Text = "Apply";
			this.Apply.UseVisualStyleBackColor = true;
			this.Apply.Click += new System.EventHandler(this.Apply_Click);
			// 
			// Effect
			// 
			this.Effect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Effect.FormattingEnabled = true;
			this.Effect.Items.AddRange(new object[] {
            "Correction",
            "Gamma",
            "Noise",
            "Wave",
            "Glass"});
			this.Effect.Location = new System.Drawing.Point(378, 209);
			this.Effect.Name = "Effect";
			this.Effect.Size = new System.Drawing.Size(159, 21);
			this.Effect.TabIndex = 2;
			// 
			// OpenFile
			// 
			this.OpenFile.Filter = "Images|*.bmp;*.jpg;*.jpeg";
			// 
			// ImageMenu
			// 
			this.ImageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveImage,
            this.ResetChanges,
            this.Fullsize,
            this.CloseImage});
			this.ImageMenu.Name = "ImageMenu";
			this.ImageMenu.Size = new System.Drawing.Size(152, 92);
			// 
			// Fullsize
			// 
			this.Fullsize.Name = "Fullsize";
			this.Fullsize.Size = new System.Drawing.Size(151, 22);
			this.Fullsize.Text = "Open Fullsize";
			this.Fullsize.Click += new System.EventHandler(this.Fullsize_Click);
			// 
			// CloseImage
			// 
			this.CloseImage.Name = "CloseImage";
			this.CloseImage.Size = new System.Drawing.Size(151, 22);
			this.CloseImage.Text = "Close Image";
			this.CloseImage.Click += new System.EventHandler(this.CloseImage_Click);
			// 
			// ResetChanges
			// 
			this.ResetChanges.Name = "ResetChanges";
			this.ResetChanges.Size = new System.Drawing.Size(151, 22);
			this.ResetChanges.Text = "Reset Changes";
			this.ResetChanges.Click += new System.EventHandler(this.ResetChanges_Click);
			// 
			// SaveFile
			// 
			this.SaveFile.FileName = "Result.bmp";
			this.SaveFile.Filter = "Images|*.bmp;*.jpg;*.jpeg";
			// 
			// SaveImage
			// 
			this.SaveImage.Name = "SaveImage";
			this.SaveImage.Size = new System.Drawing.Size(151, 22);
			this.SaveImage.Text = "Save Image";
			this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 261);
			this.Controls.Add(this.Effect);
			this.Controls.Add(this.Apply);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Tabs);
			this.Controls.Add(this.MainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MainMenuStrip = this.MainMenu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Piceffect";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.TabCorrection.ResumeLayout(false);
			this.TabCorrection.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.ImageMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem FileMI;
		private System.Windows.Forms.ToolStripMenuItem HelpMI;
		private System.Windows.Forms.ToolStripMenuItem ManualMI;
		private System.Windows.Forms.ToolStripMenuItem AboutMI;
		private System.Windows.Forms.ToolStripMenuItem OpenMI;
		private System.Windows.Forms.ToolStripMenuItem ToolsMI;
		private System.Windows.Forms.ToolStripMenuItem AdminPanelMI;
		private System.Windows.Forms.ToolStripMenuItem SettingsMI;
		private System.Windows.Forms.ToolStripMenuItem LogoutMI;
		private System.Windows.Forms.TabControl Tabs;
		private System.Windows.Forms.ToolStripMenuItem EditMI;
		private System.Windows.Forms.ToolStripMenuItem ShowMI;
		private System.Windows.Forms.ToolStripMenuItem ProcessMI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCorrection;
        private System.Windows.Forms.TabPage TabGamma;
        private System.Windows.Forms.TabPage TabNoise;
        private System.Windows.Forms.TabPage TabWave;
        private System.Windows.Forms.TabPage TabGlass;
        private System.Windows.Forms.Label CorrectionTypeLabel;
        private System.Windows.Forms.ComboBox CorrectionType;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripProgressBar TotalProgress;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.ComboBox Effect;
		private System.Windows.Forms.ToolStripMenuItem AccountMI;
		private System.Windows.Forms.OpenFileDialog OpenFile;
		private System.Windows.Forms.ContextMenuStrip ImageMenu;
		private System.Windows.Forms.ToolStripMenuItem Fullsize;
		private System.Windows.Forms.ToolStripMenuItem CloseImage;
		private System.Windows.Forms.ToolStripMenuItem ResetChanges;
		private System.Windows.Forms.SaveFileDialog SaveFile;
		private System.Windows.Forms.ToolStripMenuItem SaveImage;
	}
}