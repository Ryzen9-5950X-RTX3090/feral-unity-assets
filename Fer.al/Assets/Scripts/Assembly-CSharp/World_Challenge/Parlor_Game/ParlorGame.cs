using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Parlor_Table;

namespace World_Challenge.Parlor_Game
{
	public class ParlorGame : ManagedBehaviour
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

		[Header("Parlor Game")]
		public Transform hUDInstructions;

		public Transform cameraPositionOverride;

		public float timeForResults;

		public int wager1;

		public int wager2;

		public int wager3;

		internal ParlorTable parlorTable;

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

		[IteratorStateMachine(typeof(<ShowResults>d__19))]
		public virtual IEnumerator ShowResults()
		{
			return null;
		}

		private void ParlorGameOver()
		{
		}
	}
}
