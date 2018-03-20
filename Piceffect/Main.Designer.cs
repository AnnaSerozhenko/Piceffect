namespace Piceffect
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPanelMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TP0 = new System.Windows.Forms.TabPage();
            this.P0 = new System.Windows.Forms.Panel();
            this.PB0 = new System.Windows.Forms.PictureBox();
            this.TP1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCorrection = new System.Windows.Forms.TabPage();
            this.TabGamma = new System.Windows.Forms.TabPage();
            this.TabNoise = new System.Windows.Forms.TabPage();
            this.TabWave = new System.Windows.Forms.TabPage();
            this.TabGlass = new System.Windows.Forms.TabPage();
            this.CorrectionTypeLabel = new System.Windows.Forms.Label();
            this.CorrectionType = new System.Windows.Forms.ComboBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.TotalProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ApplyCorrection = new System.Windows.Forms.Button();
            this.Effect = new System.Windows.Forms.ComboBox();
            this.MainMenu.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.TP0.SuspendLayout();
            this.P0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB0)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabCorrection.SuspendLayout();
            this.StatusBar.SuspendLayout();
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
            this.OpenMI,
            this.SaveMI});
            this.FileMI.Name = "FileMI";
            this.FileMI.Size = new System.Drawing.Size(39, 20);
            this.FileMI.Text = "File";
            // 
            // OpenMI
            // 
            this.OpenMI.Name = "OpenMI";
            this.OpenMI.Size = new System.Drawing.Size(152, 22);
            this.OpenMI.Text = "&Open";
            this.OpenMI.Click += new System.EventHandler(this.OpenMI_Click);
            // 
            // SaveMI
            // 
            this.SaveMI.Name = "SaveMI";
            this.SaveMI.Size = new System.Drawing.Size(152, 22);
            this.SaveMI.Text = "&Save";
            this.SaveMI.Click += new System.EventHandler(this.SaveMI_Click);
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
            this.ShowMI.Size = new System.Drawing.Size(152, 22);
            this.ShowMI.Text = "Show Result";
            // 
            // ProcessMI
            // 
            this.ProcessMI.Checked = true;
            this.ProcessMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProcessMI.Name = "ProcessMI";
            this.ProcessMI.Size = new System.Drawing.Size(152, 22);
            this.ProcessMI.Text = "Process All";
            // 
            // ToolsMI
            // 
            this.ToolsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminPanelMI,
            this.SettingsMI});
            this.ToolsMI.Name = "ToolsMI";
            this.ToolsMI.Size = new System.Drawing.Size(49, 20);
            this.ToolsMI.Text = "Tools";
            // 
            // AdminPanelMI
            // 
            this.AdminPanelMI.Name = "AdminPanelMI";
            this.AdminPanelMI.Size = new System.Drawing.Size(152, 22);
            this.AdminPanelMI.Text = "Admin Panel";
            this.AdminPanelMI.Click += new System.EventHandler(this.AdminPanelMI_Click);
            // 
            // SettingsMI
            // 
            this.SettingsMI.Name = "SettingsMI";
            this.SettingsMI.Size = new System.Drawing.Size(152, 22);
            this.SettingsMI.Text = "Settings";
            this.SettingsMI.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            this.ManualMI.Size = new System.Drawing.Size(154, 22);
            this.ManualMI.Text = "Manual";
            // 
            // AboutMI
            // 
            this.AboutMI.Name = "AboutMI";
            this.AboutMI.Size = new System.Drawing.Size(154, 22);
            this.AboutMI.Text = "About Piceffect";
            // 
            // LogoutMI
            // 
            this.LogoutMI.Name = "LogoutMI";
            this.LogoutMI.Size = new System.Drawing.Size(57, 20);
            this.LogoutMI.Text = "Logout";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TP0);
            this.Tabs.Controls.Add(this.TP1);
            this.Tabs.Font = new System.Drawing.Font("Arial", 9F);
            this.Tabs.Location = new System.Drawing.Point(12, 31);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(360, 200);
            this.Tabs.TabIndex = 1;
            // 
            // TP0
            // 
            this.TP0.Controls.Add(this.P0);
            this.TP0.Location = new System.Drawing.Point(4, 24);
            this.TP0.Name = "TP0";
            this.TP0.Padding = new System.Windows.Forms.Padding(3);
            this.TP0.Size = new System.Drawing.Size(352, 172);
            this.TP0.TabIndex = 0;
            this.TP0.Text = "Image.bmp";
            this.TP0.UseVisualStyleBackColor = true;
            // 
            // P0
            // 
            this.P0.AutoScroll = true;
            this.P0.Controls.Add(this.PB0);
            this.P0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P0.Location = new System.Drawing.Point(3, 3);
            this.P0.Name = "P0";
            this.P0.Size = new System.Drawing.Size(346, 166);
            this.P0.TabIndex = 0;
            // 
            // PB0
            // 
            this.PB0.BackColor = System.Drawing.Color.Transparent;
            this.PB0.Image = ((System.Drawing.Image)(resources.GetObject("PB0.Image")));
            this.PB0.Location = new System.Drawing.Point(0, 0);
            this.PB0.Name = "PB0";
            this.PB0.Size = new System.Drawing.Size(2560, 1600);
            this.PB0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB0.TabIndex = 6;
            this.PB0.TabStop = false;
            // 
            // TP1
            // 
            this.TP1.Location = new System.Drawing.Point(4, 24);
            this.TP1.Name = "TP1";
            this.TP1.Padding = new System.Windows.Forms.Padding(3);
            this.TP1.Size = new System.Drawing.Size(392, 172);
            this.TP1.TabIndex = 1;
            this.TP1.Text = "Picture.jpg";
            this.TP1.UseVisualStyleBackColor = true;
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
            // TabGamma
            // 
            this.TabGamma.Location = new System.Drawing.Point(4, 22);
            this.TabGamma.Name = "TabGamma";
            this.TabGamma.Padding = new System.Windows.Forms.Padding(4);
            this.TabGamma.Size = new System.Drawing.Size(237, 174);
            this.TabGamma.TabIndex = 1;
            this.TabGamma.Text = "Gamma";
            this.TabGamma.UseVisualStyleBackColor = true;
            // 
            // TabNoise
            // 
            this.TabNoise.Location = new System.Drawing.Point(4, 22);
            this.TabNoise.Name = "TabNoise";
            this.TabNoise.Padding = new System.Windows.Forms.Padding(4);
            this.TabNoise.Size = new System.Drawing.Size(237, 174);
            this.TabNoise.TabIndex = 2;
            this.TabNoise.Text = "Noise";
            this.TabNoise.UseVisualStyleBackColor = true;
            // 
            // TabWave
            // 
            this.TabWave.Location = new System.Drawing.Point(4, 22);
            this.TabWave.Name = "TabWave";
            this.TabWave.Padding = new System.Windows.Forms.Padding(4);
            this.TabWave.Size = new System.Drawing.Size(237, 174);
            this.TabWave.TabIndex = 3;
            this.TabWave.Text = "Wave";
            this.TabWave.UseVisualStyleBackColor = true;
            // 
            // TabGlass
            // 
            this.TabGlass.Location = new System.Drawing.Point(4, 22);
            this.TabGlass.Name = "TabGlass";
            this.TabGlass.Padding = new System.Windows.Forms.Padding(4);
            this.TabGlass.Size = new System.Drawing.Size(237, 174);
            this.TabGlass.TabIndex = 4;
            this.TabGlass.Text = "Glass";
            this.TabGlass.UseVisualStyleBackColor = true;
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
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.TotalProgress});
            this.StatusBar.Location = new System.Drawing.Point(0, 239);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(634, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // TotalProgress
            // 
            this.TotalProgress.Name = "TotalProgress";
            this.TotalProgress.Size = new System.Drawing.Size(100, 16);
            this.TotalProgress.Value = 75;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.StatusLabel.Size = new System.Drawing.Size(81, 17);
            this.StatusLabel.Text = "Processing...";
            // 
            // ApplyCorrection
            // 
            this.ApplyCorrection.Location = new System.Drawing.Point(543, 208);
            this.ApplyCorrection.Name = "ApplyCorrection";
            this.ApplyCorrection.Size = new System.Drawing.Size(80, 23);
            this.ApplyCorrection.TabIndex = 4;
            this.ApplyCorrection.Text = "Apply";
            this.ApplyCorrection.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.Effect);
            this.Controls.Add(this.ApplyCorrection);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piceffect";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.TP0.ResumeLayout(false);
            this.P0.ResumeLayout(false);
            this.P0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB0)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabCorrection.ResumeLayout(false);
            this.TabCorrection.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem SaveMI;
		private System.Windows.Forms.ToolStripMenuItem LogoutMI;
		private System.Windows.Forms.TabControl Tabs;
		private System.Windows.Forms.TabPage TP0;
		private System.Windows.Forms.TabPage TP1;
		private System.Windows.Forms.ToolStripMenuItem EditMI;
		private System.Windows.Forms.ToolStripMenuItem ShowMI;
		private System.Windows.Forms.Panel P0;
		private System.Windows.Forms.ToolStripMenuItem ProcessMI;
		private System.Windows.Forms.PictureBox PB0;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCorrection;
        private System.Windows.Forms.TabPage TabGamma;
        private System.Windows.Forms.TabPage TabNoise;
        private System.Windows.Forms.TabPage TabWave;
        private System.Windows.Forms.TabPage TabGlass;
        private System.Windows.Forms.Label CorrectionTypeLabel;
        private System.Windows.Forms.ComboBox CorrectionType;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar TotalProgress;
        private System.Windows.Forms.Button ApplyCorrection;
        private System.Windows.Forms.ComboBox Effect;
    }
}