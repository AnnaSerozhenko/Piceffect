using System;
using System.IO;

namespace Piceffect
{
	static class Journal
	{
		public static void Append(string line)
		{
			FileStream stream = new FileStream(Config.Journal, FileMode.Append);
			StreamWriter writer = new StreamWriter(stream);
			writer.WriteLine(DateTime.Now.ToString("[yyyy.MM.dd hh:mm:ss]") + ": " + line);
			writer.Close();
			stream.Close();
		}
	}
}
