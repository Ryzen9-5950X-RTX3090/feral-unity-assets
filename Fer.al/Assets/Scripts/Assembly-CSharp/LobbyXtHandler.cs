using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class LobbyXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestLobbyCreate>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public LobbyManager.ELobbyType inType;

		public string inAssocDefID;

		public Action<RequestLobbyJoinSuccessMessage> onSuccess;

		public Action<RequestLobbyCreateFailedMessage> onFailed;

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
	private struct <RequestLobbyCreate>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestLobbyJoinSuccessMessage> onSuccess;

		public Action<RequestLobbyCreateFailedMessage> onFailed;

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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestLobbyJoin>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public LobbyManager.ELobbyType inType;

		public string inHostUUID;

		public Action<RequestLobbyJoinSuccessMessage> onSuccess;

		public Action<RequestLobbyJoinFailedMessage> onFailed;

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
	private struct <RequestLobbyJoin>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestLobbyJoinSuccessMessage> onSuccess;

		public Action<RequestLobbyJoinFailedMessage> onFailed;

		public string inHostUUID;

		public string inType;

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
	private struct <RequestLobbyLeave>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public LobbyManager.ELobbyType inType;

		public Action<RequestLobbyLeaveSuccessMessage> onSuccess;

		public Action<RequestLobbyLeaveFailedMessage> onFailed;

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
	private struct <RequestLobbyLeave>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestLobbyLeaveSuccessMessage> onSuccess;

		public Action<RequestLobbyLeaveFailedMessage> onFailed;

		public string inType;

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
	private struct <RequestLobbyStart>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public LobbyManager.ELobbyType inType;

		public Action<RequestLobbyStartSuccessMessage> onSuccess;

		public Action<RequestLobbyStartFailedMessage> onFailed;

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
	private struct <RequestLobbyStart>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<RequestLobbyStartSuccessMessage> onSuccess;

		public Action<RequestLobbyStartFailedMessage> onFailed;

		public string inType;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestLobbyCreate>d__0))]
	internal static Task RequestLobbyCreate(LobbyManager.ELobbyType inType, string inAssocDefID, [Optional] Action<RequestLobbyJoinSuccessMessage> onSuccess, [Optional] Action<RequestLobbyCreateFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyCreate>d__1))]
	[MessageSender(XtCmd.LobbyCreate, false)]
	private static Task RequestLobbyCreate(string inType, string inAssocDefID, [Optional] Action<RequestLobbyJoinSuccessMessage> onSuccess, [Optional] Action<RequestLobbyCreateFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyJoin>d__2))]
	internal static Task RequestLobbyJoin(LobbyManager.ELobbyType inType, string inHostUUID, [Optional] Action<RequestLobbyJoinSuccessMessage> onSuccess, [Optional] Action<RequestLobbyJoinFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyJoin>d__3))]
	[MessageSender(XtCmd.LobbyJoin, false)]
	private static Task RequestLobbyJoin(string inType, string inHostUUID, [Optional] Action<RequestLobbyJoinSuccessMessage> onSuccess, [Optional] Action<RequestLobbyJoinFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyLeave>d__4))]
	internal static Task RequestLobbyLeave(LobbyManager.ELobbyType inType, [Optional] Action<RequestLobbyLeaveSuccessMessage> onSuccess, [Optional] Action<RequestLobbyLeaveFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyLeave>d__5))]
	[MessageSender(XtCmd.LobbyLeave, false)]
	private static Task RequestLobbyLeave(string inType, [Optional] Action<RequestLobbyLeaveSuccessMessage> onSuccess, [Optional] Action<RequestLobbyLeaveFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyStart>d__6))]
	internal static Task RequestLobbyStart(LobbyManager.ELobbyType inType, [Optional] Action<RequestLobbyStartSuccessMessage> onSuccess, [Optional] Action<RequestLobbyStartFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestLobbyStart>d__7))]
	[MessageSender(XtCmd.LobbyStart, false)]
	private static Task RequestLobbyStart(string inType, [Optional] Action<RequestLobbyStartSuccessMessage> onSuccess, [Optional] Action<RequestLobbyStartFailedMessage> onFailed)
	{
		return null;
	}

	[MessageRoute(XtCmd.LobbyJoin, QueueMessageMode.Never)]
	private static void HandleLobbyJoin(ReceivedLobbyJoinMessage message)
	{
	}
}
