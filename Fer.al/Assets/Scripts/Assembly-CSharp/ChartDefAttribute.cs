public class ChartDefAttribute : ChartDrawableFieldAttribute
{
	public string targetChartName;

	public string[] targetChartTemplates;

	private string _searchString;

	public string SearchString
	{
		get
		{
			return null;
		}
		set; }

	public ChartDefAttribute(string inTargetChartName, string[] inTargetChartTemplates)
	{
	}
}
