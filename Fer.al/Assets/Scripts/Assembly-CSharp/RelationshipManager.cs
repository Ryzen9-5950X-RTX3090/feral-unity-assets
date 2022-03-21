using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using WW.Debug;

public class RelationshipManager : SingletonManagerBase<RelationshipManager>
{
	[Serializable]
	public class Follower
	{
		public string userUUID;

		public bool isFavorite;
	}

	[Serializable]
	public class Follow
	{
		public string userUUID;

		public bool isFavorite;

		public DateTime followedAt;
	}

	[Serializable]
	public class Block
	{
		public string userUUID;

		public DateTime blockedAtTime;
	}

	public struct CachedOnlineStatus
	{
		public OnlineStatus status;

		public float cachedAtTime;

		public bool IsExpired
		{
			get
			{
				return default(bool);
			}
		}

		public CachedOnlineStatus(OnlineStatus inOnlineStatus)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <FollowUser>d__27 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUserToFollowUUID;

		public RelationshipManager <>4__this;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.FollowUserResponse>> <>u__1;

		private TaskAwaiter<OnlineStatusResponse> <>u__2;

		private UniTask<UserInfo>.Awaiter <>u__3;

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
	private struct <UnfollowUser>d__29 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUserToUnfollowUUID;

		public RelationshipManager <>4__this;

		private <>c__DisplayClass29_0 <>8__1;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnfollowUserResponse>> <>u__1;

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
	private struct <FavoriteUser>d__30 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUserToFavoriteUUID;

		public RelationshipManager <>4__this;

		private <>c__DisplayClass30_0 <>8__1;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.FavoriteUserResponse>> <>u__1;

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
	private struct <UnfavoriteUser>d__31 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUserToUnfavoriteUUID;

		public RelationshipManager <>4__this;

		private <>c__DisplayClass31_0 <>8__1;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnfavoriteUserResponse>> <>u__1;

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
	private struct <BlockUser>d__32 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUserToBlockUUID;

		public RelationshipManager <>4__this;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.BlockUserResponse>> <>u__1;

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
	private struct <UnblockUser>d__33 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUserToUnblockUUID;

		public RelationshipManager <>4__this;

		private <>c__DisplayClass33_0 <>8__1;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnblockUserResponse>> <>u__1;

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
	private struct <UserIsBlocked>d__34 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<bool> <>t__builder;

		public RelationshipManager <>4__this;

		public string inUserToCheckUUID;

		private <>c__DisplayClass34_0 <>8__1;

		private UniTask.Awaiter <>u__1;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.CheckIsBlockedResponse>> <>u__2;

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
	private struct <UserIsOnline>d__35 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		public string inUserToCheckUUID;

		public RelationshipManager <>4__this;

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
	private struct <RequestAdditionalFollowers>d__39 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public RelationshipManager <>4__this;

		private int <alreadyReceivedCount>5__2;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.ListFollowersResponse>> <>u__1;

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
	private struct <GoToPlayer>d__41 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public RelationshipManager <>4__this;

		public string inUUID;

		private <>c__DisplayClass41_0 <>8__1;

		private TaskAwaiter<bool> <>u__1;

		private TaskAwaiter <>u__2;

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
	private struct <SearchForPlayer>d__43 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<string> <>t__builder;

		public string inDisplayName;

		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1;

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
	private struct <RefreshFollows>d__44 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public RelationshipManager <>4__this;

		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.ListFollowsResponse>> <>u__1;

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
	private struct <OnUserBlocked>d__48 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UserBlockedMessage inMessage;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private List<Follower> _followers;

	private const int FOLLOWER_PAGE_SIZE = 10;

	private const float FOLLOWERS_ALL_CACHED_COOLDOWN = 10f;

	private bool _requestingFollowers;

	private bool _allFollowersCached;

	[SerializeField]
	private List<Follow> _follows;

	[SerializeField]
	private List<Block> _blocks;

	private Dictionary<string, bool> _blockChecks;

	private List<string> _blockChecksInProgress;

	public const float ONLINE_CACHE_LIFETIME = 30f;

	private Dictionary<string, CachedOnlineStatus> _onlineStatuses;

	public string userToJoin;

	[SerializeField]
	[RootSelector("Confirm Unfollow Title", "LocalizationChartData", false, false)]
	private string _confirmUnfollowTitleDefId;

	[SerializeField]
	[RootSelector("Confirm Unfollow Message", "LocalizationChartData", false, false)]
	private string _confirmUnfollowMessageDefId;

	[SerializeField]
	[RootSelector("Confirm Unfollow Yes", "LocalizationChartData", false, false)]
	private string _confirmUnfollowYesDefId;

	[SerializeField]
	[RootSelector("Confirm Unfollow No", "LocalizationChartData", false, false)]
	private string _confirmUnfollowNoDefId;

	public List<Follower> Followers
	{
		get
		{
			return null;
		}
	}

	public List<Follow> Follows
	{
		get
		{
			return null;
		}
	}

	public List<Block> Blocks
	{
		get
		{
			return null;
		}
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	[AsyncStateMachine(typeof(<FollowUser>d__27))]
	[DebugButton("Follow User", "Relationships", false, false)]
	public void FollowUser(string inUserToFollowUUID)
	{
	}

	public void ConfirmUnfollowUser(string inUserToUnfollowUUID)
	{
	}

	[AsyncStateMachine(typeof(<UnfollowUser>d__29))]
	[DebugButton("Unfollow User", "Relationships", false, false)]
	public void UnfollowUser(string inUserToUnfollowUUID)
	{
	}

	[AsyncStateMachine(typeof(<FavoriteUser>d__30))]
	[DebugButton("Favorite User", "Relationships", false, false)]
	public void FavoriteUser(string inUserToFavoriteUUID)
	{
	}

	[AsyncStateMachine(typeof(<UnfavoriteUser>d__31))]
	[DebugButton("Unfavorite User", "Relationships", false, false)]
	public void UnfavoriteUser(string inUserToUnfavoriteUUID)
	{
	}

	[AsyncStateMachine(typeof(<BlockUser>d__32))]
	[DebugButton("Block User", "Relationships", false, false)]
	public void BlockUser(string inUserToBlockUUID)
	{
	}

	[AsyncStateMachine(typeof(<UnblockUser>d__33))]
	[DebugButton("Unblock User", "Relationships", false, false)]
	public void UnblockUser(string inUserToUnblockUUID)
	{
	}

	[AsyncStateMachine(typeof(<UserIsBlocked>d__34))]
	public UniTask<bool> UserIsBlocked(string inUserToCheckUUID)
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(<UserIsOnline>d__35))]
	public Task<bool> UserIsOnline(string inUserToCheckUUID)
	{
		return null;
	}

	public bool UserIsOnlineImmediate(string inUserToCheckUUID)
	{
		return default(bool);
	}

	public bool UserIsFollowed(string inUserToCheckUUID)
	{
		return default(bool);
	}

	public Follow GetFollow(string inUserToCheckUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestAdditionalFollowers>d__39))]
	public void RequestAdditionalFollowers()
	{
	}

	public void ClearFollowersCache()
	{
	}

	[AsyncStateMachine(typeof(<GoToPlayer>d__41))]
	[DebugButton("Go To User", "Relationships", false, false)]
	public void GoToPlayer(string inUUID)
	{
	}

	public void TeleportToPlayer(WorldObject inPlayerWorldObject)
	{
	}

	[AsyncStateMachine(typeof(<SearchForPlayer>d__43))]
	public Task<string> SearchForPlayer(string inDisplayName)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RefreshFollows>d__44))]
	private void RefreshFollows()
	{
	}

	private void OnLoginComplete(LoginCompleteMessage inMessage)
	{
	}

	private void OnRelationshipFollowingListResponse(RelationshipFollowingListResponse inMessage)
	{
	}

	private void OnFollowOnlineStatusUpdated(RelationshipFollowOnlineStatusUpdateResponse inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnUserBlocked>d__48))]
	private void OnUserBlocked(UserBlockedMessage inMessage)
	{
	}
}
