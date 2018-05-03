using System.IO;
using System.Xml;

namespace Piceffect
{
	static class Config
	{
		public static string DataBase = "Database.sqlite";
		public static string Journal = "Journal.txt";
		public static string Log = "Log.txt";

		public static void Load()
		{
			string file = "Config.xml";
			if (File.Exists(file))
			{
				XmlReader reader = XmlReader.Create(file);
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element)
					{
						string attribute = reader.GetAttribute("path");
						if (attribute != null)
						{
							if (reader.Name == "database") DataBase = attribute;
							if (reader.Name == "journal") Journal = attribute;
							if (reader.Name == "log") Log = attribute;
						}
					}
				}
				reader.Close();
			}
			else
			{
				XmlWriterSettings settings = new XmlWriterSettings();
				settings.Indent = true;
				settings.IndentChars = "\t";
				XmlWriter writer = XmlWriter.Create(file, settings);
				writer.WriteStartDocument();
				writer.WriteStartElement("config");
				writer.WriteStartElement("database");
				writer.WriteAttributeString("path", DataBase);
				writer.WriteEndElement();
				writer.WriteStartElement("journal");
				writer.WriteAttributeString("path", Journal);
				writer.WriteEndElement();
				writer.WriteStartElement("log");
				writer.WriteAttributeString("path", Log);
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
				writer.Close();
			}
		}
	}
}
