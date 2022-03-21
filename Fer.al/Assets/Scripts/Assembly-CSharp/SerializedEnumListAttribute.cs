using System;
using UnityEngine;

public class SerializedEnumListAttribute : PropertyAttribute
{
	public readonly Type enumType;

	public readonly float labelWidthPercent;

	public readonly bool isEnum;

	public readonly string[] enumNames;

	public SerializedEnumListAttribute(Type inEnumType, float inLabelWidthPercent = 0.35f)
	{
	}
}
