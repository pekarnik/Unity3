using UnityEngine;
namespace FPS
{
	public class LookAtThisObject : BaseObjectScene, ILook
	{	
		private Color _color;
		private InfoObject obj;
		protected override void Awake()
		{
			base.Awake();
			_color = Color;
			obj =new InfoObject( ObjectType.LookableObject);
		}
		public void LookAt(InfoObject obj)
		{
			Color = Color.red;
		}
		public void DontLookAt(InfoObject obj)
		{
			Color = _color;
		}
		public bool CheckLookAt()
		{
			if (Main.Instance.PlayerHandController.
				PlayerHand.GetRaycastHit().transform?.GetComponent<LookAtThisObject>())
			{

				LookAt(obj);
				return true;
			}
			DontLookAt(obj);
			return false;
		}
	}
}
