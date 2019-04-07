using System;
using UnityEngine;

namespace FPS
{
	public class Aim:MonoBehaviour,ISetDamage
	{
		public event Action OnPointChange;

		private int timeToDestroy = 10;
		public float Hp = 100;
		public float Armor = 100;
		private bool _isDead;
		public void SetDamage(InfoCollision info)
		{
			if (_isDead) return;
			if(Hp>0)
			{
				Hp -= info.Damage/(Armor*UnityEngine.Random.Range(0,10)/10F);
				Armor -= info.Damage;
			}

			if(Hp<=0)
			{
				var tempRigidbody = GetComponent<Rigidbody>();
				if(!tempRigidbody)
				{
					tempRigidbody = gameObject.AddComponent<Rigidbody>();
				}
				tempRigidbody.velocity = info.Dir;
				Destroy(gameObject, timeToDestroy);
				OnPointChange?.Invoke();
				_isDead = true;
			}
		}
	}
}
