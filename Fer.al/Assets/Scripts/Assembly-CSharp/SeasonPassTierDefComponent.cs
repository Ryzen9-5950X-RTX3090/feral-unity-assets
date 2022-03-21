using Newtonsoft.Json;
using UnityEngine;

[ChartComponent("Season Pass Tier")]
public class SeasonPassTierDefComponent : DefComponent
{
	[ChartBool]
	public bool isFree;

	[ChartInt]
	public int requiredAuraPoints;

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
