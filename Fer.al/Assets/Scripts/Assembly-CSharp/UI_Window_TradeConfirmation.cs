using TMPro;
using UnityEngine;

public class UI_Window_TradeConfirmation : UI_Window
{
	[SerializeField]
	private UI_LazyItemList_ReadonlyItemList _itemListMine;

	[SerializeField]
	private UI_LazyItemList_ReadonlyItemList _itemListTheirs;

	[SerializeField]
	private GameObject _groupInitial;

	[SerializeField]
	private GameObject _groupWaiting;

	[SerializeField]
	private WWTextMeshProUGUI _waitingText;

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

	public void BtnClicked_RejectTrade()
	{
	}

	public void BtnClicked_AcceptTrade()
	{
	}

	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage)
	{
	}

	private void OnTradeEnded(TradeEndedMessage inMessage)
	{
	}

	private void OnTradeRequestEnded(TradeRequestEndedMessage inMessage)
	{
	}
}
