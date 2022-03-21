using System;
using System.Collections.Generic;

public class ColorChartData : ChartDataObject<ColorDef, ColorChartData>
{
	[NonSerialized]
	private List<ColorDef> _avatarBodyColorList;

	[NonSerialized]
	private List<ColorDef> _avatarPatternColorList;

	[NonSerialized]
	private List<ColorDef> _avatarEyeColorList;

	public List<ColorDef> AvatarBodyColorList
	{
		get
		{
			return null;
		}
	}

	public List<ColorDef> AvatarPatternColorList
	{
		get
		{
			return null;
		}
	}

	public List<ColorDef> AvatarEyeColorList
	{
		get
		{
			return null;
		}
	}

	public override void WriteCSVChart()
	{
	}
}
