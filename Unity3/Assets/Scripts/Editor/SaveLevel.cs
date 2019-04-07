using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace FPS.Editor
{
	public class SaveLevel
	{
		private static int _numberScene = 0;

		[MenuItem("Geekbrains/Сохранить уровень",false,1)]
		private static void NewMenuOption()
		{
			string savePath = Path.Combine(Application.dataPath, "Data.xml");
			GameObject[] levelses = GameObject.FindObjectsOfType<GameObject>();
			List<SerializableGameObject> levelsList = new
				List<SerializableGameObject>();
			foreach(var o in levelses)
			{
				var trans = o.transform;
				levelsList.Add(new SerializableGameObject
				{
					Name = o.name,
					Pos = trans.position,
					Rot = trans.rotation,
					Scale = trans.localScale
				});
			}
			SerializableToXML.Save(levelsList.ToArray(), savePath);
		}
	}
}
