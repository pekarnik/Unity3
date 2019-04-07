using UnityEngine;

namespace FPS
{
	public class ObjectManager
	{
		private Weapon[] _weapons = new Weapon[5];

		public Weapon[] Weapons => _weapons;

		public Flashlight Flashlight { get; private set; }

		public void Start()
		{
			_weapons = Main.Instance.Player.GetComponentsInChildren<Weapon>();

			foreach(var weapon in Weapons)
			{
				weapon.IsVisible = false;
			}

			Flashlight = MonoBehaviour.FindObjectOfType<Flashlight>();
			Flashlight.Switch(false);
		}

		//Добавить функционал
	}
}
