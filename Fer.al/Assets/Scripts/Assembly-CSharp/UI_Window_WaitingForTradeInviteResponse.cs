using TMPro;
using UnityEngine;

public class UI_Window_WaitingForTradeInviteResponse : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	private FeralAudioInfo _tradeRejectedAudioInfo;

	[SerializeField]
	private FeralAudioInfo _tradeAcceptedAudioInfo;

	public static void OpenWindow(Trade inTrade)
	{
	}

	public static void QueueWindow(Trade inTrade)
	{
	}

	public static void CloseWindow()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Setup(Trade inTrade)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnTradeStarted(TradeStartedMessage inMessage)
	{
	}

	private void OnTradeRequestEnded(TradeRequestEndedMessage inMessage)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_Cancel()
	{
	}
}
