using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class QuestXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestQuestOpen>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public QuestDefComponent inQuestDef;

		public Action<RequestQuestOpenSuccessMessage> onSuccess;

		public Action<RequestQuestGenericFailedMessage> onFailed;

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
	private struct <RequestQuestOpen>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestQuestOpenSuccessMessage> onSuccess;

		public Action<RequestQuestGenericFailedMessage> onFailed;

		public string inQuestDefID;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestQuestOpen>d__0))]
	internal static Task RequestQuestOpen(QuestDefComponent inQuestDef, [Optional] Action<RequestQuestOpenSuccessMessage> onSuccess, [Optional] Action<RequestQuestGenericFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestQuestOpen>d__1))]
	[MessageSender(XtCmd.QuestOpen, false)]
	private static Task RequestQuestOpen(string inQuestDefID, [Optional] Action<RequestQuestOpenSuccessMessage> onSuccess, [Optional] Action<RequestQuestGenericFailedMessage> onFailed)
	{
		return null;
	}

	[MessageRoute(XtCmd.QuestCommand, QueueMessageMode.Never)]
	private static void HandleQuestCommand(RecievedQuestCommandMessage message)
	{
	}

	[MessageRoute(XtCmd.QuestCommandVT, QueueMessageMode.Never)]
	private static void HandleQuestCommandVT(RecievedQuestCommandMessage message)
	{
	}

	[MessageRoute(XtCmd.QuestStart, QueueMessageMode.Never)]
	private static void HandleQuestStart(RecievedQuestStartMessage message)
	{
	}

	[MessageRoute(XtCmd.QuestOpen, QueueMessageMode.Never)]
	private static void HandleQuestOpen(RecievedQuestOpenMessage message)
	{
	}

	[MessageRoute(XtCmd.QuestGenericLinearQuestComplete, QueueMessageMode.Never)]
	private static void HandleQuestGenericLinearQuestComplete(RecievedQuestGenericLinearQuestCompleteMessage message)
	{
	}

	[MessageRoute(XtCmd.QuestSetupGroupObjects, QueueMessageMode.Never)]
	private static void HandleQuestSetupGroupObjects(RecievedQuestSetupGroupObjects message)
	{
	}
}
