using UnityEngine;
using World_Challenge.Casual_Game;

namespace World_Challenge.Casual_Game_Table
{
	public class CasualGameTable : WorldChallenge
	{
		private enum ETableState
		{
			WAITING,
			GAMESELECTED,
			TUTORIAL_ASK,
			TUTORIAL_SHOW,
			PLAYING,
			RESULTS
		}

		[Header("Casual Game Table")]
		public Transform tableCenter;

		public CasualGame casualGamePrefab;

		private CasualGame _casualGame;

		private ETableState _tableState;

		public override void MStart()
		{
		}

		internal override void DialogNext()
		{
		}

		internal override void OptionSelected(int inIdx)
		{
		}

		protected override void StartChallenge()
		{
		}

		internal void GameReturn(CasualGame.EGamesResults inGamesResults)
		{
		}

		internal override void InitializeGame()
		{
		}

		internal override void StartGame()
		{
		}

		internal override void ResetGame()
		{
		}

		internal override void EndGame()
		{
		}
	}
}
