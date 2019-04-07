
namespace FPS.Data
{
	public class DataManager
	{
		private IData _data;


		public void SetData<T>() where T : IData, new()
		{
			_data = new T();
		}

		public void Save(Player player)
		{
			_data?.Save(player);
		}
		public Player? Load()
		{
			return _data?.Load();
		}
		public void SetOptions(string path)
		{
			_data?.SetOptions(path);
		}
	}
}
