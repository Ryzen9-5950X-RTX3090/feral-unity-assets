using UnityEngine;
using World_Challenge.Parlor_Game;

namespace World_Challenge.Parlor_Table
{
	public class ParlorTable : WorldChallenge
	{
		private enum ETableState
		{
			WAITING,
			GAMESELECTED,
			TUTORIAL_ASK,
			TUTORIAL_SHOW,
			PLACE_WAGER,
			PLAYING,
			RESULTS
		}

		[Header("Parlor Table")]
		public Transform tableCenter;

		[HideInInspector]
		public int wagerIndex;

		[HideInInspector]
		public int gameIndex;

		public ParlorGame[] parlorGames;

		internal ParlorGame _parlorGame;

		private ETableState _tableState;

		internal override void DialogNext()
		{
		}

		internal override void OptionSelected(int inIdx)
		{
		}

		protected override void StartChallenge()
		{
		}

		internal void GameReturn(ParlorGame.EGamesResults inGamesResults)
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
