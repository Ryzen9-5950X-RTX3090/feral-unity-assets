using System;
using System.Threading;
using UniRx.Async.Internal;
using UnityEngine;
using UnityEngine.LowLevel;

namespace UniRx.Async
{
	public static class PlayerLoopHelper
	{
		private static int mainThreadId;

		private static SynchronizationContext unitySynchronizationContetext;

		private static ContinuationQueue[] yielders;

		private static PlayerLoopRunner[] runners;

		public static SynchronizationContext UnitySynchronizationContext
		{
			get
			{
				return null;
			}
		}

		public static int MainThreadId
		{
			get
			{
				return default(int);
			}
		}

		private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		public static void Initialize(ref PlayerLoopSystem playerLoop)
		{
		}

		public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action)
		{
		}

		public static void AddContinuation(PlayerLoopTiming timing, Action continuation)
		{
		}
	}
}
