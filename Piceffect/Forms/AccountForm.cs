using System;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class AccountForm : Form
	{
		public AccountForm()
		{
			InitializeComponent();
			LoginBox.Text = Session.Login;
		}

		private void Change_Click(object sender, EventArgs e)
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
			bool result = true;
			if (!LoginBox.Text.Equals(Session.Login)) result = DB.CheckLogin(LoginBox.Text);
			if (!result) Message.Error(DB.Status, Text);
			else
			{
				result = DB.ChangeAccount(LoginBox.Text, PasswordBox.Text);
				if (!result) Message.Error(DB.Status, Text);
				else
				{
					Session.Create(Session.ID, LoginBox.Text, Session.IsAdmin);
					Message.Info("Account successfuly updated!", Text);
					Journal.Append(String.Format("{0} changed password", Session.Login));
				}
			}
		}
	}
}
