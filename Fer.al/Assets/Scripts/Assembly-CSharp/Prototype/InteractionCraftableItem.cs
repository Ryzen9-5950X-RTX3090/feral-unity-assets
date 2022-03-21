namespace Prototype
{
	public class InteractionCraftableItem : Interaction
	{
		[RootSelector("CraftableItem", "CraftableItemChartData", false, false)]
		public string defId;
	}
}
