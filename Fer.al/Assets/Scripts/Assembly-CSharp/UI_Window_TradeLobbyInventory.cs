using TMPro;
using UnityEngine;

public class UI_Window_TradeLobbyInventory : UI_Window
{
	[SerializeField]
	private UI_LazyItemList_TradeLobbyInventory _itemList;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	[SerializeField]
	private WWTextMeshProUGUI _categoryText;

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

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnCategorySelected(int inCategoryIndex)
	{
	}

	private void OnTradeEnded(TradeEndedMessage inMessage)
	{
	}

	private void OnTradeConfirmationInitiated(TradeConfirmationInitiatedMessage inMessage)
	{
	}
}
