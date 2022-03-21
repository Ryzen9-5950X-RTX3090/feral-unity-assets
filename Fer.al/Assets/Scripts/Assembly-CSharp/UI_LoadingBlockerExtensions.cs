using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class UI_LoadingBlockerExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BlockInputFor>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_LoadingBlocker loadingBlocker;

		public Func<Task> action;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<BlockInputFor>d__0))]
	public static Task BlockInputFor(this UI_LoadingBlocker loadingBlocker, Func<Task> action)
	{
		return null;
	}
}
