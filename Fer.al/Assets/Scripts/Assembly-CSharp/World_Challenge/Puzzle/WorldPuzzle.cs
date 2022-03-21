using Cinemachine;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace World_Challenge.Puzzle
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

		internal EPuzzleState puzzleState;

		internal StartPuzzle actionTask_inGame;

		public override void MStart()
		{
		}

		public override void MUpdate()
		{
		}

		internal virtual void InitializePuzzle()
		{
		}

		internal virtual void StartPuzzle()
		{
		}

		internal void QuitPuzzle()
		{
		}

		internal virtual void ResetPuzzle()
		{
		}

		internal virtual void CompletePuzzle()
		{
		}

		internal virtual void FailPuzzle()
		{
		}

		internal virtual void EndPuzzle()
		{
		}

		protected virtual void ClosePuzzle()
		{
		}
	}
}
