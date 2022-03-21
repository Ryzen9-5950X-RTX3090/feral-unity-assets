using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_CustomizerUpsell : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _costText;

	[SerializeField]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	private UI_TimeRemainingBadge _timeRemainingBadge;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	[RootSelector("Locked Info Override", "LocalizationChartData", false, true)]
	private string _lockedInfoDef;

	[SerializeField]
	[RootSelector("Details Info Override", "LocalizationChartData", false, true)]
	private string _detailsInfoDef;

	[SerializeField]
	private WWTextMeshProUGUI _lockedInfoText;

	[SerializeField]
	[Header("Background")]
	private WWImage _backgroundImage;

	[SerializeField]
	private Sprite _backgroundSpriteSeasonPass;

	private BaseDef _def;

	private BundlePackDefComponent _bundlePack;

	private PurchaseableDefComponent _purchaseable;

	private string _lockedInfoLocalization
	{
		get
		{
			return null;
		}
	}

	private string _detailsInfoLocalization
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow(BaseDef inDef)
	{
	}

	public static void QueueWindow(BaseDef inDef)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(BaseDef inDef)
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

	public void BtnClicked_GetSeasonPass()
	{
	}

	[IteratorStateMachine(typeof(<HandleWindows>d__26))]
	private IEnumerator HandleWindows()
	{
		return null;
	}
}
