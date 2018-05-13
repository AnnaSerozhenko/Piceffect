using System.IO;
using System.Xml;

namespace Piceffect
{
	public static class Effects
	{
		public static int NonlinearCoefficient = 25;
		public static int Gamma = 25;
		public static int NoiseStrength = 40;
		public static int NoiseSize = 75;
		public static string Path = "Parameters.xml";

		public static void Import()
		{
			if (File.Exists(Path))
			{
				XmlReader reader = XmlReader.Create(Path);
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element)
					{
						string attribute = reader.GetAttribute("value");
						if (attribute != null)
						{
							if (reader.Name == "nonlinear-coefficient") int.TryParse(attribute, out NonlinearCoefficient);
							if (reader.Name == "gamma") int.TryParse(attribute, out Gamma);
							if (reader.Name == "noise-strength") int.TryParse(attribute, out NoiseStrength);
							if (reader.Name == "noise-size") int.TryParse(attribute, out NoiseSize);
						}
					}
				}
				reader.Close();
			}
			else Export();
		}

		public static void Export()
		{
			if (File.Exists(Path)) File.Delete(Path);
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.IndentChars = "\t";
			XmlWriter writer = XmlWriter.Create(Path, settings);
			writer.WriteStartDocument();
			writer.WriteStartElement("parameters");
			writer.WriteStartElement("nonlinear-coefficient");
			writer.WriteAttributeString("value", NonlinearCoefficient.ToString());
			writer.WriteEndElement();
			writer.WriteStartElement("gamma");
			writer.WriteAttributeString("value", Gamma.ToString());
			writer.WriteEndElement();
			writer.WriteStartElement("noise-strength");
			writer.WriteAttributeString("value", NoiseStrength.ToString());
			writer.WriteEndElement();
			writer.WriteStartElement("noise-size");
			writer.WriteAttributeString("value", NoiseSize.ToString());
			writer.WriteEndElement();
			writer.WriteEndElement();
			writer.WriteEndDocument();
			writer.Close();
		}
	}
}
