using System;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class MainForm : Form
	{
		private bool Exit = true;

		public MainForm()
		{
			InitializeComponent();
            CorrectionType.SelectedIndex = 0;
            Effect.SelectedIndex = 0;
		}

		private void OpenMI_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Open");
		}

		private void SaveMI_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Save");
		}

		private void AdminPanelMI_Click(object sender, EventArgs e)
		{
			AdminPanelForm adminPanel = new AdminPanelForm();
			adminPanel.ShowDialog();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsForm settings = new SettingsForm();
			settings.ShowDialog();
		}

        private void Main_Load(object sender, EventArgs e)
        {

        }

		private void LogoutMI_Click(object sender, EventArgs e)
		{
			Session.Destroy();
			Owner.Show();
			Exit = false;
			Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Exit) Application.Exit();
		}
	}
}
