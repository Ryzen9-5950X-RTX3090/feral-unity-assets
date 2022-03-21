using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_FindPlayer : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnSearchSubmit>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_FindPlayer <>4__this;

		public string inSearch;

		private float <time>5__2;

		private string <result>5__3;

		private TaskAwaiter<string> <>u__1;

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
	private struct <RefreshOnlineStatus>d__33 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_FindPlayer <>4__this;

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
	private TMP_InputField _searchInputField;

	[SerializeField]
	[Header("Groups")]
	private CanvasGroup _groupInitial;

	[SerializeField]
	private CanvasGroup _groupPlayerFound;

	[SerializeField]
	private CanvasGroup _groupPlayerNotFound;

	[SerializeField]
	private GameObject _waitingGroup;

	[SerializeField]
	[Header("Found Player UI")]
	private WWImage _blockedIconImage;

	[SerializeField]
	private FeralButton _privateChatBtn;

	[SerializeField]
	private GameObject _privateChatUnreadIndicator;

	[SerializeField]
	private FeralButton _favoriteToggle;

	[SerializeField]
	private FeralButton _blockedToggle;

	[SerializeField]
	private FeralButton _followToggle;

	[SerializeField]
	private FeralButton _goToPlayerBtn;

	[SerializeField]
	private FeralButton _tradeBtn;

	private UserInfo _userInfo;

	private bool _isBlocked;

	private bool _isFavorite;

	private string _previousSearch;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	[AsyncStateMachine(typeof(<OnSearchSubmit>d__21))]
	public void OnSearchSubmit(string inSearch)
	{
	}

	public void ToggleBtnClicked_Favorite(bool inIsOn)
	{
	}

	public void ToggleBtnClicked_Follow(bool inIsOn)
	{
	}

	public void ToggleBtnClicked_Block(bool inIsOn)
	{
	}

	public void BtnClicked_PrivateChat()
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

	private void OnSearchResult(string inUUID)
	{
	}

	private void RefreshFollowStatus(string inUUID)
	{
	}

	private void RefreshPrivateChat()
	{
	}

	private void RefreshBlockedState(bool inInstant = false)
	{
	}

	[AsyncStateMachine(typeof(<RefreshOnlineStatus>d__33))]
	private void RefreshOnlineStatus()
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

	private void OnOnlineStatusChanged(UserOnlineStatusMessage inMessage)
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
}
