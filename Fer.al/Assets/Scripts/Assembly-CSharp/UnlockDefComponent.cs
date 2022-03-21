using Newtonsoft.Json;
using UnityEngine;

[ChartComponent("Unlock")]
public class UnlockDefComponent : DefComponent
{
	[ChartEnum]
	public UnlockCategory Category;

	[SerializeField]
	[JsonProperty]
	[ChartClass]
	private BundlePackDefComponent.CraftableItemsEntry _unlocks;

	public BundlePackDefComponent.CraftableItemsEntry Unlocks
	{
		get
		{
			return null;
		}
	}
}
