using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_TradeLobby : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public Trade inTrade;

		public UI_Window_TradeLobby <>4__this;

		private TaskAwaiter<AvatarLookGetResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _otherUserTitleText;

	[SerializeField]
	private WWTextMeshProUGUI _otherUserReadyText;

	[SerializeField]
	private FeralButton _readyToggleMe;

	[SerializeField]
	private FeralButton _readyToggleThem;

	[SerializeField]
	private GameObject _waitingGroup;

	[SerializeField]
	[Header("Chat")]
	private WWTextMeshProUGUI _chatNameTextMe;

	[SerializeField]
	private WWTextMeshProUGUI _chatNameTextThem;

	[SerializeField]
	private RawImage _playerIconMe;

	[SerializeField]
	private RawImage _playerIconThem;

	[SerializeField]
	[Header("Audio")]
	private FeralAudioInfo _tradeRejectedAudioInfo;

	[SerializeField]
	private FeralAudioInfo _tradeAccepttedAudioInfo;

	private Trade _trade;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static void OpenWindow(Trade inTrade)
	{
	}

	public static void QueueWindow(Trade inTrade)
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__16))]
	private void Setup(Trade inTrade)
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

	public void BtnClicked_ExitTrade()
	{
	}

	public void BtnToggled_Ready(bool InValue)
	{
	}

	private void OnTradeEnded(TradeEndedMessage inMessage)
	{
	}

	private void OnUserReadyStateChanged(UserReadyStateChangedMessage inMessage)
	{
	}

	private void OnTradeConfirmationInitiated(TradeConfirmationInitiatedMessage inMessage)
	{
	}

	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage)
	{
	}

	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage)
	{
	}

	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage)
	{
	}
}
