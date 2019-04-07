using UnityEditor;
using UnityEngine;

namespace FPS.Editor
{
	public class TestEditor:UnityEditor.Editor
	{

		private void OnSceneGUI()
		{
			Test testTarget = (Test)target;
			if(Event.current.button==0&&Event.current.type==EventType.MouseDown)
			{
				RaycastHit hit;
				Ray ray = Camera.current.ScreenPointToRay(new
					Vector3(Event.current.mousePosition.x,
					SceneView.currentDrawingSceneView.camera.pixelHeight -
					Event.current.mousePosition.y));
				if(Physics.Raycast(ray,out hit))
				{
					testTarget.InstantiateObj(hit.point);
				}
			}
		}
	}
}
