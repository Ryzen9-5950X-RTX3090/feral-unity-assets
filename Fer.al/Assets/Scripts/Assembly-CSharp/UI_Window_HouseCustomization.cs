using UnityEngine;

public class UI_Window_HouseCustomization : UI_Window
{
	[SerializeField]
	private UI_StageSubjectPositioner _stageSubjectPositioner;

	[SerializeField]
	private UI_LazyItemList_House _itemList;

	private UI_Stage_House _stage;

	public UI_StageSubjectPositioner StageSubjectPositioner
	{
		get
		{
			return null;
		}
	}

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

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnHouseStageLoaded(UIHouseStageLoadedMessage inMessage)
	{
	}

	private void OnHouseStageInitialized(UIHouseStageInitializedMessage inMessage)
	{
	}

	private void OnCurrentHouseChanged(SanctuaryLookItemComponent inLookItem)
	{
	}
}
