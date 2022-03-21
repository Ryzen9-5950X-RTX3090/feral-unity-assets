using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class LockPickingLockPickController : MonoBehaviour
	{
		public List<int> lockpickRingPositions;

		public int lockpickOffscreenPosition;

		public int lockpickSuccessPosition;

		public float lockPickSpeed;

		public Image pickImage;

		public GameObject brokenPick;

		private int _currentRingIndex;

		private float _targetPosition;

		private bool _moving;

		private LockPickingController parentController;

		private bool _pickBreakWaiting;

		public void Setup(LockPickingController parent)
		{
		}

		private void SetPickPosition(float inPosX)
		{
		}

		public bool CanMove()
		{
			return default(bool);
		}

		public void Move(bool forward = true)
		{
		}

		public void BreakPick(float inDelay)
		{
		}

		[IteratorStateMachine(typeof(<DoBreakPickFx>d__16))]
		private IEnumerator DoBreakPickFx(float inDelay)
		{
			return null;
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(<Reset>d__18))]
		public IEnumerator Reset(int numRingsInLevel)
		{
			return null;
		}
	}
}
