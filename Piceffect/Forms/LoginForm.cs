using System;
using System.IO;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			Config.Load();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			if (!File.Exists(Config.DataBase))
			{
				if (Message.Warning("Database not exist! Do you want to create new database?", Text, true) == DialogResult.Yes)
				{
					DB.CreateDatabase();
				}
				else
				{
					Message.Warning("Сan't continue without a database!", Text);
					Close();
				}
			}
			if (!DB.CheckConnection())
			{
				Message.Warning("Couldn't connect to the database!", Text);
				Close();
			}
		}

		private void SignIn_Click(object sender, EventArgs e)
		{
			if (LoginBox.Text.Length == 0)
			{
				Message.Warning("Empty login!", Text);
				return;
			}
			if (PasswordBox.Text.Length == 0)
			{
				Message.Warning("Empty password!", Text);
				return;
			}
			bool success = DB.Login(LoginBox.Text, PasswordBox.Text);
			if (!success) Message.Error(DB.Status, Text);
			else
			{
				MainForm form = new MainForm();
				form.Show(this);
				Hide();
			}
			LoginBox.Clear();
			PasswordBox.Clear();
		}

		private void SignUp_Click(object sender, EventArgs e)
		{
			if (LoginBox.Text.Length == 0)
			{
				Message.Warning("Empty login!", Text);
				return;
			}
			if (PasswordBox.Text.Length == 0)
			{
				Message.Warning("Empty password!", Text);
				return;
			}
			bool result = DB.CheckLogin(LoginBox.Text);
			if (!result) Message.Error(DB.Status, Text);
			else
			{
				result = DB.Register(LoginBox.Text, PasswordBox.Text);
				if (!result) Message.Error(DB.Status, Text);
				else Message.Info("You have successfully registered!" + Environment.NewLine + "Log in using the registration data.", Text);
			}
			LoginBox.Clear();
			PasswordBox.Clear();
		}
	}
}
