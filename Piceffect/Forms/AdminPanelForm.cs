using System;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class AdminPanelForm : Form
	{
		public AdminPanelForm()
		{
			InitializeComponent();
		}

		private void LoadAccounts()
		{
			int index = 0;
			if (Accounts.SelectedRows.Count > 0) index = Accounts.SelectedRows[0].Index;
			Accounts.DataSource = DB.GetUsers();
			Accounts.Columns.Remove("is_admin");
			Accounts.Columns.Remove("is_blocked");
			if (Accounts.Rows.Count > index) Accounts.CurrentCell = Accounts.Rows[index].Cells[0];
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{
			LoadAccounts();
		}

		private void Accounts_SelectionChanged(object sender, EventArgs e)
		{
			if (Accounts.SelectedRows.Count != 0 && int.Parse(Accounts.SelectedRows[0].Cells["ID"].Value.ToString()) != Session.ID)
			{
				ActionPanel.Enabled = true;
				bool blocked = (bool) Accounts.SelectedRows[0].Cells["Blocked"].Value;
				BlockUser.Text = blocked ? "Unblock" : "Block";
				bool admin = (bool) Accounts.SelectedRows[0].Cells["Admin"].Value;
				SetAsAdmin.Text = "Set As " + (admin ? "User" : "Admin");
			}
			else ActionPanel.Enabled = false;
		}

		private void SetAsAdmin_Click(object sender, EventArgs e)
		{
			bool admin = (bool)Accounts.SelectedRows[0].Cells["Admin"].Value;
			int id = int.Parse(Accounts.SelectedRows[0].Cells["ID"].Value.ToString());
			if (!DB.UpdateUser("is_admin", admin ? 0 : 1, id)) Message.Warning(DB.Status, Text);
			else
			{
				LoadAccounts();
				Message.Info("Account privileges have been successfully changed!", Text);
			}
		}

		private void BlockUser_Click(object sender, EventArgs e)
		{
			bool blocked = (bool)Accounts.SelectedRows[0].Cells["Blocked"].Value;
			int id = int.Parse(Accounts.SelectedRows[0].Cells["ID"].Value.ToString());
			if (!DB.UpdateUser("is_blocked", blocked ? 0 : 1, id)) Message.Warning(DB.Status, Text);
			else
			{
				LoadAccounts();
				Message.Info("Account successfully " + (blocked ? "unblocked" : "blocked") + "!", Text);
			}
		}

		private void DeleteUser_Click(object sender, EventArgs e)
		{
			int id = int.Parse(Accounts.SelectedRows[0].Cells["ID"].Value.ToString());
			if (!DB.DeleteUser(id)) Message.Warning(DB.Status, Text);
			else
			{
				LoadAccounts();
				Message.Info("Account successfully deleted!", Text);
			}
		}
	}
}
