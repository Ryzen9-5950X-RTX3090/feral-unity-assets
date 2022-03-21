using System.Collections.Generic;
using UnityEngine.UI;

public class FeralAudioStats : ManagedBehaviour
{
	private class StatsEntry
	{
		public int index;

		public float dspUsage;

		public float studioUsage;

		public int memoryAlloc;

		public int realChannels;

		public int totalChannels;

		public StatsEntry(int tI, float dU, float sU, int mA, int rC, int tC)
		{
		}

		public string GetStats()
		{
			return null;
		}
	}

	public Text dspCPUText;

	public Text studioCPUText;

	public Text memoryText;

	public Text realChannelText;

	public Text totalChannelText;

	private float updateStatsTime;

	private float elapsedWaitTime;

	private bool systemValid;

	private List<StatsEntry> statsEntries;

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	public void LogStatEntries()
	{
	}

	private void UpdateStats()
	{
	}

	private void DrawStats(StatsEntry entry)
	{
	}
}
