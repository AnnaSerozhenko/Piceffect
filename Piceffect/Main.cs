using System;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class Main : Form
	{
		public Main()
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
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.ShowDialog();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.ShowDialog();
		}

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
