using System;
using System.Collections.Generic;
using UnityEngine;

namespace WW.Waiters
{
	public class WaitController : MonoBehaviour
	{
		private static WaitController _instance;

		private List<Waiter> _trackedWaiters;

		[SerializeField]
		private List<Waiter> _pendingWaiters;

		private float _timeLastFrame;

		private static WaitController Instance
		{
			get
			{
				return null;
			}
		}

		public List<Waiter> TrackedWaiters
		{
			get
			{
				return null;
			}
		}

		public List<Waiter> PendingWaiters
		{
			get
			{
				return null;
			}
		}

		public static void Init()
		{
		}

		public static Waiter DoAfter(Func<bool> inCompletionCheck, Action inOnCompleteAction)
		{
			return null;
		}

		public static TimeWaiter DoAfterWait(float inTimeToWait, Action inOnCompleteAction)
		{
			return null;
		}

		public static FrameWaiter DoAfterFrames(int inFramesToWait, Action inOnCompleteAction)
		{
			return null;
		}

		public static List<Waiter> GetWaitersWithID(object inID)
		{
			return null;
		}

		public static void CancelWaitersWithID(object inID)
		{
		}

		public static void CancelAllWaiters()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void CleanupTrackedRoutines()
		{
		}
	}
}
