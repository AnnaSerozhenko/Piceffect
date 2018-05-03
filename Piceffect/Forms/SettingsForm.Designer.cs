namespace Piceffect
{
	partial class SettingsForm
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
			this.Tabs = new System.Windows.Forms.TabControl();
			this.TabGeneral = new System.Windows.Forms.TabPage();
			this.LogButton = new System.Windows.Forms.Button();
			this.DatabaseButton = new System.Windows.Forms.Button();
			this.JournalButton = new System.Windows.Forms.Button();
			this.LogLabel = new System.Windows.Forms.Label();
			this.LogBox = new System.Windows.Forms.TextBox();
			this.DatabaseLogin = new System.Windows.Forms.Label();
			this.DatabaseBox = new System.Windows.Forms.TextBox();
			this.JournalLabel = new System.Windows.Forms.Label();
			this.JournalBox = new System.Windows.Forms.TextBox();
			this.ActionPanel = new System.Windows.Forms.Panel();
			this.SaveSettings = new System.Windows.Forms.Button();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.Tabs.SuspendLayout();
			this.TabGeneral.SuspendLayout();
			this.ActionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tabs
			// 
			this.Tabs.Controls.Add(this.TabGeneral);
			this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tabs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Tabs.Location = new System.Drawing.Point(0, 0);
			this.Tabs.Margin = new System.Windows.Forms.Padding(0);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new System.Drawing.Size(334, 116);
			this.Tabs.TabIndex = 0;
			// 
			// TabGeneral
			// 
			this.TabGeneral.Controls.Add(this.LogButton);
			this.TabGeneral.Controls.Add(this.DatabaseButton);
			this.TabGeneral.Controls.Add(this.JournalButton);
			this.TabGeneral.Controls.Add(this.LogLabel);
			this.TabGeneral.Controls.Add(this.LogBox);
			this.TabGeneral.Controls.Add(this.DatabaseLogin);
			this.TabGeneral.Controls.Add(this.DatabaseBox);
			this.TabGeneral.Controls.Add(this.JournalLabel);
			this.TabGeneral.Controls.Add(this.JournalBox);
			this.TabGeneral.Location = new System.Drawing.Point(4, 24);
			this.TabGeneral.Name = "TabGeneral";
			this.TabGeneral.Padding = new System.Windows.Forms.Padding(4);
			this.TabGeneral.Size = new System.Drawing.Size(326, 88);
			this.TabGeneral.TabIndex = 0;
			this.TabGeneral.Text = "General";
			this.TabGeneral.UseVisualStyleBackColor = true;
			// 
			// LogButton
			// 
			this.LogButton.Location = new System.Drawing.Point(294, 59);
			this.LogButton.Name = "LogButton";
			this.LogButton.Size = new System.Drawing.Size(24, 22);
			this.LogButton.TabIndex = 8;
			this.LogButton.Text = "...";
			this.LogButton.UseVisualStyleBackColor = true;
			// 
			// DatabaseButton
			// 
			this.DatabaseButton.Location = new System.Drawing.Point(294, 33);
			this.DatabaseButton.Name = "DatabaseButton";
			this.DatabaseButton.Size = new System.Drawing.Size(24, 22);
			this.DatabaseButton.TabIndex = 7;
			this.DatabaseButton.Text = "...";
			this.DatabaseButton.UseVisualStyleBackColor = true;
			// 
			// JournalButton
			// 
			this.JournalButton.Location = new System.Drawing.Point(294, 7);
			this.JournalButton.Name = "JournalButton";
			this.JournalButton.Size = new System.Drawing.Size(24, 22);
			this.JournalButton.TabIndex = 6;
			this.JournalButton.Text = "...";
			this.JournalButton.UseVisualStyleBackColor = true;
			// 
			// LogLabel
			// 
			this.LogLabel.AutoSize = true;
			this.LogLabel.Location = new System.Drawing.Point(7, 64);
			this.LogLabel.Name = "LogLabel";
			this.LogLabel.Size = new System.Drawing.Size(47, 15);
			this.LogLabel.TabIndex = 5;
			this.LogLabel.Text = "Log file";
			// 
			// LogBox
			// 
			this.LogBox.Location = new System.Drawing.Point(89, 60);
			this.LogBox.Name = "LogBox";
			this.LogBox.Size = new System.Drawing.Size(201, 21);
			this.LogBox.TabIndex = 4;
			this.LogBox.Text = "Log.txt";
			// 
			// DatabaseLogin
			// 
			this.DatabaseLogin.AutoSize = true;
			this.DatabaseLogin.Location = new System.Drawing.Point(7, 38);
			this.DatabaseLogin.Name = "DatabaseLogin";
			this.DatabaseLogin.Size = new System.Drawing.Size(80, 15);
			this.DatabaseLogin.TabIndex = 3;
			this.DatabaseLogin.Text = "Database file";
			// 
			// DatabaseBox
			// 
			this.DatabaseBox.Location = new System.Drawing.Point(89, 34);
			this.DatabaseBox.Name = "DatabaseBox";
			this.DatabaseBox.Size = new System.Drawing.Size(201, 21);
			this.DatabaseBox.TabIndex = 2;
			this.DatabaseBox.Text = "Database.sqlite";
			// 
			// JournalLabel
			// 
			this.JournalLabel.AutoSize = true;
			this.JournalLabel.Location = new System.Drawing.Point(7, 11);
			this.JournalLabel.Name = "JournalLabel";
			this.JournalLabel.Size = new System.Drawing.Size(67, 15);
			this.JournalLabel.TabIndex = 1;
			this.JournalLabel.Text = "Journal file";
			// 
			// JournalBox
			// 
			this.JournalBox.Location = new System.Drawing.Point(89, 8);
			this.JournalBox.Name = "JournalBox";
			this.JournalBox.Size = new System.Drawing.Size(201, 21);
			this.JournalBox.TabIndex = 0;
			this.JournalBox.Text = "Journal.txt";
			// 
			// ActionPanel
			// 
			this.ActionPanel.Controls.Add(this.SaveSettings);
			this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ActionPanel.Location = new System.Drawing.Point(0, 116);
			this.ActionPanel.Name = "ActionPanel";
			this.ActionPanel.Padding = new System.Windows.Forms.Padding(2);
			this.ActionPanel.Size = new System.Drawing.Size(334, 28);
			this.ActionPanel.TabIndex = 1;
			// 
			// SaveSettings
			// 
			this.SaveSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.SaveSettings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveSettings.Location = new System.Drawing.Point(232, 2);
			this.SaveSettings.Name = "SaveSettings";
			this.SaveSettings.Size = new System.Drawing.Size(100, 24);
			this.SaveSettings.TabIndex = 0;
			this.SaveSettings.Text = "Save";
			this.SaveSettings.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 144);
			this.Controls.Add(this.Tabs);
			this.Controls.Add(this.ActionPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Tabs.ResumeLayout(false);
			this.TabGeneral.ResumeLayout(false);
			this.TabGeneral.PerformLayout();
			this.ActionPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Tabs;
		private System.Windows.Forms.TabPage TabGeneral;
		private System.Windows.Forms.Label JournalLabel;
		private System.Windows.Forms.TextBox JournalBox;
		private System.Windows.Forms.Label DatabaseLogin;
		private System.Windows.Forms.TextBox DatabaseBox;
		private System.Windows.Forms.Label LogLabel;
		private System.Windows.Forms.TextBox LogBox;
		private System.Windows.Forms.Button LogButton;
		private System.Windows.Forms.Button DatabaseButton;
		private System.Windows.Forms.Button JournalButton;
		private System.Windows.Forms.Panel ActionPanel;
		private System.Windows.Forms.Button SaveSettings;
		private System.Windows.Forms.OpenFileDialog OpenFile;
	}
}