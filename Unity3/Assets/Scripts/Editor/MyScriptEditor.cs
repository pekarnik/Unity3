using UnityEngine;
using UnityEditor;

namespace FPS.Editor
{
	[CustomEditor(typeof(MyScript))]
	public class MyScriptEditor:UnityEditor.Editor
	{
		bool _isPressButtonOk;
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			MyScript testTarget = (MyScript)target;

			var isPressButton = GUILayout.Button("Создание объектов по кнопке",
				EditorStyles.miniButton);
			if(isPressButton)
			{
				testTarget.CreateObj();
				_isPressButtonOk = true;
			}
			if(_isPressButtonOk)
			{
				EditorGUILayout.HelpBox("Вы нажали кнопку",
					MessageType.Warning);
			}
		}
	}
}
