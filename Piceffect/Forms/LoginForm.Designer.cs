namespace Piceffect
{
	partial class LoginForm
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
			this.LoginBox = new System.Windows.Forms.TextBox();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.LabelLogin = new System.Windows.Forms.Label();
			this.LabelPassword = new System.Windows.Forms.Label();
			this.SignUp = new System.Windows.Forms.Button();
			this.SignIn = new System.Windows.Forms.Button();
			this.LabelQuestion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginBox
			// 
			this.LoginBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginBox.Location = new System.Drawing.Point(12, 30);
			this.LoginBox.Name = "LoginBox";
			this.LoginBox.Size = new System.Drawing.Size(198, 21);
			this.LoginBox.TabIndex = 0;
			this.LoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordBox.Location = new System.Drawing.Point(12, 74);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(198, 21);
			this.PasswordBox.TabIndex = 1;
			this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LabelLogin
			// 
			this.LabelLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.LabelLogin.Location = new System.Drawing.Point(12, 9);
			this.LabelLogin.Name = "LabelLogin";
			this.LabelLogin.Size = new System.Drawing.Size(198, 18);
			this.LabelLogin.TabIndex = 2;
			this.LabelLogin.Text = "Login";
			this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelPassword
			// 
			this.LabelPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.LabelPassword.Location = new System.Drawing.Point(12, 53);
			this.LabelPassword.Name = "LabelPassword";
			this.LabelPassword.Size = new System.Drawing.Size(198, 18);
			this.LabelPassword.TabIndex = 3;
			this.LabelPassword.Text = "Password";
			this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SignUp
			// 
			this.SignUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SignUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SignUp.Location = new System.Drawing.Point(11, 152);
			this.SignUp.Name = "SignUp";
			this.SignUp.Size = new System.Drawing.Size(200, 22);
			this.SignUp.TabIndex = 3;
			this.SignUp.Text = "Sign Up";
			this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
			// 
			// SignIn
			// 
			this.SignIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SignIn.Location = new System.Drawing.Point(11, 100);
			this.SignIn.Name = "SignIn";
			this.SignIn.Size = new System.Drawing.Size(200, 22);
			this.SignIn.TabIndex = 2;
			this.SignIn.Text = "Sign In";
			this.SignIn.UseVisualStyleBackColor = true;
			this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
			// 
			// LabelQuestion
			// 
			this.LabelQuestion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.LabelQuestion.Location = new System.Drawing.Point(12, 125);
			this.LabelQuestion.Name = "LabelQuestion";
			this.LabelQuestion.Size = new System.Drawing.Size(200, 24);
			this.LabelQuestion.TabIndex = 7;
			this.LabelQuestion.Text = "Do you have not account?";
			this.LabelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 186);
			this.Controls.Add(this.LabelQuestion);
			this.Controls.Add(this.SignIn);
			this.Controls.Add(this.SignUp);
			this.Controls.Add(this.LabelPassword);
			this.Controls.Add(this.LabelLogin);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.LoginBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Piceffect";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LoginBox;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Label LabelLogin;
		private System.Windows.Forms.Label LabelPassword;
		private System.Windows.Forms.Button SignUp;
		private System.Windows.Forms.Button SignIn;
		private System.Windows.Forms.Label LabelQuestion;
	}
}

