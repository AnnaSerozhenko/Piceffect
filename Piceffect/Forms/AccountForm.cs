using System;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class AccountForm : Form
	{
		public AccountForm()
		{
			InitializeComponent();
		}

		private void Change_Click(object sender, EventArgs e)
		{
			if (PasswordBox.Text.Length == 0)
			{
				Message.Warning("Empty password!", Text);
				return;
			}
			bool result = DB.ChangePassword(PasswordBox.Text);
			if (!result) Message.Error(DB.Status, Text);
			else
			{
				Message.Info("Password successfuly changed!", Text);
			}
		}
	}
}
