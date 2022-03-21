using TMPro;
using UnityEngine;

public class UI_Window_TradeComplete : UI_Window
{
	[SerializeField]
	private UI_LazyItemList_ReadonlyItemList _itemList;

	[SerializeField]
	private WWTextMeshProUGUI _gotItemsText;

	[SerializeField]
	private WWTextMeshProUGUI _noItemsText;

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

	public void Setup(Trade inTrade)
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
