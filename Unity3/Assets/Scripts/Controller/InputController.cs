using UnityEngine;

namespace FPS
{
	public class InputController:BaseController
	{
		private KeyCode _codeFlashlight = KeyCode.F;
		private KeyCode _cancel = KeyCode.Escape;
		private KeyCode _reloadClip = KeyCode.R;

		public InputController()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		public override void OnUpdate()
		{
			int _currentWeapon=-1;
			int _lastWeapon = Main.Instance.ObjectManager.Weapons.Length;
			if (!IsActive) return;
			if(Input.GetKeyDown(_codeFlashlight))
			{
				Main.Instance.FlashlightController.Switch();
			}
			if (Input.GetAxis("Mouse ScrollWheel")<0)
			{
				if(_currentWeapon>0)
				{
					_currentWeapon--;

					SelectWeapon(_currentWeapon);
				}
				else
				{
					_currentWeapon = -1;
					Main.Instance.WeaponController.Off();
				}
			}
			if(Input.GetAxis("Mouse ScrollWheel") > 0)
			{
				if (_currentWeapon < _lastWeapon)
				{
					_currentWeapon++;
				}
				else
				{
					_currentWeapon = _lastWeapon - 1;
				}
				SelectWeapon(_currentWeapon);
			}

			if(Input.GetKeyDown(KeyCode.Alpha1))
			{
				_currentWeapon = 0;
				SelectWeapon(_currentWeapon);
			}

			//if(Input.GetKeyDown(_cancel))
			//{
			//	Main.Instance.WeaponController.Off();
			//	Main.Instance.FlashlightController.Off();
			//}
			if(Input.GetKeyDown(_reloadClip))
			{
				Main.Instance.WeaponController.ReloadClip();
			}
		}

		private void SelectWeapon(int i)
		{
			Main.Instance.WeaponController.Off();
			var tempWeapon = Main.Instance.ObjectManager.Weapons[i];
			if (tempWeapon != null) Main.Instance.WeaponController.On(tempWeapon);
		}
	}
}
