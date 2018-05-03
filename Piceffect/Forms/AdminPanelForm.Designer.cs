namespace Piceffect
{
	partial class AdminPanelForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Accounts = new System.Windows.Forms.DataGridView();
			this.DeleteUser = new System.Windows.Forms.Button();
			this.ActionPanel = new System.Windows.Forms.Panel();
			this.BlockUser = new System.Windows.Forms.Button();
			this.SetAsAdmin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Accounts)).BeginInit();
			this.ActionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Accounts
			// 
			this.Accounts.AllowUserToAddRows = false;
			this.Accounts.AllowUserToDeleteRows = false;
			this.Accounts.AllowUserToResizeRows = false;
			this.Accounts.BackgroundColor = System.Drawing.Color.White;
			this.Accounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Accounts.DefaultCellStyle = dataGridViewCellStyle2;
			this.Accounts.Location = new System.Drawing.Point(12, 12);
			this.Accounts.Name = "Accounts";
			this.Accounts.ReadOnly = true;
			this.Accounts.RowHeadersVisible = false;
			this.Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Accounts.Size = new System.Drawing.Size(435, 150);
			this.Accounts.TabIndex = 0;
			this.Accounts.SelectionChanged += new System.EventHandler(this.Accounts_SelectionChanged);
			// 
			// DeleteUser
			// 
			this.DeleteUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeleteUser.Location = new System.Drawing.Point(335, 3);
			this.DeleteUser.Name = "DeleteUser";
			this.DeleteUser.Size = new System.Drawing.Size(95, 23);
			this.DeleteUser.TabIndex = 1;
			this.DeleteUser.Text = "Delete";
			this.DeleteUser.UseVisualStyleBackColor = true;
			this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
			// 
			// ActionPanel
			// 
			this.ActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ActionPanel.Controls.Add(this.SetAsAdmin);
			this.ActionPanel.Controls.Add(this.BlockUser);
			this.ActionPanel.Controls.Add(this.DeleteUser);
			this.ActionPanel.Location = new System.Drawing.Point(12, 168);
			this.ActionPanel.Name = "ActionPanel";
			this.ActionPanel.Size = new System.Drawing.Size(435, 31);
			this.ActionPanel.TabIndex = 2;
			// 
			// BlockUser
			// 
			this.BlockUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BlockUser.Location = new System.Drawing.Point(234, 3);
			this.BlockUser.Name = "BlockUser";
			this.BlockUser.Size = new System.Drawing.Size(95, 23);
			this.BlockUser.TabIndex = 2;
			this.BlockUser.Text = "Block";
			this.BlockUser.UseVisualStyleBackColor = true;
			this.BlockUser.Click += new System.EventHandler(this.BlockUser_Click);
			// 
			// SetAsAdmin
			// 
			this.SetAsAdmin.Location = new System.Drawing.Point(138, 3);
			this.SetAsAdmin.Name = "SetAsAdmin";
			this.SetAsAdmin.Size = new System.Drawing.Size(90, 23);
			this.SetAsAdmin.TabIndex = 3;
			this.SetAsAdmin.Text = "Set As Admin";
			this.SetAsAdmin.UseVisualStyleBackColor = true;
			this.SetAsAdmin.Click += new System.EventHandler(this.SetAsAdmin_Click);
			// 
			// AdminPanelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 211);
			this.Controls.Add(this.ActionPanel);
			this.Controls.Add(this.Accounts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AdminPanelForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Panel";
			this.Load += new System.EventHandler(this.AdminPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.Accounts)).EndInit();
			this.ActionPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView Accounts;
		private System.Windows.Forms.Button DeleteUser;
		private System.Windows.Forms.Panel ActionPanel;
		private System.Windows.Forms.Button BlockUser;
		private System.Windows.Forms.Button SetAsAdmin;
	}
}