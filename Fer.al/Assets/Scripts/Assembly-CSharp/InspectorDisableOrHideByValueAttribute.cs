using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class InspectorDisableOrHideByValueAttribute : PropertyAttribute
{
	public readonly string valueName;

	public readonly bool whenValueIs;

	public readonly bool hide;

	public InspectorDisableOrHideByValueAttribute(string inValueName, bool inWhenValueIs = false, bool inHide = false)
	{
	}
}
