using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

namespace World_Challenge.World_Puzzle
{
	public class RingStatuePuzzle : WorldPuzzle
	{
		private enum ERingState
		{
			WRONG,
			RIGHT,
			STARTING
		}

		[Tooltip("Set this to -1 to be able to sove in any direction, and also remeber to use the behavior tree supporting it.")]
		public int winState;

		public CinemachineVirtualCamera virtualEndCam;

		public float endFxTime;

		public float endCamPanTime;

		public float endCamReturnTime;

		public float solvedFXInterval;

		public float eyeGlowTime;

		public Color rightColor;

		public Color wrongColor;

		private Color _startingColor;

		public float impulseIntensity;

		public CinemachineImpulseSource impulseSource;

		public NetworkedObjectInfo ringsNetworkedQuit;

		public NetworkedObjectInfo ringsNetworkedSolve;

		public NetworkedObjectInfo[] networkedRotateDirectionSelect;

		public NetworkedObjectInfo[] networkedRingSelect;

		public NetworkedObjectInfo[] networkedRings;

		public GameObject eyes;

		public Transform[] rings;

		public Transform[] rotateControls;

		public GameObject solvedFX;

		public GameObject[] rotateFX;

		[SerializeField]
		private GameObject _ringAudioPrefab;

		private ParticleSystem[] _rotateFX;

		private bool _endPan;

		private int _defaultLayerMask;

		private readonly ERingState _ringState;

		private int _activeRingIndex;

		private bool _dirLeft;

		private Vector3 _rotateVal;

		private Camera _camera;

		public override void MStart()
		{
		}

		private void NetworkInteract(string inUUID)
		{
		}

		internal override void InitializePuzzle()
		{
		}

		private void WinChq()
		{
		}

		private int getActiveRingWinState()
		{
			return default(int);
		}

		internal void RotateRing()
		{
		}

		internal void PlayPuzzleSolved()
		{
		}

		internal void ResetPuzzleSolved()
		{
		}

		internal void PlayRingFX(int inIndex)
		{
		}

		private void PlaySolvedFX(bool inActive)
		{
		}

		internal override void StartPuzzle(bool inEndPan = false)
		{
		}

		private void PlayAudio(string inChildName)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__44))]
		private IEnumerator ShowResults(bool inWin)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<GlowEyes>d__45))]
		private IEnumerator GlowEyes(bool inActive)
		{
			return null;
		}

		public void LeftControlClicked()
		{
		}

		public void RightControlClicked()
		{
		}

		public void ExitClicked()
		{
		}

		public void SolveIt()
		{
		}

		public override void MUpdate()
		{
		}

		private void UpdateColor(int inIndex, ERingState inRingState)
		{
		}

		private void SetRing(int inIndex, bool inOff)
		{
		}

		private void ChangeRingIndex(int inOnIndex)
		{
		}
	}
}
