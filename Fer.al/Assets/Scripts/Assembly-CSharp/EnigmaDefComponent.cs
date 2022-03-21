[ChartComponent("Enigma")]
public class EnigmaDefComponent : DefComponent
{
	[ChartDef("CraftableItem", new string[] { })]
	public string itemDefID;

	[ChartList]
	public ChartDefList recipe;
}
