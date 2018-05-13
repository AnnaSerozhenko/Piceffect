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
			this.ResetAllMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AccountMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AdminPanelMI = new System.Windows.Forms.ToolStripMenuItem();
			this.EffectsMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ExportMI = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ManualMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMI = new System.Windows.Forms.ToolStripMenuItem();
			this.LogoutMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Tabs = new System.Windows.Forms.TabControl();
			this.Parameters = new System.Windows.Forms.TabControl();
			this.TabCorrection = new System.Windows.Forms.TabPage();
			this.CoefficientValue = new System.Windows.Forms.Label();
			this.CoefficientBox = new System.Windows.Forms.TrackBar();
			this.CoefficientLabel = new System.Windows.Forms.Label();
			this.CorrectionType = new System.Windows.Forms.ComboBox();
			this.CorrectionTypeLabel = new System.Windows.Forms.Label();
			this.TabGamma = new System.Windows.Forms.TabPage();
			this.GammaValue = new System.Windows.Forms.Label();
			this.GammaBox = new System.Windows.Forms.TrackBar();
			this.GammaLabel = new System.Windows.Forms.Label();
			this.TabNoise = new System.Windows.Forms.TabPage();
			this.SizeValue = new System.Windows.Forms.Label();
			this.SizeBox = new System.Windows.Forms.TrackBar();
			this.SizeLabel = new System.Windows.Forms.Label();
			this.StrengthValue = new System.Windows.Forms.Label();
			this.StrengthBox = new System.Windows.Forms.TrackBar();
			this.StrengthLabel = new System.Windows.Forms.Label();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Apply = new System.Windows.Forms.Button();
			this.CurrentEffect = new System.Windows.Forms.ComboBox();
			this.OpenImage = new System.Windows.Forms.OpenFileDialog();
			this.ImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SaveImage = new System.Windows.Forms.ToolStripMenuItem();
			this.ResetChanges = new System.Windows.Forms.ToolStripMenuItem();
			this.Fullsize = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseImage = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
			this.OpenXML = new System.Windows.Forms.OpenFileDialog();
			this.SaveXML = new System.Windows.Forms.SaveFileDialog();
			this.PauseButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.MainMenu.SuspendLayout();
			this.Parameters.SuspendLayout();
			this.TabCorrection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CoefficientBox)).BeginInit();
			this.TabGamma.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GammaBox)).BeginInit();
			this.TabNoise.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StrengthBox)).BeginInit();
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
			this.OpenMI.Size = new System.Drawing.Size(104, 22);
			this.OpenMI.Text = "&Open";
			this.OpenMI.Click += new System.EventHandler(this.OpenMI_Click);
			// 
			// EditMI
			// 
			this.EditMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMI,
            this.ProcessMI,
            this.ResetAllMI});
			this.EditMI.Name = "EditMI";
			this.EditMI.Size = new System.Drawing.Size(40, 20);
			this.EditMI.Text = "Edit";
			// 
			// ShowMI
			// 
			this.ShowMI.Checked = true;
			this.ShowMI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowMI.Name = "ShowMI";
			this.ShowMI.Size = new System.Drawing.Size(176, 22);
			this.ShowMI.Text = "Show Result";
			this.ShowMI.Click += new System.EventHandler(this.ShowMI_Click);
			// 
			// ProcessMI
			// 
			this.ProcessMI.Checked = true;
			this.ProcessMI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ProcessMI.Name = "ProcessMI";
			this.ProcessMI.Size = new System.Drawing.Size(176, 22);
			this.ProcessMI.Text = "Process All";
			this.ProcessMI.Click += new System.EventHandler(this.ProcessMI_Click);
			// 
			// ResetAllMI
			// 
			this.ResetAllMI.Name = "ResetAllMI";
			this.ResetAllMI.Size = new System.Drawing.Size(176, 22);
			this.ResetAllMI.Text = "Reset All Changes";
			this.ResetAllMI.Click += new System.EventHandler(this.ResetAllMI_Click);
			// 
			// ToolsMI
			// 
			this.ToolsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMI,
            this.SettingsMI,
            this.AdminPanelMI,
            this.EffectsMI});
			this.ToolsMI.Name = "ToolsMI";
			this.ToolsMI.Size = new System.Drawing.Size(49, 20);
			this.ToolsMI.Text = "Tools";
			// 
			// AccountMI
			// 
			this.AccountMI.Name = "AccountMI";
			this.AccountMI.Size = new System.Drawing.Size(144, 22);
			this.AccountMI.Text = "Account";
			this.AccountMI.Click += new System.EventHandler(this.AccountMI_Click);
			// 
			// SettingsMI
			// 
			this.SettingsMI.Name = "SettingsMI";
			this.SettingsMI.Size = new System.Drawing.Size(144, 22);
			this.SettingsMI.Text = "Settings";
			this.SettingsMI.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// AdminPanelMI
			// 
			this.AdminPanelMI.Name = "AdminPanelMI";
			this.AdminPanelMI.Size = new System.Drawing.Size(144, 22);
			this.AdminPanelMI.Text = "Admin Panel";
			this.AdminPanelMI.Click += new System.EventHandler(this.AdminPanelMI_Click);
			// 
			// EffectsMI
			// 
			this.EffectsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportMI,
            this.ExportMI});
			this.EffectsMI.Name = "EffectsMI";
			this.EffectsMI.Size = new System.Drawing.Size(144, 22);
			this.EffectsMI.Text = "Effects";
			// 
			// ImportMI
			// 
			this.ImportMI.Name = "ImportMI";
			this.ImportMI.Size = new System.Drawing.Size(177, 22);
			this.ImportMI.Text = "Import Parameters";
			this.ImportMI.Click += new System.EventHandler(this.ImportMI_Click);
			// 
			// ExportMI
			// 
			this.ExportMI.Name = "ExportMI";
			this.ExportMI.Size = new System.Drawing.Size(177, 22);
			this.ExportMI.Text = "Export Parameters";
			this.ExportMI.Click += new System.EventHandler(this.ExportMI_Click);
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
			// Parameters
			// 
			this.Parameters.Controls.Add(this.TabCorrection);
			this.Parameters.Controls.Add(this.TabGamma);
			this.Parameters.Controls.Add(this.TabNoise);
			this.Parameters.Enabled = false;
			this.Parameters.Location = new System.Drawing.Point(378, 31);
			this.Parameters.Name = "Parameters";
			this.Parameters.SelectedIndex = 0;
			this.Parameters.Size = new System.Drawing.Size(245, 130);
			this.Parameters.TabIndex = 2;
			this.Parameters.SelectedIndexChanged += new System.EventHandler(this.Parameters_SelectedIndexChanged);
			// 
			// TabCorrection
			// 
			this.TabCorrection.Controls.Add(this.CoefficientValue);
			this.TabCorrection.Controls.Add(this.CoefficientBox);
			this.TabCorrection.Controls.Add(this.CoefficientLabel);
			this.TabCorrection.Controls.Add(this.CorrectionType);
			this.TabCorrection.Controls.Add(this.CorrectionTypeLabel);
			this.TabCorrection.Location = new System.Drawing.Point(4, 22);
			this.TabCorrection.Name = "TabCorrection";
			this.TabCorrection.Padding = new System.Windows.Forms.Padding(4);
			this.TabCorrection.Size = new System.Drawing.Size(237, 104);
			this.TabCorrection.TabIndex = 0;
			this.TabCorrection.Text = "Correction";
			this.TabCorrection.UseVisualStyleBackColor = true;
			// 
			// CoefficientValue
			// 
			this.CoefficientValue.AutoSize = true;
			this.CoefficientValue.Location = new System.Drawing.Point(67, 38);
			this.CoefficientValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.CoefficientValue.Name = "CoefficientValue";
			this.CoefficientValue.Size = new System.Drawing.Size(19, 13);
			this.CoefficientValue.TabIndex = 5;
			this.CoefficientValue.Text = "25";
			// 
			// CoefficientBox
			// 
			this.CoefficientBox.AutoSize = false;
			this.CoefficientBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CoefficientBox.Location = new System.Drawing.Point(7, 54);
			this.CoefficientBox.Maximum = 50;
			this.CoefficientBox.Minimum = 1;
			this.CoefficientBox.Name = "CoefficientBox";
			this.CoefficientBox.Size = new System.Drawing.Size(223, 21);
			this.CoefficientBox.TabIndex = 4;
			this.CoefficientBox.Value = 25;
			this.CoefficientBox.Scroll += new System.EventHandler(this.CoefficientBox_Scroll);
			// 
			// CoefficientLabel
			// 
			this.CoefficientLabel.AutoSize = true;
			this.CoefficientLabel.Location = new System.Drawing.Point(7, 38);
			this.CoefficientLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.CoefficientLabel.Name = "CoefficientLabel";
			this.CoefficientLabel.Size = new System.Drawing.Size(60, 13);
			this.CoefficientLabel.TabIndex = 2;
			this.CoefficientLabel.Text = "Coefficient:";
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
			this.CorrectionType.SelectedIndexChanged += new System.EventHandler(this.CorrectionType_SelectedIndexChanged);
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
			this.TabGamma.Controls.Add(this.GammaValue);
			this.TabGamma.Controls.Add(this.GammaBox);
			this.TabGamma.Controls.Add(this.GammaLabel);
			this.TabGamma.Location = new System.Drawing.Point(4, 22);
			this.TabGamma.Name = "TabGamma";
			this.TabGamma.Padding = new System.Windows.Forms.Padding(4);
			this.TabGamma.Size = new System.Drawing.Size(237, 104);
			this.TabGamma.TabIndex = 1;
			this.TabGamma.Text = "Gamma";
			this.TabGamma.UseVisualStyleBackColor = true;
			// 
			// GammaValue
			// 
			this.GammaValue.AutoSize = true;
			this.GammaValue.Location = new System.Drawing.Point(53, 10);
			this.GammaValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.GammaValue.Name = "GammaValue";
			this.GammaValue.Size = new System.Drawing.Size(22, 13);
			this.GammaValue.TabIndex = 10;
			this.GammaValue.Text = "2.5";
			// 
			// GammaBox
			// 
			this.GammaBox.AutoSize = false;
			this.GammaBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.GammaBox.Location = new System.Drawing.Point(7, 26);
			this.GammaBox.Maximum = 50;
			this.GammaBox.Minimum = 1;
			this.GammaBox.Name = "GammaBox";
			this.GammaBox.Size = new System.Drawing.Size(223, 21);
			this.GammaBox.TabIndex = 9;
			this.GammaBox.Value = 25;
			this.GammaBox.Scroll += new System.EventHandler(this.GammaBox_Scroll);
			// 
			// GammaLabel
			// 
			this.GammaLabel.AutoSize = true;
			this.GammaLabel.Location = new System.Drawing.Point(7, 10);
			this.GammaLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.GammaLabel.Name = "GammaLabel";
			this.GammaLabel.Size = new System.Drawing.Size(46, 13);
			this.GammaLabel.TabIndex = 8;
			this.GammaLabel.Text = "Gamma:";
			// 
			// TabNoise
			// 
			this.TabNoise.Controls.Add(this.SizeValue);
			this.TabNoise.Controls.Add(this.SizeBox);
			this.TabNoise.Controls.Add(this.SizeLabel);
			this.TabNoise.Controls.Add(this.StrengthValue);
			this.TabNoise.Controls.Add(this.StrengthBox);
			this.TabNoise.Controls.Add(this.StrengthLabel);
			this.TabNoise.Location = new System.Drawing.Point(4, 22);
			this.TabNoise.Name = "TabNoise";
			this.TabNoise.Padding = new System.Windows.Forms.Padding(4);
			this.TabNoise.Size = new System.Drawing.Size(237, 104);
			this.TabNoise.TabIndex = 2;
			this.TabNoise.Text = "Noise";
			this.TabNoise.UseVisualStyleBackColor = true;
			// 
			// SizeValue
			// 
			this.SizeValue.AutoSize = true;
			this.SizeValue.Location = new System.Drawing.Point(38, 56);
			this.SizeValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.SizeValue.Name = "SizeValue";
			this.SizeValue.Size = new System.Drawing.Size(27, 13);
			this.SizeValue.TabIndex = 16;
			this.SizeValue.Text = "75%";
			// 
			// SizeBox
			// 
			this.SizeBox.AutoSize = false;
			this.SizeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SizeBox.Location = new System.Drawing.Point(7, 72);
			this.SizeBox.Maximum = 100;
			this.SizeBox.Minimum = 5;
			this.SizeBox.Name = "SizeBox";
			this.SizeBox.Size = new System.Drawing.Size(223, 21);
			this.SizeBox.TabIndex = 15;
			this.SizeBox.Value = 75;
			this.SizeBox.Scroll += new System.EventHandler(this.SizeBox_Scroll);
			// 
			// SizeLabel
			// 
			this.SizeLabel.AutoSize = true;
			this.SizeLabel.Location = new System.Drawing.Point(7, 56);
			this.SizeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.SizeLabel.Name = "SizeLabel";
			this.SizeLabel.Size = new System.Drawing.Size(30, 13);
			this.SizeLabel.TabIndex = 14;
			this.SizeLabel.Text = "Size:";
			// 
			// StrengthValue
			// 
			this.StrengthValue.AutoSize = true;
			this.StrengthValue.Location = new System.Drawing.Point(57, 10);
			this.StrengthValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.StrengthValue.Name = "StrengthValue";
			this.StrengthValue.Size = new System.Drawing.Size(19, 13);
			this.StrengthValue.TabIndex = 13;
			this.StrengthValue.Text = "40";
			// 
			// StrengthBox
			// 
			this.StrengthBox.AutoSize = false;
			this.StrengthBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.StrengthBox.Location = new System.Drawing.Point(7, 26);
			this.StrengthBox.Maximum = 60;
			this.StrengthBox.Minimum = 10;
			this.StrengthBox.Name = "StrengthBox";
			this.StrengthBox.Size = new System.Drawing.Size(223, 21);
			this.StrengthBox.TabIndex = 12;
			this.StrengthBox.Value = 40;
			this.StrengthBox.Scroll += new System.EventHandler(this.StrengthBox_Scroll);
			// 
			// StrengthLabel
			// 
			this.StrengthLabel.AutoSize = true;
			this.StrengthLabel.Location = new System.Drawing.Point(7, 10);
			this.StrengthLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.StrengthLabel.Name = "StrengthLabel";
			this.StrengthLabel.Size = new System.Drawing.Size(50, 13);
			this.StrengthLabel.TabIndex = 11;
			this.StrengthLabel.Text = "Strength:";
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel});
			this.StatusBar.Location = new System.Drawing.Point(0, 239);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(634, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 3;
			this.StatusBar.Text = "statusStrip1";
			// 
			// ProgressLabel
			// 
			this.ProgressLabel.Name = "ProgressLabel";
			this.ProgressLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// Apply
			// 
			this.Apply.Enabled = false;
			this.Apply.Location = new System.Drawing.Point(543, 167);
			this.Apply.Name = "Apply";
			this.Apply.Size = new System.Drawing.Size(80, 51);
			this.Apply.TabIndex = 4;
			this.Apply.Text = "Apply";
			this.Apply.UseVisualStyleBackColor = true;
			this.Apply.Click += new System.EventHandler(this.Apply_Click);
			// 
			// CurrentEffect
			// 
			this.CurrentEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CurrentEffect.Enabled = false;
			this.CurrentEffect.FormattingEnabled = true;
			this.CurrentEffect.Items.AddRange(new object[] {
            "Correction",
            "Gamma",
            "Noise",
            "Wave",
            "Glass"});
			this.CurrentEffect.Location = new System.Drawing.Point(378, 168);
			this.CurrentEffect.Name = "CurrentEffect";
			this.CurrentEffect.Size = new System.Drawing.Size(159, 21);
			this.CurrentEffect.TabIndex = 2;
			this.CurrentEffect.SelectedIndexChanged += new System.EventHandler(this.CurrentEffect_SelectedIndexChanged);
			// 
			// OpenImage
			// 
			this.OpenImage.Filter = "Images|*.bmp;*.jpg;*.jpeg";
			this.OpenImage.Multiselect = true;
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
			// SaveImage
			// 
			this.SaveImage.Name = "SaveImage";
			this.SaveImage.Size = new System.Drawing.Size(151, 22);
			this.SaveImage.Text = "Save Image";
			this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
			// 
			// ResetChanges
			// 
			this.ResetChanges.Name = "ResetChanges";
			this.ResetChanges.Size = new System.Drawing.Size(151, 22);
			this.ResetChanges.Text = "Reset Changes";
			this.ResetChanges.Click += new System.EventHandler(this.ResetChanges_Click);
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
			// SaveImageDialog
			// 
			this.SaveImageDialog.FileName = "Result.bmp";
			this.SaveImageDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg";
			// 
			// OpenXML
			// 
			this.OpenXML.Filter = "Parameters|*.xml";
			// 
			// SaveXML
			// 
			this.SaveXML.FileName = "Parameters.xml";
			this.SaveXML.Filter = "Parameters|*.xml";
			// 
			// PauseButton
			// 
			this.PauseButton.Enabled = false;
			this.PauseButton.Location = new System.Drawing.Point(377, 195);
			this.PauseButton.Name = "PauseButton";
			this.PauseButton.Size = new System.Drawing.Size(80, 23);
			this.PauseButton.TabIndex = 5;
			this.PauseButton.Text = "Pause";
			this.PauseButton.UseVisualStyleBackColor = true;
			this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Enabled = false;
			this.StopButton.Location = new System.Drawing.Point(463, 195);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(74, 23);
			this.StopButton.TabIndex = 6;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 261);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.PauseButton);
			this.Controls.Add(this.CurrentEffect);
			this.Controls.Add(this.Apply);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.Parameters);
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
			this.Parameters.ResumeLayout(false);
			this.TabCorrection.ResumeLayout(false);
			this.TabCorrection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CoefficientBox)).EndInit();
			this.TabGamma.ResumeLayout(false);
			this.TabGamma.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GammaBox)).EndInit();
			this.TabNoise.ResumeLayout(false);
			this.TabNoise.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StrengthBox)).EndInit();
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
        private System.Windows.Forms.TabControl Parameters;
        private System.Windows.Forms.TabPage TabCorrection;
        private System.Windows.Forms.TabPage TabGamma;
        private System.Windows.Forms.TabPage TabNoise;
        private System.Windows.Forms.Label CorrectionTypeLabel;
        private System.Windows.Forms.ComboBox CorrectionType;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.ComboBox CurrentEffect;
		private System.Windows.Forms.ToolStripMenuItem AccountMI;
		private System.Windows.Forms.OpenFileDialog OpenImage;
		private System.Windows.Forms.ContextMenuStrip ImageMenu;
		private System.Windows.Forms.ToolStripMenuItem Fullsize;
		private System.Windows.Forms.ToolStripMenuItem CloseImage;
		private System.Windows.Forms.ToolStripMenuItem ResetChanges;
		private System.Windows.Forms.SaveFileDialog SaveImageDialog;
		private System.Windows.Forms.ToolStripMenuItem SaveImage;
		private System.Windows.Forms.Label CoefficientValue;
		private System.Windows.Forms.TrackBar CoefficientBox;
		private System.Windows.Forms.Label CoefficientLabel;
		private System.Windows.Forms.Label GammaValue;
		private System.Windows.Forms.TrackBar GammaBox;
		private System.Windows.Forms.Label GammaLabel;
		private System.Windows.Forms.Label StrengthValue;
		private System.Windows.Forms.TrackBar StrengthBox;
		private System.Windows.Forms.Label StrengthLabel;
		private System.Windows.Forms.Label SizeValue;
		private System.Windows.Forms.TrackBar SizeBox;
		private System.Windows.Forms.Label SizeLabel;
		private System.Windows.Forms.ToolStripMenuItem EffectsMI;
		private System.Windows.Forms.ToolStripMenuItem ImportMI;
		private System.Windows.Forms.ToolStripMenuItem ExportMI;
		private System.Windows.Forms.OpenFileDialog OpenXML;
		private System.Windows.Forms.SaveFileDialog SaveXML;
		private System.Windows.Forms.Button PauseButton;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.ToolStripMenuItem ResetAllMI;
		private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
	}
}