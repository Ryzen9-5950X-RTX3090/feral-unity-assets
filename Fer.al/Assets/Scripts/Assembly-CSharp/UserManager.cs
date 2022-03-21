using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using WW.Debug;

public class UserManager : SingletonManagerBase<UserManager>
{
	private class UserCollection
	{
		private Dictionary<string, UserInfo> _usersByUUID;

		public void ClearUsersByUUID()
		{
		}

		public UserInfo GetByUUID(string uuid)
		{
			return null;
		}

		public void Add(UserInfo u)
		{
		}

		public UserInfo AddOrReplace(string uuid, string displayName)
		{
			return null;
		}

		public void Remove(UserInfo u)
		{
		}

		public void RemoveByUUID(string uuid)
		{
		}
	}

	private class BatchedDisplayNameRequest
	{
		public string uuid;

		public int count;

		public BatchedDisplayNameRequest(string inUUID, int inCount)
		{
		}
	}

	private class BatchedDisplayNameResult
	{
		public string uuid;

		public int count;

		public string displayName;

		public BatchedDisplayNameResult(string inUUID, int inCount, string inDisplayName)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetUserInfoAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<UserInfo> <>t__builder;

		public string uuid;

		private UserInfo <u>5__2;

		private TaskAwaiter<string> <>u__1;

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
	private struct <GetDisplayNamesAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<IdentityDisplayNamesResponse.Identity[]> <>t__builder;

		public List<string> uuids;

		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__1;

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
	private struct <GetDisplayNameBatched>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<string> <>t__builder;

		public string inUUID;

		public UserManager <>4__this;

		private <>c__DisplayClass21_0 <>8__1;

		private UniTask.Awaiter <>u__1;

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
	private struct <RequestBatchedDisplayNames>d__22 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UserManager <>4__this;

		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private MyUserInfo _me;

	private UserCollection _users;

	private List<BatchedDisplayNameRequest> _displayNameRequestsPending;

	private List<BatchedDisplayNameRequest> _displayNameRequestsInProgress;

	private List<BatchedDisplayNameResult> _displayNameResults;

	private const float BATCH_REQUEST_COOLDOWN = 0.25f;

	private float _lastBatchRequestTime;

	public static MyUserInfo Me
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DebugField("Skip Tutorial", "QA/Onboarding", false, true)]
	public static bool SkipTutorial
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugField("Force Tutorial", "QA/Onboarding", false, true)]
	public static bool ForceTutorial
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugField("Force Tutorial Outro", "QA/Onboarding", false, true)]
	public static bool ForceTutorialOutro
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public void ClearUsersByUUID()
	{
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public static UserInfo AddOrReplaceUserInfo(string uuid, string displayName)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetUserInfoAsync>d__17))]
	public static UniTask<UserInfo> GetUserInfoAsync(string uuid)
	{
		return default(UniTask<UserInfo>);
	}

	public static UserInfo GetUserInfoImmediate(string uuid)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetDisplayNamesAsync>d__19))]
	public static Task<IdentityDisplayNamesResponse.Identity[]> GetDisplayNamesAsync(List<string> uuids)
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	[AsyncStateMachine(typeof(<GetDisplayNameBatched>d__21))]
	private Task<string> GetDisplayNameBatched(string inUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestBatchedDisplayNames>d__22))]
	private void RequestBatchedDisplayNames()
	{
	}

	public override void MOnDestroy()
	{
	}
}
