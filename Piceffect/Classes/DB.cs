using System;
using System.IO;
using System.Text;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Piceffect
{
	static class DB
	{
		static SQLiteConnection connection;
		static SQLiteCommand command;
		static SQLiteDataReader reader;

		public static string Status { get; private set; }

		public static void CreateDatabase()
		{
			if (!Directory.Exists(Path.GetDirectoryName(Config.DataBase)))
				Directory.CreateDirectory(Path.GetDirectoryName(Config.DataBase));
			SQLiteConnection.CreateFile(Config.DataBase);
		}

		public static bool CheckConnection()
		{
			bool result = false;
			try
			{
				connection = new SQLiteConnection("Data Source=" + Config.DataBase + ";Version=3;");
				connection.Open();
				command = connection.CreateCommand();
				command.CommandText = "CREATE TABLE IF NOT EXISTS \"users\" (\"id\" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,\"login\" TEXT(16),\"password\" TEXT(128),\"registration\" TEXT(10),\"visit\" TEXT(19),\"is_admin\" INTEGER(1),\"is_blocked\" INTEGER(1));";
				command.ExecuteNonQuery();
				connection.Close();
				result = true;
			}
			catch {}
			return result;
		}

		private static string GetHash(string value)
		{
			byte[] data;
			SHA512 sha = new SHA512Managed();
			data = sha.ComputeHash(Encoding.UTF8.GetBytes(value));
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
				builder.Append(data[i].ToString("X2"));
			return builder.ToString();
		}

		public static bool Login(string login, string password)
		{
			string hash = GetHash(password);
			command.CommandText = String.Format("SELECT * FROM users WHERE login = '{0}' AND password = '{1}'", login, hash);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = reader.HasRows;
				if (!result) Status = "Login and password doesn't match!";
				else
				{
					reader.Read();
					int id = int.Parse(reader["id"].ToString());
					bool admin = int.Parse(reader["is_admin"].ToString()) == 1;
					bool blocked = int.Parse(reader["is_blocked"].ToString()) == 1;
					if (blocked)
					{
						Status = "Your account is blocked!";
						result = false;
					}
					else
					{
						Session.Create(id, login, admin);
						string visit = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
						reader.Close();
						command.CommandText = String.Format("UPDATE users SET visit = '{0}' WHERE id = {1}", visit, id);
						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception exception)
			{
				Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
				Status = "An error has occurred on the server! Contact your administrator.";
			}
			finally
			{
				if (reader != null && !reader.IsClosed) reader.Close();
				connection.Close();
			}
			return result;
		}

		public static bool CheckLogin(string login)
		{
			command.CommandText = String.Format("SELECT * FROM users WHERE login = '{0}'", login);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = !reader.HasRows;
				if (!result) Status = "User with the specified login is already registered!";
			}
			catch (Exception exception)
			{
				Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
				Status = "An error has occurred on the server! Contact your administrator.";
			}
			finally
			{
				if (reader != null && !reader.IsClosed) reader.Close();
				connection.Close();
			}
			return result;
		}

		public static bool Register(string login, string password)
		{
			string hash = GetHash(password);
			string registration = DateTime.Now.ToString("dd.MM.yyyy");
			string visit = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
			command.CommandText = String.Format(
				"INSERT INTO users (login, password, registration, visit, is_admin, is_blocked) VALUES ('{0}', '{1}', '{2}', '{3}', 0, 0)", 
				login, 
				hash,
				registration,
				visit
				);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = reader.RecordsAffected > 0;
				if (!result) Status = "Couldn't register! Try later.";
			}
			catch (Exception exception)
			{
				Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
				Status = "An error has occurred on the server! Contact your administrator.";
			}
			finally
			{
				if (reader != null && !reader.IsClosed) reader.Close();
				connection.Close();
			}
			return result;
		}

		public static bool ChangePassword(string password)
		{
			string hash = GetHash(password);
			command.CommandText = String.Format(
				"UPDATE users SET password = '{0}' WHERE id = {1}",
				hash,
				Session.ID
				);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = reader.RecordsAffected > 0;
				if (!result) Status = "Couldn't change password! Try later.";
			}
			catch (Exception exception)
			{
				Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
				Status = "An error has occurred on the server! Contact your administrator.";
			}
			finally
			{
				if (reader != null && !reader.IsClosed) reader.Close();
				connection.Close();
			}
			return result;
		}
	}
}
