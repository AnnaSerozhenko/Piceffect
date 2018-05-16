using System;
using System.IO;
using System.Text;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Data;

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
			{
				string directory = Path.GetDirectoryName(Config.DataBase);
				if (!String.IsNullOrWhiteSpace(directory)) Directory.CreateDirectory(directory);
			}
			SQLiteConnection.CreateFile(Config.DataBase);
			if (CheckConnection()) Register("admin", "admin", true);
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

		public static bool Register(string login, string password, bool admin = false)
		{
			string hash = GetHash(password);
			string registration = DateTime.Now.ToString("dd.MM.yyyy");
			string visit = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
			int is_admin = admin ? 1 : 0;
			command.CommandText = String.Format(
				"INSERT INTO users (login, password, registration, visit, is_admin, is_blocked) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, 0)", 
				login, 
				hash,
				registration,
				visit,
				is_admin
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

		public static bool ChangeAccount(string login, string password)
		{
			string hash = GetHash(password);
			command.CommandText = String.Format(
				"UPDATE users SET login = '{0}', password = '{1}' WHERE id = {2}",
				login,
				hash,
				Session.ID
				);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = reader.RecordsAffected > 0;
				if (!result) Status = "Couldn't change account! Try later.";
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

		public static DataTable GetUsers()
		{
			DataTable data = new DataTable();
			command.CommandText = "SELECT " +
				"id AS ID, " +
				"login AS Login, " +
				"registration AS Registration, " +
				"visit AS Visit, " +
				"is_admin, " +
				"is_blocked " +
				"FROM users";
			try
			{
				connection.Open();
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
				DataSet set = new DataSet();
				adapter.Fill(set);
				data = set.Tables[0];
			}
			catch (Exception exception)
			{
				Log.Append(exception.Message);
				Status = "Произошла ошибка на сервере! Обратитесь к администратору.";
			}
			finally
			{
				connection.Close();
			}
			data.Columns.Add("Admin", typeof(bool), "Convert(is_admin, 'System.Boolean')");
			data.Columns.Add("Blocked", typeof(bool), "Convert(is_blocked, 'System.Boolean')");
			return data;
		}

		public static bool UpdateUser(string field, object value, int id)
		{
			command.CommandText = String.Format(
				"UPDATE users SET {0} = @value WHERE id = {1}",
				field,
				id
				);
			command.Parameters.AddWithValue("@value", value);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = reader.RecordsAffected > 0;
				if (!result) Status = "Couldn't change value! Try later.";
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

		public static bool DeleteUser(int id)
		{
			command.CommandText = String.Format("DELETE FROM users WHERE id = {0}",	id);
			bool result = false;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				result = reader.RecordsAffected > 0;
				if (!result) Status = "Couldn't delete user! Try later.";
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
