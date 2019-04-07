﻿namespace FPS
{
	public sealed class Bullet : Ammunition
	{
		private void OnCollisionEnter(UnityEngine.Collision collision)
		{
			var tempObj = collision.gameObject.GetComponent<ISetDamage>();
			tempObj?.SetDamage(new InfoCollision(_curDamage, collision.contacts[0], collision.transform, Rigidbody.velocity));
			Destroy(gameObject);
		}
	}
}