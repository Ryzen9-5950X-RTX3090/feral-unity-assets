using UnityEngine;

public class RootSelectorAttribute : PropertyAttribute
{
	public readonly string label;

	public readonly string rootObjectName;

	public readonly bool returnsDefNameInsteadOfID;

	public readonly bool customDraw;

	public RootSelectorAttribute(string label, string rootObjectName, bool returnsDefNameInsteadOfID = false, bool customDraw = false)
	{
	}
}
