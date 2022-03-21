using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_SeasonPass : UI_Window
{
	[SerializeField]
	private RawImage _playerIconImage;

	[SerializeField]
	private WWTextMeshProUGUI _seasonPassNameText;

	[SerializeField]
	private WWTextMeshProUGUI _daysRemainingText;

	[SerializeField]
	private WWTextMeshProUGUI _currentTierText;

	[SerializeField]
	private GameObject _seasonPassCompletedGroup;

	[SerializeField]
	private WWImage _seasonPassProgressImage;

	[SerializeField]
	private GameObject _getPassButton;

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

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	private void Refresh()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_IAPShop()
	{
	}

	public void BtnClicked_MyChallenges()
	{
	}

	public void BtnClicked_FAQ()
	{
	}

	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage)
	{
	}

	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage)
	{
	}

	private void OnSeasonPassExpired(SeasonPassExpiredMessage inMessage)
	{
	}
}
