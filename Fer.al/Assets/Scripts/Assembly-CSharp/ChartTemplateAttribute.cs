using System;

[AttributeUsage(AttributeTargets.Class)]
public class ChartTemplateAttribute : Attribute
{
	public string label;

	public string category;

	public string[] charts;

	public ChartTemplateAttribute(string inLabel, string inCategoryPath, string[] inCharts)
	{
	}
}
