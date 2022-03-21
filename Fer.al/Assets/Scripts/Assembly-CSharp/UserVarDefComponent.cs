[ChartComponent("UserVar")]
public class UserVarDefComponent : DefComponent
{
	[ChartEnum]
	public UserVarType type;

	[ChartBool]
	public bool clientAllowedToSet;

	[ChartBool]
	public bool allowMultiples;

	[ChartInt]
	public int defaultValue;
}
