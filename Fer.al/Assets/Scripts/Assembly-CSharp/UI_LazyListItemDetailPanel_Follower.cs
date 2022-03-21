using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_Follower : UI_LazyListItemDetailPanel<RelationshipManager.Follower>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItemDetailPanel_Follower <>4__this;

		public UI_LazyListItem<RelationshipManager.Follower> inDataSrc;

		private FeralButton <>7__wrap1;

		private UniTask<bool>.Awaiter <>u__1;

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
	private struct <RefreshOnlineStatus>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItemDetailPanel_Follower <>4__this;

		private TaskAwaiter<bool> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private FeralButton _blockUserToggle;

	[SerializeField]
	private FeralButton _followUserToggle;

	[SerializeField]
	private FeralButton _tradeBtn;

	[AsyncStateMachine(typeof(<Setup>d__3))]
	public override void Setup(UI_LazyListItem<RelationshipManager.Follower> inDataSrc)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnUserBlocked(UserBlockedMessage inMessage)
	{
	}

	private void OnUserUnblocked(UserUnblockedMessage inMessage)
	{
	}

	private void OnUserFollowed(UserFollowedMessage inMessage)
	{
	}

	private void OnUserUnfollowed(UserUnfollowedMessage inMessage)
	{
	}

	public void BtnClicked_Sanctuary()
	{
	}

	public void BtnClicked_Trade()
	{
	}

	public void BtnClicked_OpenPlayerCard()
	{
	}

	public void BtnClicked_ToggleFollow()
	{
	}

	public void BtnClicked_ToggleBlock()
	{
	}

	[AsyncStateMachine(typeof(<RefreshOnlineStatus>d__15))]
	private void RefreshOnlineStatus()
	{
	}
}
