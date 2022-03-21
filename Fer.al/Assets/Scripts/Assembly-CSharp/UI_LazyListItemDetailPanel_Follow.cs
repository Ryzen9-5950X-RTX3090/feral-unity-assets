using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_Follow : UI_LazyListItemDetailPanel<RelationshipManager.Follow>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItemDetailPanel_Follow <>4__this;

		public UI_LazyListItem<RelationshipManager.Follow> inDataSrc;

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
	private struct <RefreshOnlineStatus>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItemDetailPanel_Follow <>4__this;

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
	private FeralButton _tradeBtn;

	[AsyncStateMachine(typeof(<Setup>d__2))]
	public override void Setup(UI_LazyListItem<RelationshipManager.Follow> inDataSrc)
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

	private void OnOnlineStatusChanged(UserOnlineStatusMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<RefreshOnlineStatus>d__8))]
	private void RefreshOnlineStatus()
	{
	}

	public void BtnClicked_Unfollow()
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

	public void BtnClicked_ToggleBlock()
	{
	}
}
