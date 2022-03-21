using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class RelationshipOnlineStatusXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestOnlineStatus>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<OnlineStatusResponse> <>t__builder;

		public string userId;

		private TaskAwaiter<OnlineStatusResponse> <>u__1;

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
	private struct <RequestJumpToRoom>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string targetUserUUID;

		public List<string> inEventNames;

		public List<Action<IMessage>> inCallbacks;

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
	private struct <RequestFindPlayerUUID>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<RelationshipFollowingFindPlayerUUIDResponse> <>t__builder;

		public string targetUserDisplayName;

		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[MessageRoute(XtCmd.RelationshipFollowingList, QueueMessageMode.Never)]
	private static void HandleRelationshipFollowerList(RelationshipFollowingListResponse response)
	{
	}

	[MessageRoute(XtCmd.RelationshipFollowOnlineStatusUpdate, QueueMessageMode.Never)]
	private static void HandleRelationshipFollowOnlineStatusUpdate(RelationshipFollowOnlineStatusUpdateResponse response)
	{
	}

	[AsyncStateMachine(typeof(<RequestOnlineStatus>d__2))]
	[MessageSender(XtCmd.RelationshipOnlineStatus, false)]
	public static Task<OnlineStatusResponse> RequestOnlineStatus(string userId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestJumpToRoom>d__3))]
	[MessageSender(XtCmd.RelationshipFollowerJumpToRoom, false)]
	public static Task RequestJumpToRoom(string targetUserUUID, List<string> inEventNames, List<Action<IMessage>> inCallbacks)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestFindPlayerUUID>d__4))]
	[MessageSender(XtCmd.RelationshipFollowingFindPlayerUUID, false)]
	public static Task<RelationshipFollowingFindPlayerUUIDResponse> RequestFindPlayerUUID(string targetUserDisplayName)
	{
		return null;
	}

	[MessageRoute(XtCmd.RelationshipFollowingFindPlayerUUID, QueueMessageMode.Never)]
	public static void HandleRelationshipFollowingFindPlayerUUID(RelationshipFollowingFindPlayerUUIDResponse response)
	{
	}
}
