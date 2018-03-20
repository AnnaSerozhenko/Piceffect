using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Piceffect
{
	public partial class Login : Form
	{
		private string dbFileName = "Database.sqlite";
		private SQLiteConnection dbConnection;
		private SQLiteCommand sqlCommand;

		public Login()
		{
			InitializeComponent();
			if (!File.Exists(dbFileName))
				SQLiteConnection.CreateFile(dbFileName);
			try
			{
				dbConnection = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
				dbConnection.Open();
				sqlCommand = dbConnection.CreateCommand();
				sqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS Accounts (id INTEGER PRIMARY KEY AUTOINCREMENT, login TEXT, password TEXT)";
				sqlCommand.ExecuteNonQuery();
			}
			catch (SQLiteException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}

		}

		private void SignIn_Click(object sender, EventArgs e)
		{
			Main main = new Main();
			main.ShowDialog();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
