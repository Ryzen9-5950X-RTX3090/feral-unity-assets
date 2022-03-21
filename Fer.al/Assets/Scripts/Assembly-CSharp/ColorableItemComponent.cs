using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[Serializable]
public class ColorableItemComponent : ItemComponent
{
	public HSVColor color1HSV;

	public HSVColor color2HSV;

	public HSVColor color3HSV;

	public HSVColor color4HSV;

	private ColorableDefComponent _defComponent;

	private ColorableDefComponent DefComponent
	{
		get
		{
			return null;
		}
	}

	public int AvailableChannels
	{
		get
		{
			return default(int);
		}
	}

	public HSVColor Color1HSVDefault
	{
		get
		{
			return default(HSVColor);
		}
	}

	public HSVColor Color2HSVDefault
	{
		get
		{
			return default(HSVColor);
		}
	}

	public HSVColor Color3HSVDefault
	{
		get
		{
			return default(HSVColor);
		}
	}

	public HSVColor Color4HSVDefault
	{
		get
		{
			return default(HSVColor);
		}
	}

	public HSVColor GetDefaultColor(int inChannelIndex)
	{
		return default(HSVColor);
	}

	public HSVColor GetColor(int inChannelIndex)
	{
		return default(HSVColor);
	}

	public void SetColor(HSVColor inColor, int inChannelIndex)
	{
	}

	public void ApplyColorsToMaterial(Material inMaterial)
	{
	}

	public void ApplyColorsToRenderer(Renderer inTargetRenderer)
	{
	}

	public void SetAndApplyColor(HSVColor inColor, int inChannelIndex, [Optional] Renderer inTargetRenderer)
	{
	}

	public static void PreviewColorsOnRenderer(List<HSVColor> inColors, Renderer inTargetRenderer)
	{
	}

	public static ColorableItemComponent CreateFromDef(BaseDef inDef)
	{
		return null;
	}
}
