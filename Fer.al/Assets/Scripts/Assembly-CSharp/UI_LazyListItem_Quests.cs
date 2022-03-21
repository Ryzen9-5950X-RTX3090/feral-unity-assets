using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_Quests : UI_LazyListItem<ILinearQuestData>
{
	[SerializeField]
	private WWTextMeshProUGUI _questNameText;

	[SerializeField]
	private WWTextMeshProUGUI _questGiverNameText;

	[SerializeField]
	private WWImage _questGiverIcon;

	[SerializeField]
	private List<GameObject> _unlockedObjects;

	[SerializeField]
	private List<GameObject> _lockedObjects;

	[SerializeField]
	private GameObject _completedGroup;

	private bool _iconIsSetup;

	public override void Setup(Action<UI_LazyListItem<ILinearQuestData>> inOnClicked, Action<UI_LazyListItem<ILinearQuestData>> inOnSelected, ILinearQuestData inData, UI_LazyItemList<ILinearQuestData> inItemList)
	{
	}

	public override void Refresh()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	private void SetUnlocked(bool inIsUnlocked)
	{
	}

	private void SetupIcon(bool inIsUnlocked)
	{
	}

	private void SetupText(bool inIsUnlocked)
	{
	}

	private void SetupCompleted(bool inIsCompleted)
	{
	}
}
