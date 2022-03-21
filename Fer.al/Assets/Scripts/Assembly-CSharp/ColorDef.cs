using System;
using UnityEngine;

[Serializable]
public class ColorDef : BaseDef
{
	private string _primaryColorString;

	private Color? _primaryColorColor;

	private string _bodySecondaryColorString;

	private Color? _bodySecondaryColorColor;

	private string _eyeSecondaryColorString;

	private Color? _eyeSecondaryColorColor;

	public Color primaryColor
	{
		get
		{
			return default(Color);
		}
	}

	public Color bodySecondaryColor
	{
		get
		{
			return default(Color);
		}
	}

	public Color eyeSecondaryColor
	{
		get
		{
			return default(Color);
		}
	}

	public override void LoadEntry()
	{
	}
}
