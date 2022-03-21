using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Tasks.Actions;
using Prototype;
using UnityEngine;

namespace World_Challenge
{
	public class WorldChallenge : ManagedBehaviour
	{
		internal enum EChallengeState
		{
			WAITING,
			MOVE2START,
			DO_UPDATE,
			NO_UPDATE,
			WIN,
			LOSE
		}

		[Header("World Challenge")]
		public GameObject encounterHUD;

		public NPCInteract nPCInteract;

		public Transform nPCLocator;

		public Transform playerStartPoint;

		public float toPlayerStartTime;

		public bool replayable;

		[Header("Camera")]
		public CinemachineVirtualCamera virtualCam;

		public Transform cameraTargetPoint;

		public float cameraTargetPointScaler;

		internal EChallengeState challengeState;

		internal StartGame actionTask_inGame;

		internal StartGameQGE actionTask_inGameQGE;

		public override void MStart()
		{
		}

		internal virtual void OptionSelected(int inIdx)
		{
		}

		[IteratorStateMachine(typeof(<MovePlayerToStart>d__13))]
		protected virtual IEnumerator MovePlayerToStart()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AtStartPoint>d__14))]
		protected virtual IEnumerator AtStartPoint()
		{
			return null;
		}

		protected virtual void StartChallenge()
		{
		}

		protected virtual void ChallengeUpdate()
		{
		}

		public override void MUpdate()
		{
		}

		protected virtual void ChallengeOver()
		{
		}

		internal virtual void DialogNext()
		{
		}

		internal virtual void DialogClose()
		{
		}

		protected virtual void CloseChallenge()
		{
		}

		internal virtual void InitializeGame()
		{
		}

		internal virtual void StartGame()
		{
		}

		internal virtual void ResetGame()
		{
		}

		internal virtual void EndGame()
		{
		}
	}
}
