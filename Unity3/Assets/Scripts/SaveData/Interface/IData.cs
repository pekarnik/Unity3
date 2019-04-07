namespace FPS.Data
{
	public interface IData
	{
		void Save(Player player);
		Player Load();
		void SetOptions(string path);
	}
}
