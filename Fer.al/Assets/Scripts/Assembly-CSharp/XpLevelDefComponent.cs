using Newtonsoft.Json;
using UnityEngine;

[ChartComponent("XP Level")]
public class XpLevelDefComponent : DefComponent
{
	[ChartInt]
	public int level;

	[ChartInt]
	public int requiredXP;

	[SerializeField]
	[JsonProperty]
	[ChartClass]
	private BundlePackDefComponent.CraftableItemsEntry _reward;

	public BundlePackDefComponent.CraftableItemsEntry Reward
	{
		get
		{
			return null;
		}
	}
}
