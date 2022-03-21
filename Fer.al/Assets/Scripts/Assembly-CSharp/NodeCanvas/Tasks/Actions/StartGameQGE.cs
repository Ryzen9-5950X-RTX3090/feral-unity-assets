using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Prototype.QuickGames;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("Start a Quick Game Event")]
	public class StartGameQGE : ActionTask<Transform>
	{
		public string quickGameBundleId;

		protected QuickGamesBase _quickGame;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		protected virtual void InitializeQuickGame(QuickGamesBase inQuickGame)
		{
		}

		public void QuickGameReturn(QuickGamesBase.EQuickGamesResults qgeResults, QuickGamesBase.EQuickGameRewardTier qgeRewardTier, Dictionary<string, object> customResults)
		{
		}
	}
}
