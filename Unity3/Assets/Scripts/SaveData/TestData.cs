using UnityEngine;

namespace FPS.Data
{
	public class TestData:MonoBehaviour
	{
		private DataManager _data = new DataManager();
		private void Start()
		{
			var path = Application.dataPath;
			_data.SetData<JsonData>();
			_data?.SetOptions(path);

			var player = new Player
			{
				Name = "Andrey",
				Hp = 100,
				IsVisible = true
			};
			_data?.Save(player);
			var newPlayer = _data?.Load();

			Debug.Log(newPlayer);
		}
	}
}
