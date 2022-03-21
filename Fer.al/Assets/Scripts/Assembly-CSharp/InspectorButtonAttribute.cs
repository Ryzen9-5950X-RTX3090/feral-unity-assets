using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class InspectorButtonAttribute : PropertyAttribute
{
	public static float kDefaultButtonWidth;

	public readonly string methodName;

	public readonly string buttonLabel;

	private float _buttonWidth;

	private bool _isToggle;

	public float ButtonWidth
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool IsToggle
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public InspectorButtonAttribute(string inButtonLabel, string inMethodName)
	{
	}
}
