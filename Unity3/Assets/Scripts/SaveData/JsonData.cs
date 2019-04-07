using System.IO;
using UnityEngine;
namespace FPS.Data
{
	class JsonData:IData
	{
		private string _path;

		public void Save(Player player)
		{
			var str = JsonUtility.ToJson(player);
			File.WriteAllText(_path, str);
		}

		public Player Load()
		{
			var str = File.ReadAllText(_path);
			return JsonUtility.FromJson<Player>(str);
		}

		public void SetOptions(string path)
		{
			_path = Path.Combine(path, "Data.GeekBrains");
		}

	}
}
