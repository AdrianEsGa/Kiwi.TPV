using System.IO;
using System.Xml;

namespace Kiwi.Tpv.App.Util.Configurations
{
    public static class GlobalConfigurationRepository
    {
        private static readonly string FileName = Directory.GetCurrentDirectory() + "\\Config.xml";

        public static void Read()
        {
            if (File.Exists(FileName))
            {
                var reader = XmlReader.Create(FileName);

                while (reader.Read())
                    switch (reader.Name)
                    {
                        case "ConnectionString":
                            Settings.ConnectionString = ValorTagXml(reader);
                            reader.Read();
                            break;

                        case "StationCode":
                            Settings.StationCode = ValorTagXml(reader);
                            reader.Read();
                            break;
                    }
                reader.Close();
            }
        }

        public static void Save()
        {
            Files.Delete(FileName);

            var settings = new XmlWriterSettings {Indent = true};
            var writer = XmlWriter.Create(FileName, settings);

            writer.WriteStartDocument();
            writer.WriteComment("Configuration base, no modify.");
            writer.WriteStartElement("Configuration");

            //Configuracion
            writer.WriteElementString("ConnectionString", Settings.ConnectionString);
            writer.WriteElementString("StationCode", Settings.StationCode);

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }

        private static string ValorTagXml(XmlReader reader)
        {
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.Read();
                if (reader.NodeType == XmlNodeType.Text)
                    return reader.Value;
            }

            return "";
        }
    }

    public static class Files
    {
        public static void Delete(string fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
        }
    }
}