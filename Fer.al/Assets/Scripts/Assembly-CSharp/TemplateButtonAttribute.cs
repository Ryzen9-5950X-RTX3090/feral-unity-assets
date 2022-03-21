using System;

[AttributeUsage(AttributeTargets.Method)]
public class TemplateButtonAttribute : TemplateDrawableAttribute
{
	public string label;

	public TemplateButtonAttribute(string inButtonLabel)
	{
	}
}
