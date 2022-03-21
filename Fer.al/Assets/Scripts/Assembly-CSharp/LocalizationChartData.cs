using System.Collections.Generic;
using UnityEngine;

public class LocalizationChartData : ChartDataObject<LocalizationDef, LocalizationChartData>
{
	public static Dictionary<SystemLanguage, string> systemLanguageToAbbreviationMap;

	public static Dictionary<string, SystemLanguage> abbrevationToSystemLanguageMap;

	public static SystemLanguage GetCurrentSystemLanguage()
	{
		return default(SystemLanguage);
	}

	public static string GetLanguageAbbreviation(SystemLanguage inLanguage)
	{
		return null;
	}

	public static string GetCurrentLanguageAbbreviation()
	{
		return null;
	}

	public static SystemLanguage GetSystemLanguageByAbbreviation(string abbreviation)
	{
		return default(SystemLanguage);
	}

	public static string Format(string inDefID, object[] parameters)
	{
		return null;
	}

	public static string GetString(string inDefID)
	{
		return null;
	}

	public string Get(string inDefID, string inDefault = "-1")
	{
		return null;
	}
}
