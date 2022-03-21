using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public static class QRoutineExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <StartQRoutineAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<QRoutine> <>t__builder;

		public GameObject inGameObject;

		public IEnumerator inRoutine;

		public Action<QRoutine> inFinishedAction;

		public Action<QRoutine> inCanceledAction;

		private QRoutine <qRoutine>5__2;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <StartQRoutineAsync>d__4<T> : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

		public GameObject inGameObject;

		public IEnumerator inRoutine;

		public Action<QRoutine> inFinishedAction;

		public Action<QRoutine> inCanceledAction;

		private QRoutine<T> <qRoutine>5__2;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static bool IsValid(this QRoutineGroup inGroup)
	{
		return default(bool);
	}

	public static QRoutine StartQRoutine(this GameObject inGameObject, IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<StartQRoutineAsync>d__2))]
	public static Task<QRoutine> StartQRoutineAsync(this GameObject inGameObject, IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public static QRoutine<T> StartQRoutine<T>(this GameObject inGameObject, IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<StartQRoutineAsync>d__4<>))]
	public static Task<T> StartQRoutineAsync<T>(this GameObject inGameObject, IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<StartQRoutineAndWait>d__5))]
	public static IEnumerator StartQRoutineAndWait(this GameObject inGameObject, IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public static QRoutine OnFinish(this QRoutine inQRoutine, [Optional] Action<QRoutine> inFinishedAction)
	{
		return null;
	}

	public static QRoutine OnCancel(this QRoutine inQRoutine, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}
}
