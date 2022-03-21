using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class InspectorOnGUIAttribute : PropertyAttribute
{
	public readonly string methodBaseName;

	public InspectorOnGUIAttribute(string inMethodBaseName)
	{
	}
}
