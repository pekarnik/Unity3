using UnityEngine;

namespace FPS
{
	public class WeaponController : BaseController
	{
		private Weapon _weapon;
		private int _mouseButton = (int)MouseButton.LeftButton;

		public override void OnUpdate()
		{
			if (!IsActive) return;
			if (Input.GetMouseButton(_mouseButton))
			{
				_weapon.Fire();
				UIInterface.WeaponUIText.ShowData(_weapon.Clip.CountAmmunition, _weapon.CountClip);
			}

			if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2)), out var hit))
			{

			}
		}

		public override void On(BaseObjectScene weapon)
		{
			if (IsActive) return;
			base.On(weapon);

			_weapon = weapon as Weapon;
			if (_weapon == null) return;
			_weapon.IsVisible = true;
			UIInterface.WeaponUIText.SetActive(true);
			UIInterface.WeaponUIText.ShowData(_weapon.Clip.CountAmmunition, _weapon.CountClip);
		}

		public override void Off()
		{
			if (!IsActive) return;
			base.Off();
			_weapon.IsVisible = false;
			_weapon = null;
			UIInterface.WeaponUIText.SetActive(false);
		}

		public void ReloadClip()
		{
			if (_weapon == null) return;
			_weapon.ReloadClip();
			UIInterface.WeaponUIText.ShowData(_weapon.Clip.CountAmmunition, _weapon.CountClip);
		}
	}
}
