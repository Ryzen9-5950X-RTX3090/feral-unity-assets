using System.Collections.Generic;

[ChartComponent("Item List")]
public class ListDefComponent : DefComponent
{
	[ChartList]
	[ChartDef("CraftableItem", new string[] { })]
	public ChartDefList list;

	public List<string> DefIDs
	{
		get
		{
			return null;
		}
	}

	public List<BaseDef> Defs
	{
		get
		{
			return null;
		}
	}
}
