using Prototype.QuickGames;
using UnityEngine;

namespace World_Challenge.Cinder_Encounter
{
	public class CinderQGE : WorldChallenge
	{
		private enum EState
		{
			WAITING,
			PLAYING,
			RESULTS
		}

		[Header("Quick Game")]
		public QuickGamesBase quickGame;

		private QuickGamesBase _quickGame;

		private EState _state;

		protected override void StartChallenge()
		{
		}

		internal override void DialogClose()
		{
		}

		internal void QuickGameReturn()
		{
		}

		internal override void StartGame()
		{
		}
	}
}
