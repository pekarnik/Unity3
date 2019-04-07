using FPS;
using System.IO;
namespace FPS.Data
{
	class StreamData:IData
	{
		private string _path;

		public void Save(Player player)
		{
			using (var sw = new StreamWriter(_path))
			{
				sw.WriteLine(player.Name);
				sw.WriteLine(player.Hp);
				sw.WriteLine(player.IsVisible);
			}
		}
		public Player Load()
		{
			var result = new Player();

			if (!File.Exists(_path)) return result;
			using (StreamReader streamReader = new StreamReader(_path))
			{
				while(!streamReader.EndOfStream)
				{
					result.Name = streamReader.ReadLine();
					result.Hp =
						System.Convert.ToSingle(streamReader.ReadLine());
					result.IsVisible = streamReader.ReadLine().TryBool();
				}
			}
			return result;
		}
		public void SetOptions(string path)
		{
			_path = Path.Combine(path, "Data.Geekbrains");
		}
	}
}
