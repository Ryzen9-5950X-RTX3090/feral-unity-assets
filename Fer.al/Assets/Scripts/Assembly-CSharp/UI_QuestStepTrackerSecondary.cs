using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ManagedBehaviourManager("WindowManager")]
public class UI_QuestStepTrackerSecondary : ManagedBehaviour
{
	[SerializeField]
	private WWImage _bgImage;

	[SerializeField]
	private UI_ObjectiveItem _objectiveItemPrefab;

	[SerializeField]
	private Transform _objectiveItemParent;

	[SerializeField]
	private WWTextMeshProUGUI _unreadCountText;

	[SerializeField]
	private GameObject _unreadCountGroup;

	[SerializeField]
	private FeralButton _selectLeftBtn;

	[SerializeField]
	private FeralButton _selectRightBtn;

	[SerializeField]
	private FeralAudioInfo _questAddedSound;

	private List<UI_ObjectiveItem> _objectiveItems;

	private bool _isSlidOut;

	private int _selectedIndex;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_SlideOutTab()
	{
	}

	public void BtnClicked_SelectLeft()
	{
	}

	public void BtnClicked_SelectRight()
	{
	}

	private void SelectItem(int inIndexToSelect)
	{
	}

	private void RefreshSelectionButtons()
	{
	}

	private void RefreshUnreadCount()
	{
	}

	private void SpawnSecondaryQuestItem(Quest inSecondaryQuest)
	{
	}

	private void UpdateSecondaryQuestItem(Quest inSecondaryQuest)
	{
	}

	private void CompleteSecondaryQuestItem(UI_ObjectiveItem inObjectiveItem)
	{
	}

	private void RemoveSecondaryQuestItem(Quest inSecondaryQuest)
	{
	}

	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage)
	{
	}

	private void OnSecondaryQuestAdded(SecondaryQuestAddedMessage inMessage)
	{
	}

	private void OnSecondaryQuestUpdated(SecondaryQuestUpdatedMessage inMessage)
	{
	}

	private void OnSecondaryQuestRemoved(SecondaryQuestRemovedMessage inMessage)
	{
	}
}
