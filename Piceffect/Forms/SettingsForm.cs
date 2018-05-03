using System.Windows.Forms;

namespace Piceffect
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, System.EventArgs e)
		{
			JournalBox.Text = Config.Journal;
			DatabaseBox.Text = Config.DataBase;
			LogBox.Text = Config.Log;
		}

		private void JournalButton_Click(object sender, System.EventArgs e)
		{
			if (SelectFolder.ShowDialog() == DialogResult.OK)
				JournalBox.Text = SelectFolder.SelectedPath + "\\Journal.txt";
		}

		private void SaveSettings_Click(object sender, System.EventArgs e)
		{
			Config.Journal = JournalBox.Text;
			Config.DataBase = DatabaseBox.Text;
			Config.Log = LogBox.Text;
			Message.Info("Settings was saved!", Text);
		}

		private void DatabaseButton_Click(object sender, System.EventArgs e)
		{
			if (SelectFolder.ShowDialog() == DialogResult.OK)
				DatabaseBox.Text = SelectFolder.SelectedPath + "\\Database.txt";
		}

		private void LogButton_Click(object sender, System.EventArgs e)
		{
			if (SelectFolder.ShowDialog() == DialogResult.OK)
				LogBox.Text = SelectFolder.SelectedPath + "\\Log.txt";
		}

		private void JournalRoot_Click(object sender, System.EventArgs e)
		{
			JournalBox.Text = "Journal.txt";
		}

		private void DatabaseRoot_Click(object sender, System.EventArgs e)
		{
			DatabaseBox.Text = "Database.txt";
		}

		private void LogRoot_Click(object sender, System.EventArgs e)
		{
			LogBox.Text = "Log.txt";
		}
	}
}
