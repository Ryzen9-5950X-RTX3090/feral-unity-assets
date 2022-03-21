using System;

[AttributeUsage(AttributeTargets.Method)]
public class ChartSearchAttribute : Attribute
{
	public string label;

	public ChartSearchAttribute(string inLabel)
	{
	}
}
