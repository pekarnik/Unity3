using System.Threading;
using UnityEditor;
using UnityEngine;

namespace FPS.Editor
{
	public class TestFlags:MonoBehaviour
	{
		public float count = 42;
		public int step = 2;
		private void Start()
		{
			for(var i=0;i<count;i++)
			{
				EditorUtility.DisplayProgressBar("Загрузка", $"проценты {i}",
					i / count);
					Thread.Sleep(step * 100);
			}
			EditorUtility.ClearProgressBar();

			var isPressed = EditorUtility.DisplayDialog("Вопрос", "Рили?", "Ага", "Ноуп");
			if(isPressed)
			{
				EditorApplication.isPaused = true;
			}
		}
	}
}
