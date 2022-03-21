using System;

public class CoreDateUtils
{
	public static readonly DateTime _unixTimestampEpoch;

	public const int MS_IN_SEC = 1000;

	private static DateTime? _betaDateTime;

	public static long CurrentTimeTicks
	{
		get
		{
			return default(long);
		}
	}

	public static DateTime Now
	{
		get
		{
			return default(DateTime);
		}
	}

	public static DateTime? BetaDateTime
	{
		get
		{
			return null;
		}
	}

	public static bool IsNowInRange(long dateRangeStart, long dateRangeEnd)
	{
		return default(bool);
	}

	public static bool IsDateInRange(long dateToCheck, long dateRangeStart, long dateRangeEnd)
	{
		return default(bool);
	}

	public static int GetDaysUntilDayOfWeek(DateTime startDate, DayOfWeek dayOfWeek)
	{
		return default(int);
	}

	public static DateTime GetNextDayOfWeek(DateTime startDate, DayOfWeek dayOfWeek)
	{
		return default(DateTime);
	}

	public static int GetDayOfMonth(long inDateTicks)
	{
		return default(int);
	}

	public static int GetDayOfYear(long inDateTicks)
	{
		return default(int);
	}

	public static DateTime GetSpecificDay(long inDateTicks)
	{
		return default(DateTime);
	}

	private static DateTime? GetDebugDateTime()
	{
		return null;
	}

	public static int DateToInt()
	{
		return default(int);
	}

	public static DateTime FromUnixTimestampUtc(long milliseconds)
	{
		return default(DateTime);
	}

	public static long ToUnixTimestamp(DateTime time)
	{
		return default(long);
	}
}
