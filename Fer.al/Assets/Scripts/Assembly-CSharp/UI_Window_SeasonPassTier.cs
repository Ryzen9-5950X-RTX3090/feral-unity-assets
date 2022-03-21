using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_Window_SeasonPassTier : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DoTierPurchase>d__35 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_SeasonPassTier <>4__this;

		private TaskAwaiter<SeasonPassPurchaseTierResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _tierNumberText;

	[SerializeField]
	[Header("Reward")]
	private UI_ItemImage _rewardItemImage;

	[SerializeField]
	private GameObject _rewardCountGroup;

	[SerializeField]
	private WWTextMeshProUGUI _rewardCountText;

	[SerializeField]
	private WWTextMeshProUGUI _rewardNameText;

	[SerializeField]
	private WWTextMeshProUGUI _rewardDescriptionText;

	[SerializeField]
	private GameObject _bundleInfoGroup;

	[SerializeField]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Completion Status")]
	private GameObject _statusCompleteGroup;

	[SerializeField]
	private GameObject _statusCompleteUnearnedGroup;

	[SerializeField]
	[Header("Free")]
	private GameObject _freeGroup;

	[SerializeField]
	[Header("Previous Tiers")]
	private GameObject _groupPreviousTiers;

	[SerializeField]
	private WWTextMeshProUGUI _previousTiersHeaderText;

	[SerializeField]
	private WWTextMeshProUGUI _previousTiersDescrText;

	[SerializeField]
	private UI_LazyItemList_SeasonPassTier _previousTiersList;

	[SerializeField]
	private WWTextMeshProUGUI _previousTiersCostText;

	[SerializeField]
	[RootSelector("Not Enough Color", "ColorChartData", false, false)]
	private string _notEnoughColorDefId;

	[SerializeField]
	private LazyLayoutGroup _layoutGroup;

	private ISeasonPassTier _seasonPassTier;

	private List<ISeasonPassTier> _previousTiers;

	private int _unlockCost;

	private int _unlockAuraPointCost;

	private BaseDef _rewardDef;

	private WW.Waiters.Waiter _previousTiersWaiter;

	public static void OpenWindow(ISeasonPassTier inSeasonPassTier)
	{
	}

	public static void QueueWindow(ISeasonPassTier inSeasonPassTier)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(ISeasonPassTier inSeasonPassTier)
	{
	}

	private void SetupPreviousTiers()
	{
	}

	private void Refresh()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_Purchase()
	{
	}

	[AsyncStateMachine(typeof(<DoTierPurchase>d__35))]
	private void DoTierPurchase()
	{
	}

	public void BtnClicked_Info()
	{
	}

	public void BtnClicked_BuySeasonPass()
	{
	}

	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage)
	{
	}

	private void OnSeasonPassExpired(SeasonPassExpiredMessage inMessage)
	{
	}
}
