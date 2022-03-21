using System;
using UnityEngine;

public class EnumListAttribute : PropertyAttribute
{
	public readonly Type enumType;

	public readonly float labelWidthPercent;

	public readonly bool isEnum;

	public readonly string[] enumNames;

	public EnumListAttribute(Type inEnumType, float inLabelWidthPercent = 0.35f)
	{
	}

	public static int EnumValueToIndex<T>(T enumValue) where T : struct, IConvertible
	{
		return default(int);
	}

	public static T EnumIndexToValue<T>(int index, T defaultValue) where T : struct, IConvertible
	{
		return (T)null;
	}
}
