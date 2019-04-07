using System.IO;
using System.Xml.Serialization;

namespace FPS.Editor
{
	public static class SerializableToXML
	{
		private static XmlSerializer _formatter;

		static SerializableToXML()
		{
			_formatter = new XmlSerializer(typeof(SerializableGameObject[]));
		}

		public static void Save(SerializableGameObject[]levelses,string path)
		{
			if (levelses == null && !string.IsNullOrEmpty(path)) return;
			if (levelses.Length <= 0) return;
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				_formatter.Serialize(fs, levelses);
			}
		}
		public static SerializableGameObject[] Load(string path)
		{
			SerializableGameObject[] result;
			if(!File.Exists(path))return default(SerializableGameObject[]);
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				result = (SerializableGameObject[])_formatter.Deserialize(fs);
			}
			return result;
		}
	}
}
