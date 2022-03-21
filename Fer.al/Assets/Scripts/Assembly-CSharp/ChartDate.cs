using System;
using UnityEngine;

[Serializable]
public class ChartDate
{
	[SerializeField]
	private bool _ignoreYear;

	[SerializeField]
	private ChartDateRepeatMode _repeatMode;

	[SerializeField]
	private string _dateStart;

	[SerializeField]
	private string _dateEnd;

	public bool IgnoreYear
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public ChartDateRepeatMode RepeatMode
	{
		get
		{
			return default(ChartDateRepeatMode);
		}
		set
		{
		}
	}

	public bool UseDateStart
	{
		get
		{
			return default(bool);
		}
	}

	public bool DateStartValid
	{
		get
		{
			return default(bool);
		}
	}

	public DateTime? DateStartAsDateTime
	{
		get
		{
			return null;
		}
	}

	public string DateStart
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long DateStartTicks
	{
		get
		{
			return default(long);
		}
	}

	public bool UseDateEnd
	{
		get
		{
			return default(bool);
		}
	}

	public bool DateEndValid
	{
		get
		{
			return default(bool);
		}
	}

	public DateTime? DateEndAsDateTime
	{
		get
		{
			return null;
		}
	}

	public string DateEnd
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long DateEndTicks
	{
		get
		{
			return default(long);
		}
	}

	public bool IsAvailable
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsAvailableTomorrow
	{
		get
		{
			return default(bool);
		}
	}

	private bool TodayMatchesRepeatingDay
	{
		get
		{
			return default(bool);
		}
	}

	private bool TomorrowMatchesRepeatingDay
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsDateTimeAvailable(string inDateString)
	{
		return default(bool);
	}

	internal void GetIgnoredYearDate(ref DateTime inDateTime)
	{
	}

	public bool IsDateTimeAvailable(DateTime inDateTime)
	{
		return default(bool);
	}

	public bool AvailableTest(DateTime inDateTime)
	{
		return default(bool);
	}

	public static DateTime? ParseDateOrNull(string inDateString)
	{
		return null;
	}

	private bool DateTimeMatchesRepeatingDay(DateTime inDateTime)
	{
		return default(bool);
	}
}
