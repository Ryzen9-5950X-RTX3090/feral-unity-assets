using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_PlayerCard : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_PlayerCard <>4__this;

		public string inUUID;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private TaskAwaiter<AvatarLookGetResponse> <>u__2;

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
	private struct <RefreshBlocked>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_PlayerCard <>4__this;

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
	private struct <BtnClicked_PrivateChat>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_PlayerCard <>4__this;

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
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private RawImage _avatarIconImage;

	[SerializeField]
	private FeralButton _followToggle;

	[SerializeField]
	private FeralButton _blockToggle;

	[SerializeField]
	private FeralButton _favoriteToggle;

	[SerializeField]
	private FeralButton _btnVoiceChat;

	[SerializeField]
	private UI_OnlineStatus _onlineStatus;

	[SerializeField]
	private UI_XPIndicator _xpIndicator;

	private UserInfo _userInfo;

	public static void OpenWindow(string inUUID)
	{
	}

	public static void QueueWindow(string inUUID)
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__12))]
	private void Setup(string inUUID)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	private void RefreshFollowedAndFavorited()
	{
	}

	[AsyncStateMachine(typeof(<RefreshBlocked>d__17))]
	private void RefreshBlocked()
	{
	}

	public void ToggleBtnClicked_Favorite(bool inIsOn)
	{
	}

	public void BtnClicked_ToggleFollow()
	{
	}

	public void BtnClicked_ToggleBlock()
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_PrivateChat>d__21))]
	public void BtnClicked_PrivateChat()
	{
	}

	public void BtnClicked_VoiceChat()
	{
	}

	public void BtnClicked_Sanctuary()
	{
	}

	public void BtnClicked_Trade()
	{
	}

	public void BtnClicked_GoToPlayer()
	{
	}

	public void BtnClicked_Report()
	{
	}

	private void OnUserFollowed(UserFollowedMessage inMessage)
	{
	}

	private void OnUserUnFollowed(UserUnfollowedMessage inMessage)
	{
	}

	private void OnUserFavorited(UserFavoritedMessage inMessage)
	{
	}

	private void OnUserUnfavorited(UserUnfavoritedMessage inMessage)
	{
	}

	private void OnUserBlocked(UserBlockedMessage inMessage)
	{
	}

	private void OnUserUnblocked(UserUnblockedMessage inMessage)
	{
	}

	private void CloseFromMessage(Message inMessage)
	{
	}
}
