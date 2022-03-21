using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Server;

[MessageRouteHandler]
public static class NodeHopXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <doNodeHopGo>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string newIssIP;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static void RequestDrainNodeHop()
	{
	}

	[MessageRoute(XtCmd.NodeHopDrainGo, QueueMessageMode.Never)]
	public static void HandleNodeHopDrainGo(NodeHopDrainGoResponse nhdgResponse)
	{
	}

	public static void NodeHopGo(string newIssIP)
	{
	}

	[AsyncStateMachine(typeof(<doNodeHopGo>d__3))]
	private static void doNodeHopGo(string newIssIP)
	{
	}
}
