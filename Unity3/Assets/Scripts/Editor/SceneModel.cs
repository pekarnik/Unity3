using UnityEngine;

namespace FPS.Editor
{
	public class SceneModel:MonoBehaviour
	{
		private GameObject _prefab;

		public void LoadLvl(string path)
		{
			var obj = SerializableToXML.Load(path);

			foreach(var o in obj)
			{
				var tempObj = Instantiate(_prefab, o.Pos, o.Rot);
				tempObj.name = o.Name;
			}
		}
	}
}
