using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Casual_Game_Table;

namespace World_Challenge.Casual_Game
{
	public class CasualGame : ManagedBehaviour
	{
		internal enum EGamesState
		{
			NONE,
			INITIALIZED,
			PLAYING,
			RESULTS
		}

		public enum EGamesResults
		{
			NONE,
			WIN,
			SURVIVING,
			LOSE
		}

		[Header("Casual Game")]
		public Transform hUDInstructions;

		public Transform cameraPositionOverride;

		public float timeForResults;

		internal CasualGameTable casualGameTable;

		internal EGamesState gamesState;

		public EGamesResults gamesResults
		{
			[CompilerGenerated]
			get
			{
				return default(EGamesResults);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void MStart()
		{
		}

		internal void ShowInstructions(bool inShow)
		{
		}

		internal virtual void ResultsDone()
		{
		}

		internal virtual void Intro()
		{
		}

		public void GameResults()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__16))]
		public virtual IEnumerator ShowResults()
		{
			return null;
		}

		private void CasualGameOver()
		{
		}
	}
}
