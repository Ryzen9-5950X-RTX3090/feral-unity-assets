using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.Shell_Game
{
	public class ShellGame : ParlorGame
	{
		private enum EShuffleType
		{
			STANDARD,
			PORTAL
		}

		[Header("Shell Game")]
		public Transform shellStart;

		public Transform ballStart;

		public ShellGameShell shell;

		public Transform ball;

		public float dealDelay;

		public float dealSpeed;

		public float xShellSpacing;

		[Header("Standard Shuffling")]
		public float zShuffleOffset;

		public float standardShuffleSpeed;

		public float pauseBetweenShuffles;

		[Header("Portal")]
		public bool usePortalsForDealing;

		public float portalShuffleSpeed;

		public float portalSpinSpeed;

		public float portalDepth;

		public Color[] portalColors;

		[Header("Shell Showing")]
		public float shellShowTime;

		public float shellShowHeight;

		public float shellShowRotate;

		private bool _standardShuffleNext;

		private int _numShellsInPortal;

		private int _shellWithBallIndex;

		private int _clickedShellIndex;

		private Vector3 _shellShowRotate;

		private Vector3 _shellHideRotate;

		private List<ShellGameShell> _shells;

		private List<Vector3> _shellLocations;

		private List<int> _shellIndexes;

		private EShuffleType _shuffleType;

		public override void MStart()
		{
		}

		internal override void Intro()
		{
		}

		[IteratorStateMachine(typeof(<ShowShell>d__31))]
		private IEnumerator ShowShell(int inIndex, bool inShow, float inDT, float inShowTime, float inHalfTime)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Intro_DealAndShuffle>d__32))]
		private IEnumerator Intro_DealAndShuffle()
		{
			return null;
		}

		private void PortalShuffle(bool inPortalsUpOnly, bool inPortalsAllUp)
		{
		}

		[IteratorStateMachine(typeof(<StandardShuffle>d__34))]
		private IEnumerator StandardShuffle()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Intro_PortalDealShell>d__35))]
		private IEnumerator Intro_PortalDealShell(int inIndex)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Intro_StandardDealShell>d__36))]
		private IEnumerator Intro_StandardDealShell(int inIndex)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Results_PortalReturnShell>d__37))]
		private IEnumerator Results_PortalReturnShell(int inIndex)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Results_StandardReturnShell>d__38))]
		private IEnumerator Results_StandardReturnShell(int inIndex)
		{
			return null;
		}

		internal void ShellSelected(ShellGameShell inShellClicked)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__40))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		internal override void ResultsDone()
		{
		}

		[IteratorStateMachine(typeof(<CleanupAndReset>d__42))]
		private IEnumerator CleanupAndReset()
		{
			return null;
		}
	}
}
