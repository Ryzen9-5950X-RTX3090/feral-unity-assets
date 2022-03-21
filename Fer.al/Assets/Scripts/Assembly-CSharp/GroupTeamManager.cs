using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

public class GroupTeamManager
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestServerCreateGroupTeam>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

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
	private struct <RequestServerInviteToGroupTeam>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

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
	private struct <RequestAcceptGroupTeamInvitation>d__18 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

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
	private struct <RequestRejectGroupTeamInvitation>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

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
	private struct <RequestServerGroupTeamJoin>d__24 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inHostUUID;

		public GroupTeamManager <>4__this;

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
	private struct <RequestServerGroupAnnounce>d__28 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public LobbyManager.ELobbyType inType;

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
	private struct <HandleGroupTeamJoinResponse>d__36 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public XtReader data;

		private int <partyMemberCount>5__2;

		private UserInfo[] <partyMembers>5__3;

		private UniTask<UserInfo>.Awaiter <>u__1;

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
	private struct <HandleGroupTeamUserJoinedResponse>d__38 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public XtReader data;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string questDefId;

	public static List<UserInfo> currentGroupMembers;

	public static UserInfo creator;

	public static bool iAmHost;

	private static GroupTeamManager _instance;

	public static GroupTeamManager Instance
	{
		get
		{
			return null;
		}
	}

	static GroupTeamManager()
	{
	}

	private GroupTeamManager()
	{
	}

	public static void CreateGroup(string inQuestDefId)
	{
	}

	[DebugButton("[Group Creator] Create Group", "GroupTeamParties", true, false)]
	public static void CreateGroup()
	{
	}

	[IteratorStateMachine(typeof(<_CreateGroupTeam>d__11))]
	private IEnumerator _CreateGroupTeam()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerCreateGroupTeam>d__12))]
	private void RequestServerCreateGroupTeam()
	{
	}

	[DebugButton("[Group Creator] Add Player To Group", "GroupTeamParties", true, false)]
	public static void AddPlayerToGroup(string inUserUUIDToAdd)
	{
	}

	[IteratorStateMachine(typeof(<_InviteToGroupTeam>d__14))]
	private IEnumerator _InviteToGroupTeam(string inUserUUIDToAdd)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerInviteToGroupTeam>d__15))]
	private void RequestServerInviteToGroupTeam(string inUserUUIDToAdd)
	{
	}

	[DebugButton("[Other Players] Accept Group Invite", "GroupTeamParties", true, false)]
	public static void AcceptGroupTeamInvitation(string inGroupCreatorUUID)
	{
	}

	[IteratorStateMachine(typeof(<_AcceptGroupTeamInvitation>d__17))]
	private IEnumerator _AcceptGroupTeamInvitation(string inGroupCreatorUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestAcceptGroupTeamInvitation>d__18))]
	private void RequestAcceptGroupTeamInvitation(string inGroupCreatorUUID)
	{
	}

	[DebugButton("[Other Players] Reject Group Invite", "GroupTeamParties", true, false)]
	public static void RejectGroupInvite(string inGroupCreatorUUID)
	{
	}

	[IteratorStateMachine(typeof(<_RejectGroupTeamInvitation>d__20))]
	private IEnumerator _RejectGroupTeamInvitation(string inGroupCreatorUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestRejectGroupTeamInvitation>d__21))]
	private void RequestRejectGroupTeamInvitation(string inGroupCreatorUUID)
	{
	}

	[DebugButton("[Other Players] Join Group", "GroupTeamParties", true, false)]
	public static Coroutine GroupTeamJoin(string inHostUUID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_GroupTeamJoin>d__23))]
	private IEnumerator _GroupTeamJoin(string inHostUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerGroupTeamJoin>d__24))]
	private void RequestServerGroupTeamJoin(string inHostUUID)
	{
	}

	[DebugButton("[Any Player In Group] Leave Group", "GroupTeamParties", true, false)]
	public static void GroupTeamLeave()
	{
	}

	[DebugButton("[Group Creator] Group Announce (pull in all in radius)", "GroupTeamParties", true, false)]
	public static Coroutine GroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_GroupAnnounce>d__27))]
	private IEnumerator _GroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerGroupAnnounce>d__28))]
	private void RequestServerGroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID)
	{
	}

	[DebugButton("[Group Creator] Group Quest (start quest with current party)", "GroupTeamParties", true, false)]
	public static Coroutine GroupQuest(string inQuestDefID)
	{
		return null;
	}

	public Coroutine GroupQuest()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_GroupQuest>d__31))]
	private IEnumerator _GroupQuest(string inQuestDefID)
	{
		return null;
	}

	private void RequestServerGroupQuest(string inQuestDefID)
	{
	}

	private void OnGroupTeamJoinSuccessResponse(RequestGroupTeamJoinSuccessMessage inMessage)
	{
	}

	private void OnGroupTeamJoinFailureResponse(RequestGroupTeamJoinFailedMessage inMessage)
	{
	}

	internal static void HandleGroupTeamCreateResponse(XtReader data)
	{
	}

	[AsyncStateMachine(typeof(<HandleGroupTeamJoinResponse>d__36))]
	internal static void HandleGroupTeamJoinResponse(XtReader data)
	{
	}

	internal static void HandleGroupTeamLeaveResponse(XtReader data)
	{
	}

	[AsyncStateMachine(typeof(<HandleGroupTeamUserJoinedResponse>d__38))]
	internal static void HandleGroupTeamUserJoinedResponse(XtReader data)
	{
	}

	internal static void HandleGroupTeamUserLeftResponse(XtReader data)
	{
	}
}
