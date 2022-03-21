using System.Collections.Generic;
using System.Diagnostics;

public static class StopwatchTracking
{
	private class StopwatchEntry
	{
		public string name;

		public long millisecs;
	}

	private const bool ENABLED = false;

	private static List<StopwatchEntry> _stopwatchTrackingList;

	private static Dictionary<string, Stopwatch> _currentStopwatches;

	private static List<StopwatchEntry> StopwatchTrackingList
	{
		get
		{
			return null;
		}
	}

	private static Dictionary<string, Stopwatch> CurrentStopwatches
	{
		get
		{
			return null;
		}
	}

	[Conditional("DEBUG")]
	public static void StartStopwatch(string inName)
	{
	}

	[Conditional("DEBUG")]
	public static void FinishStopwatch(string inName)
	{
	}

	[Conditional("DEBUG")]
	public static void WriteStopwatchTrackingToDisk(bool inSorted = true)
	{
	}
}
