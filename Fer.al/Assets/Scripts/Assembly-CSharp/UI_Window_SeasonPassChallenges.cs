using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_SeasonPassChallenges : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _seasonPassNameText;

	[SerializeField]
	[Header("Item List")]
	private UI_TabGroup _categoryTabGroup;

	[SerializeField]
	private UI_LazyItemList_SeasonPassChallenges _itemList;

	[SerializeField]
	private WWTextMeshProUGUI _categoryText;

	[SerializeField]
	[Header("Current Tier")]
	private GameObject _tierProgressGroup;

	[SerializeField]
	private WWTextMeshProUGUI _tierRewardNameText;

	[SerializeField]
	private WWTextMeshProUGUI _tierRewardProgressText;

	[SerializeField]
	private GameObject _rewardCountGroup;

	[SerializeField]
	private WWTextMeshProUGUI _rewardCountText;

	[SerializeField]
	private GameObject _passCompletedGroup;

	[SerializeField]
	private GameObject _passExpiredGroup;

	[SerializeField]
	private FeralButton _seasonPassBtn;

	[SerializeField]
	private FeralButton _getThePassBtn;

	[SerializeField]
	[Header("Stage")]
	private UI_StageSubjectPositioner _stagePositioner;

	private UI_Stage_3DItem _itemStage;

	private BaseDef _rewardItem;

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

	private void LayoutSeasonPassButton()
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage)
	{
	}

	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage)
	{
	}

	private void OnTabSelected(int inTabIndex)
	{
	}

	private void OnSeasonPassExpired(SeasonPassExpiredMessage inMessage)
	{
	}

	public void BtnClicked_SeasonPass()
	{
	}
}
