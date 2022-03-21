using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class AsyncUtils
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <WaitFor>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		public Predicate<bool> condition;

		public double timeoutSeconds;

		private <>c__DisplayClass0_0 <>8__1;

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
	private struct <WaitForMessage>d__1<T> : IAsyncStateMachine where T : class, IMessage
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

		public double timeoutSeconds;

		private <>c__DisplayClass1_0<T> <>8__1;

		private Action<T> <action>5__2;

		private TaskAwaiter<bool> <>u__1;

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
	private struct <WaitFor>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		public Predicate<bool> condition;

		public double timeoutSeconds;

		private TaskAwaiter<bool> <>u__1;

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
	private struct <WaitForMessage>d__3<T> : IAsyncStateMachine where T : class, IMessage
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

		public double timeoutSeconds;

		private TaskAwaiter<T> <>u__1;

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
	private struct <FireAndForget>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public Task task;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<WaitFor>d__0))]
	private static Task<bool> WaitFor(Predicate<bool> condition, double timeoutSeconds)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<WaitForMessage>d__1<>))]
	private static Task<T> WaitForMessage<T>(double timeoutSeconds) where T : class, IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<WaitFor>d__2))]
	public static Task<bool> WaitFor(this MonoBehaviour me, Predicate<bool> condition, double timeoutSeconds)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<WaitForMessage>d__3<>))]
	public static Task<T> WaitForMessage<T>(this MonoBehaviour me, double timeoutSeconds) where T : class, IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<FireAndForget>d__4))]
	public static void FireAndForget(this Task task)
	{
	}
}
