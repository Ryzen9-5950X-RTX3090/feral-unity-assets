using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SocialExpanseLinearGenericQuestsCompletionItemComponent : ItemComponent
{
	[SerializeField]
	public List<string> completedQuests;

	public override void OnLoaded()
	{
	}

	public bool HasCompletedQuest(string socialExpanseLinearGenericQuestDefId)
	{
		return default(bool);
	}
}
