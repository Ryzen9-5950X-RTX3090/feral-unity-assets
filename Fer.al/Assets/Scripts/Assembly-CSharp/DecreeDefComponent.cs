[ChartComponent("Decree Item")]
public class DecreeDefComponent : DefComponent
{
	public string localizedHeaderDefId;

	public string localizedMessageDefId;

	[ChartDef("Image", new string[] { })]
	public string imageDefID;

	[ChartEnum]
	public DecreeItem.DecreeCategory decreeCategory;

	[ChartEnum]
	public DecreeItem.DecreeLayoutType decreeLayoutType;
}
