using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UnityEngine;

namespace UniRx.Async
{
	public static class CancellationTokenSourceExtensions
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <CancelAfterCore>d__2 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask delayTask;

			public CancellationTokenSource cts;

			private UniTask<bool>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public static void CancelAfterSlim(this CancellationTokenSource cts, int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update)
		{
		}

		public static void CancelAfterSlim(this CancellationTokenSource cts, TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update)
		{
		}

		[AsyncStateMachine(typeof(<CancelAfterCore>d__2))]
		private static UniTaskVoid CancelAfterCore(CancellationTokenSource cts, UniTask delayTask)
		{
			return default(UniTaskVoid);
		}

		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, Component component)
		{
		}

		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, GameObject gameObject)
		{
		}
	}
}
