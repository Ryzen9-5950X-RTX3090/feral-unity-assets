using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_Follower : UI_LazyListItem<RelationshipManager.Follower>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetupAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItem_Follower <>4__this;

		private UniTask<bool>.Awaiter <>u__1;

		private UniTask<UserInfo>.Awaiter <>u__2;

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
	private struct <BtnClicked_PrivateChat>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItem_Follower <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWImage _blockedIconImage;

	[SerializeField]
	private UI_OnlineStatus _onlineStatus;

	[SerializeField]
	private FeralButton _privateChatBtn;

	[SerializeField]
	private GameObject _privateChatUnreadIndicator;

	[SerializeField]
	private FeralButton _favoriteToggle;

	[SerializeField]
	private FeralButton _voiceChatBtn;

	private UserInfo _userInfo;

	private bool _isBlocked;

	private bool _isFavorite;

	private bool _hasCompletedSetup;

	private CancellationTokenSource _cancellationTokenSource;

	public override void Setup(Action<UI_LazyListItem<RelationshipManager.Follower>> inOnClicked, Action<UI_LazyListItem<RelationshipManager.Follower>> inOnSelected, RelationshipManager.Follower inData, UI_LazyItemList<RelationshipManager.Follower> inItemList)
	{
	}

	[AsyncStateMachine(typeof(<SetupAsync>d__14))]
	private void SetupAsync()
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_PrivateChat>d__15))]
	public void BtnClicked_PrivateChat()
	{
	}

	public void BtnClicked_VoiceChat()
	{
	}

	public void BtnClicked_ToggleFavorite(bool inIsOn)
	{
	}

	protected override void Start()
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

	private void RefreshBlockedState(bool inInstant = false)
	{
	}

	private void RefreshPrivateChat()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	protected override void OnClicked()
	{
	}
}
