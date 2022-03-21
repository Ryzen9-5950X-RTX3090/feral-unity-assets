using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Server;
using WW.Debug;

public class XPXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DebugButtonXPUpdate>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

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
	private struct <DebugButtonXPGive>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[MessageSender(XtCmd.XPUpdateDEBUG, false)]
	public static void RequestXPUpdateDEBUG()
	{
	}

	[MessageSender(XtCmd.XPGiveDEBUG, false)]
	public static void RequestXPGiveDEBUG()
	{
	}

	[MessageRoute(XtCmd.XPUpdate, QueueMessageMode.Never)]
	private static void HandleXPUpdateMessage(XPUpdateServerMessage message)
	{
	}

	[AsyncStateMachine(typeof(<DebugButtonXPUpdate>d__3))]
	[DebugButton("Request XP Update", "XP", true, true)]
	public static void DebugButtonXPUpdate()
	{
	}

	[AsyncStateMachine(typeof(<DebugButtonXPGive>d__4))]
	[DebugButton("Request XP Give", "XP", true, true)]
	public static void DebugButtonXPGive()
	{
	}
}
