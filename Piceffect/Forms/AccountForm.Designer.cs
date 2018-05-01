namespace Piceffect
{
	partial class AccountForm
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
			this.Change = new System.Windows.Forms.Button();
			this.LabelPassword = new System.Windows.Forms.Label();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Change
			// 
			this.Change.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Change.Location = new System.Drawing.Point(11, 56);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(200, 22);
			this.Change.TabIndex = 9;
			this.Change.Text = "Change";
			this.Change.UseVisualStyleBackColor = true;
			this.Change.Click += new System.EventHandler(this.Change_Click);
			// 
			// LabelPassword
			// 
			this.LabelPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.LabelPassword.Location = new System.Drawing.Point(12, 9);
			this.LabelPassword.Name = "LabelPassword";
			this.LabelPassword.Size = new System.Drawing.Size(198, 18);
			this.LabelPassword.TabIndex = 8;
			this.LabelPassword.Text = "New password";
			this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordBox.Location = new System.Drawing.Point(12, 30);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(198, 21);
			this.PasswordBox.TabIndex = 7;
			this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 92);
			this.Controls.Add(this.Change);
			this.Controls.Add(this.LabelPassword);
			this.Controls.Add(this.PasswordBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AccountForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Change;
		private System.Windows.Forms.Label LabelPassword;
		private System.Windows.Forms.TextBox PasswordBox;
	}
}