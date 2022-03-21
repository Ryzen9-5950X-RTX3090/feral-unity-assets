using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class RelationshipSrvHandler
{
	[Serializable]
	public class BlockUserResponse
	{
		public string error;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class UnblockUserResponse
	{
		public string error;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class CheckIsBlockedResponse
	{
		[SerializeField]
		private string created_at;

		private DateTime _blockedAt;

		public string error;

		public DateTime BlockedAt
		{
			get
			{
				return default(DateTime);
			}
		}

		public bool IsBlocked
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class FollowUserResponse
	{
		public string error;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class UnfollowUserResponse
	{
		public string error;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class CheckIsFollowedResponse
	{
		[SerializeField]
		private string followed_at;

		private DateTime _followedAt;

		public string error;

		public DateTime FollowedAt
		{
			get
			{
				return default(DateTime);
			}
		}

		public bool IsFollowed
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class ListFollowsResponse
	{
		[Serializable]
		public class FollowItem
		{
			[SerializeField]
			private string created_at;

			private DateTime _createdAt;

			[SerializeField]
			private string updated_at;

			private DateTime _updatedAt;

			public string uuid;

			public bool favorite;

			public DateTime CreatedAt
			{
				get
				{
					return default(DateTime);
				}
			}

			public DateTime UpdatedAt
			{
				get
				{
					return default(DateTime);
				}
			}
		}

		public string error;

		public FollowItem[] followItems;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class ListFollowersResponse
	{
		[Serializable]
		public class FollowerItem
		{
			public string uuid;

			public bool favorite;
		}

		public string error;

		public FollowerItem[] followerItems;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class FavoriteUserResponse
	{
		public string error;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[Serializable]
	public class UnfavoriteUserResponse
	{
		public string error;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BlockUser>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<BlockUserResponse>> <>t__builder;

		public string inUserToBlockUUID;

		private TaskAwaiter<WWWResponse<BlockUserResponse>> <>u__1;

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
	private struct <UnblockUser>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<UnblockUserResponse>> <>t__builder;

		public string inUserToUnblockUUID;

		private TaskAwaiter<WWWResponse<UnblockUserResponse>> <>u__1;

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
	private struct <CheckIsBlocked>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<CheckIsBlockedResponse>> <>t__builder;

		public string inUserToCheckUUID;

		private TaskAwaiter<WWWResponse<CheckIsBlockedResponse>> <>u__1;

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
	private struct <FollowUser>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<FollowUserResponse>> <>t__builder;

		public string inUserToFollowUUID;

		private TaskAwaiter<WWWResponse<FollowUserResponse>> <>u__1;

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
	private struct <UnfollowUser>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<UnfollowUserResponse>> <>t__builder;

		public string inUserToUnfollowUUID;

		private TaskAwaiter<WWWResponse<UnfollowUserResponse>> <>u__1;

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
	private struct <RequestFollows>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ListFollowsResponse>> <>t__builder;

		private TaskAwaiter<WWWResponse> <>u__1;

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
	private struct <RequestFollowers>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ListFollowersResponse>> <>t__builder;

		public int inPageIndex;

		public int inPageSize;

		private TaskAwaiter<WWWResponse> <>u__1;

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
	private struct <FavoriteUser>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<FavoriteUserResponse>> <>t__builder;

		public string inUserToFavoriteUUID;

		private TaskAwaiter<WWWResponse<FavoriteUserResponse>> <>u__1;

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
	private struct <UnfavoriteUser>d__18 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<UnfavoriteUserResponse>> <>t__builder;

		public string inUserToUnfavoriteUUID;

		private TaskAwaiter<WWWResponse<UnfavoriteUserResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string Host
	{
		get
		{
			return null;
		}
	}

	[AsyncStateMachine(typeof(<BlockUser>d__2))]
	public static Task<WWWResponse<BlockUserResponse>> BlockUser(string inUserToBlockUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<UnblockUser>d__3))]
	public static Task<WWWResponse<UnblockUserResponse>> UnblockUser(string inUserToUnblockUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<CheckIsBlocked>d__4))]
	public static Task<WWWResponse<CheckIsBlockedResponse>> CheckIsBlocked(string inUserToCheckUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<FollowUser>d__8))]
	public static Task<WWWResponse<FollowUserResponse>> FollowUser(string inUserToFollowUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<UnfollowUser>d__9))]
	public static Task<WWWResponse<UnfollowUserResponse>> UnfollowUser(string inUserToUnfollowUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestFollows>d__10))]
	public static Task<WWWResponse<ListFollowsResponse>> RequestFollows()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestFollowers>d__11))]
	public static Task<WWWResponse<ListFollowersResponse>> RequestFollowers(int inPageIndex = -1, int inPageSize = -1)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<FavoriteUser>d__17))]
	public static Task<WWWResponse<FavoriteUserResponse>> FavoriteUser(string inUserToFavoriteUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<UnfavoriteUser>d__18))]
	public static Task<WWWResponse<UnfavoriteUserResponse>> UnfavoriteUser(string inUserToUnfavoriteUUID)
	{
		return null;
	}
}
