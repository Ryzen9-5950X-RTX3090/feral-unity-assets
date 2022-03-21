using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_Quests : UI_LazyListItemDetailPanel<ILinearQuestData>
{
	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _giverNameText;

	[SerializeField]
	private WWImage _questIconImage;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private UI_ObjectiveItem _objectiveItem;

	[SerializeField]
	private CanvasGroup _questGroup;

	[SerializeField]
	private CanvasGroup _noQuestGroup;

	private Quest _activeQuest;

	private void Start()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Setup(UI_LazyListItem<ILinearQuestData> inDataSrc)
	{
	}

	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage)
	{
	}

	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage)
	{
	}

	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage)
	{
	}
}
