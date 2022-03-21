using System;

[Serializable]
public enum ChartDateRepeatMode
{
	OnlyStartDay,
	EveryDayInRange,
	EveryStartDayInRange,
	EveryWeekDayInRange,
	EveryWeekendDayInRange
}
