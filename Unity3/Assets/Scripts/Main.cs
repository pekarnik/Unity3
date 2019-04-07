using UnityEngine;

namespace FPS
{
	public class Main:MonoBehaviour
	{
		public FlashlightController FlashlightController { get; private set; }
		public InputController InputController { get; private set; }
		public PlayerController PlayerController { get; private set; }
		public WeaponController WeaponController { get; private set; }
		public ObjectManager ObjectManager { get; private set; }
		public BotController BotController { get; private set; }
		public PlayerHandController PlayerHandController { get; private set; }
		public Transform Player { get; private set; }
		public Transform MainCamera { get; private set; }
		public LookAtThisObjectController LookAtThisObjectController { get; private set; }
		private BaseController[] Controllers;
		public Bot RefBotPrefab;
		public int CountBot;
		public static Main Instance { get; private set; }
		private void Awake()
		{
			Instance = this;

			MainCamera = Camera.main.transform;
			Player = GameObject.FindGameObjectWithTag("Player").transform;

			ObjectManager = new ObjectManager();
			ObjectManager.Start();

			PlayerController = new PlayerController(new UnitMotor(GameObject.FindObjectOfType<CharacterController>().transform));
			PlayerController.On();
			Controllers = new BaseController[7];
			FlashlightController = new FlashlightController();
			InputController = new InputController();
			InputController.On();
			WeaponController = new WeaponController();
			PlayerHandController = new PlayerHandController();
			LookAtThisObjectController = new LookAtThisObjectController();
			BotController = new BotController();

			BotController.On();
			BotController.Init(CountBot);
			Controllers[0] = FlashlightController;
			Controllers[1] = InputController;
			Controllers[2] = PlayerController;
			Controllers[3] = WeaponController;
			Controllers[4] = PlayerHandController;
			Controllers[5] = LookAtThisObjectController;
			Controllers[6] = BotController;

		}

		private void Update()
		{
			for(int i=0;i<Controllers.Length;i++)
			{
				Controllers[i].OnUpdate();
			}
		}
	}
}
