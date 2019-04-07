﻿using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
	public class BotController : BaseController
	{
		public List<Bot> GetBotList { get; } = new List<Bot>();

		public void Init(int countBot)
		{
			for (var index = 0; index < countBot; index++)
			{
				var tempBot = Bot.Instantiate(Main.Instance.RefBotPrefab,
					Patrol.GenericPoint(Main.Instance.Player),
					Quaternion.identity);

				tempBot.Agent.avoidancePriority = index;
				tempBot.Target = Main.Instance.Player; // разных противников
				AddBotToList(tempBot);
			}
		}

		private void AddBotToList(Bot bot)
		{
			if (!GetBotList.Contains(bot))
			{
				GetBotList.Add(bot);
			}
		}
		public void RemoveBotToList(Bot bot)
		{
			if (GetBotList.Contains(bot))
			{
				GetBotList.Remove(bot);
			}
		}

		public override void OnUpdate()
		{
			if (!IsActive) return;
			foreach (var bot in GetBotList)
			{
				bot.Tick();
			}
		}
	}
}