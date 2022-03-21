using System.Collections.Generic;
using UnityEngine;

[ChartComponent("Default Colors")]
public class DefaultColorsDefComponent : DefComponent
{
	[ChartList]
	[ChartHSV]
	public List<HSVColor> defaultColors;

	public void ApplyColorsToRenderer(Renderer inTargetRenderer)
	{
	}

	public void ApplyColorsToMaterial(Material inMaterial)
	{
	}
}
