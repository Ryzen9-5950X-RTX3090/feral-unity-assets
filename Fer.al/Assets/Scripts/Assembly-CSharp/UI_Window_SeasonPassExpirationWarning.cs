using TMPro;
using UnityEngine;

public class UI_Window_SeasonPassExpirationWarning : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _daysLeftText;

	[SerializeField]
	private WWTextMeshProUGUI _availableUntilText;

	[SerializeField]
	private GameObject _purchaseSeasonPassBtn;

	[SerializeField]
	private GameObject _PurchaseSeasonPassMessage;

	private ISeasonPass _seasonPass;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
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

	public void BtnClicked_BuySeasonPass()
	{
	}
}
