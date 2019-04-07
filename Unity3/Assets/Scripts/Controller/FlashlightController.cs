using UnityEngine;
namespace FPS
{
	public class FlashlightController : BaseController
	{
		private Flashlight _flashLight;

		public FlashlightController()
		{
			_flashLight = Main.Instance.ObjectManager.Flashlight;
		}
		public override void OnUpdate()
		{
			if (!IsActive)
			{
				_flashLight.RechargeBattery();
				return;
			}

			if (_flashLight == null) return;
			_flashLight.Rotation();
			if (_flashLight.EditBatteryCharge())
			{
				UIInterface.LightUIText.Text = _flashLight.BatteryChargeCurrent;
			}
			else
			{
				Off();
			}
		}

		public override void On()
		{
			if (IsActive) return;
			base.On();
			_flashLight.Switch(true);
			UIInterface.LightUIText.SetActive(true);
		}

		public sealed override void Off()
		{
			if (!IsActive) return;
			base.Off();
			_flashLight.Switch(false);
			
		}
	}
}
