using UnityEngine;
namespace FPS
{
	public class UIInterface
	{
		private FlashLightUIText _flashlightUIText;

		public FlashLightUIText LightUIText
		{
			get
			{
				if (!_flashlightUIText)
					_flashlightUIText = MonoBehaviour.FindObjectOfType<FlashLightUIText>();
				return _flashlightUIText;
			}
		}

		private WeaponUIText _weaponUIText;

		public WeaponUIText WeaponUIText
		{
			get
			{
				if(!_weaponUIText)
					_weaponUIText = MonoBehaviour.FindObjectOfType<WeaponUIText>();
				return _weaponUIText;
			}
		}
	}
}
