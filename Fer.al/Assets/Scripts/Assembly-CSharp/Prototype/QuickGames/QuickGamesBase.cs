using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using World_Challenge.Cinder_Encounter;

namespace Prototype.QuickGames
{
	public class QuickGamesBase : ManagedBehaviour
	{
		public class QuickGameReward
		{
			public int embers;

			public string winIngredientDefId;

			public int winIngreientAwardAmmount;

			public string loseIngredientDefId;

			public int loseIngreientAwardAmmount;

			public QuickGameReward()
			{
			}

			public QuickGameReward(List<WinIngredient> inIngredients)
			{
			}

			public void ClearRewards()
			{
			}
		}

		public enum EQuickGamesState
		{
			NONE,
			INTRO,
			PLAYING,
			RESULTS
		}

		public enum EQuickGamesResults
		{
			NONE,
			WIN,
			SURVIVING,
			LOSE
		}

		public enum EQuickGameRewardTier
		{
			NONE,
			BRONZE,
			SILVER,
			GOLD,
			PRIZE,
			CONSOLATION_PRIZE
		}

		[Serializable]
		public class WinIngredient
		{
			public float chanceOfIngredient;

			[RootSelector("Craftable Item", "CraftableItemChartData", false, false)]
			public string defId;
		}

		public static QuickGamesBase instance;

		internal bool giveReward;

		private int _worldEventId;

		public Dictionary<string, object> QuickGameCustomResults;

		internal CinderQGE WorldChallenge;

		internal StartGameQGE NodeActionStartGameQGE;

		[Header("HUD - In Game")]
		public QuickGamesHUD quickGamesHUD;

		public string inGameInstructionsText;

		[Header("Unique per QuickGame")]
		public GameObject HUDElements;

		public float timeToComplete;

		public float timeForResults;

		public float timeForResultsGUI;

		public bool autoDestroyOnGameOver;

		[Header("Quick Game Chart Data")]
		public float chanceOfQuickGame;

		public List<WinIngredient> winIngredients;

		protected float _currentTimeToComplete;

		protected QuickGamesHUD _quickGamesHUD;

		private int _previousDisplayTime;

		public QuickGameReward GameReward
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int worldEventId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public EQuickGamesState QuickGamesState
		{
			[CompilerGenerated]
			get
			{
				return default(EQuickGamesState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EQuickGamesResults QuickGamesResults
		{
			[CompilerGenerated]
			get
			{
				return default(EQuickGamesResults);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EQuickGameRewardTier QuickGameRewardTier
		{
			[CompilerGenerated]
			get
			{
				return default(EQuickGameRewardTier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int DisplayTime
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CraftIngredient Ingredient
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HarvestPoint HarvestPoint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void UAwake()
		{
		}

		public override void MOnEnable()
		{
		}

		public override void MOnDisable()
		{
		}

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__58))]
		public virtual IEnumerator ShowIntro()
		{
			return null;
		}

		public virtual void QuickGameUpdate()
		{
		}

		public override void MUpdate()
		{
		}

		public void QuickGameResults()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__62))]
		public virtual IEnumerator ShowResults()
		{
			return null;
		}

		private void QuickGameOver()
		{
		}

		protected virtual QuickGameReward InitReward()
		{
			return null;
		}

		public Vector3 ScreenToWorld(Vector3 screenCoordinate)
		{
			return default(Vector3);
		}

		public Vector3 ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint)
		{
			return default(Vector3);
		}
	}
}
