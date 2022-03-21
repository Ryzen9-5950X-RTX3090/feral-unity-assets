using System;
using System.Collections.Generic;
using LitJson;
using UnityEngine;

[Serializable]
public class DailyQuestInteractableItemComponent : ItemComponent
{
	[Serializable]
	public class DailyQuestData
	{
		public long lastCompletionTime;

		public DailyQuestData(long lastCompletionTime)
		{
		}
	}

	[SerializeField]
	private Dictionary<string, DailyQuestData> dailyQuests;

	internal Dictionary<string, DailyQuestData> DailyQuests
	{
		get
		{
			return null;
		}
	}

	public override void OnLoaded()
	{
	}

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}

	internal static bool isTodayDialyQuestCheck(long inLastCompletionTime)
	{
		return default(bool);
	}
}
