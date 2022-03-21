using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class GroupTeamXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestGroupTeamCreate>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string questDefId;

		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess;

		public Action<RequestGroupTeamCreateFailedMessage> onFailed;

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
	private struct <SendRequestGroupTeamCreate>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess;

		public Action<RequestGroupTeamCreateFailedMessage> onFailed;

		public string questDefId;

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
	private struct <RequestGroupTeamJoin>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string hostUserUUIDToJoin;

		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess;

		public Action<RequestGroupTeamJoinFailedMessage> onFailed;

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
	private struct <SendRequestGroupTeamJoin>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess;

		public Action<RequestGroupTeamJoinFailedMessage> onFailed;

		public string hostUserUUIDToJoin;

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
	private struct <RequestGroupTeamInvite>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string inUserUUIDToAdd;

		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess;

		public Action<RequestGroupTeamInviteFailedMessage> onFailed;

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
	private struct <SendRequestGroupTeamInvite>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess;

		public Action<RequestGroupTeamInviteFailedMessage> onFailed;

		public string inUserUUIDToAdd;

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
	private struct <RequestAcceptGroupTeamInvitation>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string inGroupCreatorUUID;

		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess;

		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed;

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
	private struct <SendRequestAcceptGroupTeamInvitation>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess;

		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed;

		public string inGroupCreatorUUID;

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
	private struct <RequestRejectGroupTeamInvitation>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string inGroupCreatorUUID;

		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess;

		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed;

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
	private struct <SendRequestRejectGroupTeamInvitation>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess;

		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed;

		public string inGroupCreatorUUID;

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
	private struct <RequestGroupTeamAnnounce>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public LobbyManager.ELobbyType inType;

		public string inAssocDefID;

		public Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess;

		public Action<RequestGroupTeamAnnounceFailedMessage> onFailed;

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
	private struct <SendRequestGroupTeamAnnounce>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess;

		public Action<RequestGroupTeamAnnounceFailedMessage> onFailed;

		public string inType;

		public string inAssocDefID;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestGroupTeamCreate>d__0))]
	internal static Task RequestGroupTeamCreate(string questDefId, [Optional] Action<RequestGroupTeamCreateSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamCreateFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SendRequestGroupTeamCreate>d__1))]
	[MessageSender(XtCmd.GroupTeamCreate, false)]
	private static Task SendRequestGroupTeamCreate(string questDefId, [Optional] Action<RequestGroupTeamCreateSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamCreateFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestGroupTeamJoin>d__2))]
	internal static Task RequestGroupTeamJoin(string hostUserUUIDToJoin, [Optional] Action<RequestGroupTeamJoinSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamJoinFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SendRequestGroupTeamJoin>d__3))]
	[MessageSender(XtCmd.GroupTeamJoin, false)]
	private static Task SendRequestGroupTeamJoin(string hostUserUUIDToJoin, [Optional] Action<RequestGroupTeamJoinSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamJoinFailedMessage> onFailed)
	{
		return null;
	}

	[MessageSender(XtCmd.GroupTeamLeave, false)]
	public static void RequestGroupTeamLeave()
	{
	}

	[AsyncStateMachine(typeof(<RequestGroupTeamInvite>d__5))]
	internal static Task RequestGroupTeamInvite(string inUserUUIDToAdd, [Optional] Action<RequestGroupTeamInviteSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamInviteFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SendRequestGroupTeamInvite>d__6))]
	[MessageSender(XtCmd.GroupTeamInvite, false)]
	private static Task SendRequestGroupTeamInvite(string inUserUUIDToAdd, [Optional] Action<RequestGroupTeamInviteSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamInviteFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestAcceptGroupTeamInvitation>d__7))]
	internal static Task RequestAcceptGroupTeamInvitation(string inGroupCreatorUUID, [Optional] Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess, [Optional] Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SendRequestAcceptGroupTeamInvitation>d__8))]
	[MessageSender(XtCmd.GroupTeamInviteAccept, false)]
	private static Task SendRequestAcceptGroupTeamInvitation(string inGroupCreatorUUID, [Optional] Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess, [Optional] Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestRejectGroupTeamInvitation>d__9))]
	internal static Task RequestRejectGroupTeamInvitation(string inGroupCreatorUUID, [Optional] Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess, [Optional] Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SendRequestRejectGroupTeamInvitation>d__10))]
	[MessageSender(XtCmd.GroupTeamInviteReject, false)]
	private static Task SendRequestRejectGroupTeamInvitation(string inGroupCreatorUUID, [Optional] Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess, [Optional] Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestGroupTeamAnnounce>d__11))]
	internal static Task RequestGroupTeamAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID, [Optional] Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamAnnounceFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SendRequestGroupTeamAnnounce>d__12))]
	[MessageSender(XtCmd.GroupTeamAnnounce, false)]
	private static Task SendRequestGroupTeamAnnounce(string inType, string inAssocDefID, [Optional] Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess, [Optional] Action<RequestGroupTeamAnnounceFailedMessage> onFailed)
	{
		return null;
	}

	internal static void RequestGroupTeamQuest(string inQuestDefID)
	{
	}

	[MessageSender(XtCmd.GroupTeamQuest, false)]
	private static void SendRequestGroupTeamQuest(string inQuestDefID)
	{
	}

	[MessageRoute(XtCmd.GroupTeamCreate, QueueMessageMode.Never)]
	private static void HandleGroupTeamCreate(ReceivedGroupTeamCreateMessage message)
	{
	}

	[MessageRoute(XtCmd.GroupTeamJoin, QueueMessageMode.Never)]
	private static void HandleGroupTeamJoin(ReceivedGroupTeamJoinMessage message)
	{
	}

	[MessageRoute(XtCmd.GroupTeamLeave, QueueMessageMode.Never)]
	private static void HandleGroupTeamLeave(ReceivedGroupTeamLeaveMessage message)
	{
	}

	[MessageRoute(XtCmd.GroupTeamUserJoined, QueueMessageMode.Never)]
	private static void HandleGroupTeamUserJoined(ReceivedGroupTeamUserJoinedMessage message)
	{
	}

	[MessageRoute(XtCmd.GroupTeamUserLeft, QueueMessageMode.Never)]
	private static void HandleGroupTeamUserLeft(ReceivedGroupTeamLeftMessage message)
	{
	}
}
