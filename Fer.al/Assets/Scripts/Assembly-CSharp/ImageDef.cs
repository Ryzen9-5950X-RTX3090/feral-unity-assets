using System;
using System.Collections.Generic;

[Serializable]
public class ImageDef : BundledDef
{
	public bool localize;

	public bool highQualityAndLowQuality;

	public List<string> bundleIDArray;

	public List<string> calendarRefArray;

	public bool isAvailable
	{
		get
		{
			return default(bool);
		}
	}

	public override void LoadEntry()
	{
	}
}
