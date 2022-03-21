using System;
using System.Runtime.InteropServices;

public class RootSelectorCompactAttribute : RootSelectorAttribute
{
	public readonly Type enumTypeConstraint;

	public readonly bool isEnum;

	public readonly string[] enumNames;

	public RootSelectorCompactAttribute(string label, string rootObjectName, [Optional] Type enumTypeConstraint, bool returnsDefNameInsteadOfID = false, bool customDraw = false)
	{
	}
}
