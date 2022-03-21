[ChartComponent("Purchase Rare Chance")]
public class PurchaseRareChanceDefComponent : DefComponent
{
	[ChartInt]
	public int rareChance;

	[ChartDef("CraftableItem", new string[] { })]
	public string itemDefID;
}
