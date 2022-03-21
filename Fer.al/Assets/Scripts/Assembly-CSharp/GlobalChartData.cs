public class GlobalChartData : ChartDataObject<BaseDef, GlobalChartData>
{
	public static int GetIntWithDefID(string inDefID, int inDefaultValueIfDefNotFound = 0, bool inShowErrors = false)
	{
		return default(int);
	}

	public static int GetIntWithDefName(string inDefName, int inDefaultValueIfDefNotFound = 0)
	{
		return default(int);
	}

	public static float GetFloatWithDefID(string inDefID, float inDefaultValueIfDefNotFound = 0f)
	{
		return default(float);
	}

	public static float GetFloatWithDefName(string inDefName, float inDefaultValueIfDefNotFound = 0f)
	{
		return default(float);
	}

	public static string GetStringWithDefID(string inDefID, string inDefaultValueIfDefNotFound = "")
	{
		return null;
	}

	public static string GetStringWithDefName(string inDefName, string inDefaultValueIfDefNotFound = "")
	{
		return null;
	}

	public static bool GetBoolWithDefID(string inDefID, bool inDefaultValueIfDefNotFound = false)
	{
		return default(bool);
	}

	public static bool GetBoolWithDefName(string inDefName, bool inDefaultValueIfDefNotFound = false, bool inShowErrors = false)
	{
		return default(bool);
	}
}
