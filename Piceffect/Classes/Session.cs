namespace Piceffect
{
	static class Session
	{
		public static int ID { get; private set; }
		public static bool Exist { get; private set; } = false;
		public static bool IsAdmin { get; private set; }
		public static string Login { get; private set; }

		public static void Create(int id, string login, bool isAdmin)
		{
			ID = id;
			Login = login;
			IsAdmin = isAdmin;
			Exist = true;
		}

		public static void Destroy()
		{
			ID = 0;
			Login = "";
			IsAdmin = false;
			Exist = false;
		}
	}
}
