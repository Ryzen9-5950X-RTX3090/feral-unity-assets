using TMPro;
using UnityEngine;

public class UI_Window_ReceiveTradeRequest : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _messageText;

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

	public void BtnClicked_Decline()
	{
	}

	public void BtnClicked_Accept()
	{
	}

	private void OnTradeReqeustEnded(TradeRequestEndedMessage inMessage)
	{
	}

	private void OnTradeStarted(TradeStartedMessage inMessage)
	{
	}

	private void OnTradeRequestSent(TradeRequestSentMessage inMessage)
	{
	}
}
