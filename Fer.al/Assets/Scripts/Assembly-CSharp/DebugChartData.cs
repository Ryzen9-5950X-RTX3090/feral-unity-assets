public class DebugChartData : ChartDataObject<DebugDef, DebugChartData>
{
	public static int GetIntWithDefID(string defID, int valueInReleaseMode)
	{
		return default(int);
	}

	public static float GetFloatWithDefID(string defID, float valueInReleaseMode)
	{
		return default(float);
	}

	public static string GetStringWithDefID(string defID, string valueInReleaseMode)
	{
		return null;
	}

	public static bool GetBoolWithDefID(string defID, bool valueInReleaseMode)
	{
		return default(bool);
	}
}
