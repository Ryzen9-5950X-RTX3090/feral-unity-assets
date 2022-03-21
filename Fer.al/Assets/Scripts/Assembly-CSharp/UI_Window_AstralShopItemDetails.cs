using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_AstralShopItemDetails : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DoPurchase>d__27 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_AstralShopItemDetails <>4__this;

		private TaskAwaiter<BuyItemResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

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
	private FeralButton _detailButton;

	[SerializeField]
	private GameObject _countGroup;

	[SerializeField]
	private WWTextMeshProUGUI _countLabel;

	[SerializeField]
	[Header("Background")]
	private WWImage _backgroundImage;

	[SerializeField]
	private Sprite _backgroundSpriteRegular;

	[SerializeField]
	private Sprite _backgroundSpriteSeasonPass;

	[Nullable(2)]
	private string _shopDefId;

	private bool _displayPurchaseResult;

	private BaseDef _def;

	private BundlePackDefComponent _bundlePack;

	private PurchaseableDefComponent _purchaseable;

	private ContentVisitRecord _itemVisitRecord;

	public static void OpenWindow(BaseDef inDef, [Optional] string inShopDefId, bool inDisplayPurchaseResult = true)
	{
	}

	public static void QueueWindow(BaseDef inDef, [Optional] string inShopDefId, bool inDisplayPurchaseResult = true)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(BaseDef inDef, string inShopDefId, bool inDisplayPurchaseResult)
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

	public void BtnClicked_Buy()
	{
	}

	public void BtnClicked_Details()
	{
	}

	[AsyncStateMachine(typeof(<DoPurchase>d__27))]
	private void DoPurchase()
	{
	}
}
