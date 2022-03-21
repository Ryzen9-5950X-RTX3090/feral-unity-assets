[ChartComponent("ShopContent")]
public class ShopContentDefComponent : DefComponent
{
	[ChartBool]
	public bool isDebug;

	[ChartEnum]
	public EIdentity identity;

	[ChartDef("ShopContent", new string[] { })]
	public string shopContentDefID;

	[ChartDef("List", new string[] { })]
	public string enigmaUnlockListDefID;

	[ChartDef("Level", new string[] { })]
	public string backgroundEnvironmentLevelDefId;
}
