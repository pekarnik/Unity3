using UnityEngine;

namespace FPS
{
	public class PlayerHand : BaseObjectScene
	{
		[SerializeField] Transform _playerHand;
		public Vector3 distance;
		public RaycastHit GetRaycastHit()
		{
			Rotation();
			Ray ray = new Ray(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Camera.main.ScreenToWorldPoint(Input.mousePosition) + transform.position);
			RaycastHit hitInfo = new RaycastHit();
			Physics.Raycast(ray, out hitInfo);
			return hitInfo;
		}
		

		public void Rotation()
		{
			transform.position = _playerHand.position;
			transform.rotation = _playerHand.rotation;
		}		
	}
}
