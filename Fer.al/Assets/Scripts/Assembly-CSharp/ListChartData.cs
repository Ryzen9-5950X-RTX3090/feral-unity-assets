using System;
using System.Collections.Generic;

public class ListChartData : ChartDataObject<ListDef, ListChartData>
{
	public static List<string> GetStringListWithDefID(string inDefID)
	{
		return null;
	}

	public static List<string> GetListWithDefID(string inDefID)
	{
		return null;
	}

	public static List<T> GetGenericListWithDefID<T>(Func<string, T> inGetDefWithDefIDFunc, string inListDefID) where T : BaseDef
	{
		return null;
	}

	public static List<string> GetLocalizedStringsFromListWithDefID(string inListDefID)
	{
		return null;
	}
}
