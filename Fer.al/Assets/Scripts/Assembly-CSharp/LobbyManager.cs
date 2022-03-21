using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : SingletonManagerBase<LobbyManager>
{
	public enum ELobbyType
	{
		MINIGAME_JOIN = 1,
		QUEST_ROOM_JOIN
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestServerLobbyCreate>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ELobbyType inType;

		public string inAssocDefID;

		public LobbyManager <>4__this;

		public Action onCompleteCallback;

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
	private struct <RequestServerLobbyJoin>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ELobbyType inType;

		public string inHostUUID;

		public LobbyManager <>4__this;

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
	private struct <RequestServerLobbyLeave>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ELobbyType inType;

		public LobbyManager <>4__this;

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
	private struct <RequestServerLobbyStart>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ELobbyType inType;

		public LobbyManager <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void SceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode)
	{
	}

	public Coroutine LobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_LobbyCreate>d__5))]
	private IEnumerator _LobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerLobbyCreate>d__6))]
	private void RequestServerLobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback)
	{
	}

	public Coroutine LobbyJoin(ELobbyType inType, string inHostUUID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_LobbyJoin>d__8))]
	private IEnumerator _LobbyJoin(ELobbyType inType, string inHostUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerLobbyJoin>d__9))]
	private void RequestServerLobbyJoin(ELobbyType inType, string inHostUUID)
	{
	}

	public Coroutine LobbyLeave(ELobbyType inType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_LobbyLeave>d__11))]
	private IEnumerator _LobbyLeave(ELobbyType inType)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerLobbyLeave>d__12))]
	private void RequestServerLobbyLeave(ELobbyType inType)
	{
	}

	public Coroutine LobbyStart(ELobbyType inType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_LobbyStart>d__14))]
	private IEnumerator _LobbyStart(ELobbyType inType)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerLobbyStart>d__15))]
	private void RequestServerLobbyStart(ELobbyType inType)
	{
	}

	private void OnLobbyCreateSuccessResponse(RequestLobbyCreateSuccessMessage inMessage)
	{
	}

	private void OnLobbyCreateFailureResponse(RequestLobbyCreateFailedMessage inMessage)
	{
	}

	private void OnLobbyJoinSuccessResponse(RequestLobbyJoinSuccessMessage inMessage)
	{
	}

	private void OnLobbyJoinFailureResponse(RequestLobbyJoinFailedMessage inMessage)
	{
	}

	private void OnLobbyLeaveSuccessResponse(RequestLobbyLeaveSuccessMessage inMessage)
	{
	}

	private void OnLobbyLeaveFailureResponse(RequestLobbyLeaveFailedMessage inMessage)
	{
	}

	private void OnLobbyStartFailureResponse(RequestLobbyStartFailedMessage inMessage)
	{
	}

	internal static void HandleLobbyJoinResponse(XtReader data)
	{
	}
}
