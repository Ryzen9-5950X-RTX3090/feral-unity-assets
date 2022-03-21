using UnityEngine;

[ChartComponent("Localization")]
public class LocalizationDefComponent : DefComponent
{
	[ChartBool]
	public bool needsTranslation;

	[ChartMultiLineString]
	public string en;

	[ChartMultiLineString]
	public string fr;

	[ChartMultiLineString]
	public string de;

	[ChartMultiLineString]
	public string es;

	[ChartMultiLineString]
	public string pt;

	public string LocalizedString
	{
		get
		{
			return null;
		}
	}

	[ChartSearch("Needs Translation")]
	public static bool NeedsTranslationSearch(DefComponent inDefComponent, string inSearch)
	{
		return default(bool);
	}

	public string GetLocalizedStringWithLanguage(SystemLanguage inSystemLanguage)
	{
		return null;
	}
}
