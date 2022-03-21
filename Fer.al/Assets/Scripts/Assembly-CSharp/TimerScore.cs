using System;

[Serializable]
public class TimerScore
{
	[ChartInt]
	public int seconds;

	[ChartInt]
	public int pointsPerSecond;
}
