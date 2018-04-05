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
			this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RegistrationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VisitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BlockedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.Accounts)).BeginInit();
			this.ActionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Accounts
			// 
			this.Accounts.AllowUserToAddRows = false;
			this.Accounts.AllowUserToDeleteRows = false;
			this.Accounts.AllowUserToResizeColumns = false;
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
			this.Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.LoginColumn,
            this.RegistrationColumn,
            this.VisitColumn,
            this.BlockedColumn});
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
			// 
			// ActionPanel
			// 
			this.ActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			// 
			// IDColumn
			// 
			this.IDColumn.HeaderText = "ID";
			this.IDColumn.Name = "IDColumn";
			this.IDColumn.ReadOnly = true;
			this.IDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.IDColumn.Width = 35;
			// 
			// LoginColumn
			// 
			this.LoginColumn.HeaderText = "Login";
			this.LoginColumn.Name = "LoginColumn";
			this.LoginColumn.ReadOnly = true;
			this.LoginColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.LoginColumn.Width = 150;
			// 
			// RegistrationColumn
			// 
			this.RegistrationColumn.HeaderText = "Registration";
			this.RegistrationColumn.Name = "RegistrationColumn";
			this.RegistrationColumn.ReadOnly = true;
			this.RegistrationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.RegistrationColumn.Width = 75;
			// 
			// VisitColumn
			// 
			this.VisitColumn.HeaderText = "Visit";
			this.VisitColumn.Name = "VisitColumn";
			this.VisitColumn.ReadOnly = true;
			this.VisitColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.VisitColumn.Width = 75;
			// 
			// BlockedColumn
			// 
			this.BlockedColumn.HeaderText = "Blocked";
			this.BlockedColumn.Name = "BlockedColumn";
			this.BlockedColumn.ReadOnly = true;
			this.BlockedColumn.Width = 75;
			// 
			// AdminPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 211);
			this.Controls.Add(this.ActionPanel);
			this.Controls.Add(this.Accounts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AdminPanel";
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
		private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn VisitColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BlockedColumn;
	}
}