using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace World_Challenge
{
	public class WorldPuzzle : ManagedBehaviour
	{
		internal enum EPuzzleState
		{
			PLAYING,
			WIN,
			LOSE
		}

		public CinemachineVirtualCamera virtualCam;

		public GameObject encounterHUD;

		public float showHUDDelay;

		internal EPuzzleState puzzleState;

		internal StartPuzzle actionTask_inGame;

		public override void MStart()
		{
		}

		internal void EndPuzzle()
		{
		}

		internal virtual void InitializePuzzle()
		{
		}

		[IteratorStateMachine(typeof(<ShowHud>d__9))]
		private IEnumerator ShowHud()
		{
			return null;
		}

		internal virtual void StartPuzzle(bool inEndPan = false)
		{
		}

		internal virtual void CompletePuzzle()
		{
		}

		internal void QuitPuzzle()
		{
		}

		internal virtual void FailPuzzle()
		{
		}

		protected virtual void ClosePuzzle()
		{
		}

		internal virtual void ResetPuzzle()
		{
		}
	}
}
