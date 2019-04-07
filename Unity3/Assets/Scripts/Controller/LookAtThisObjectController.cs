using UnityEngine;
namespace FPS
{
	public class LookAtThisObjectController:BaseController
	{
		public LookAtThisObject Object { get; private set; }

		public LookAtThisObjectController()
		{
			Object = MonoBehaviour.FindObjectOfType<LookAtThisObject>();
		}
		public override void OnUpdate()
		{
			Object.CheckLookAt();
		}
		
	}
}
