using System;
using System.Runtime.InteropServices;
using WW.Debug;

public class ContentVisitRecord
{
	private string _visitContentName;

	private string _lastVisitTimeVariableName
	{
		get
		{
			return null;
		}
	}

	public DateTime? LastVisitTime
	{
		get
		{
			return null;
		}
	}

	public ContentVisitRecord(string inVisitContentName, [Optional] string inVisitSubcontentName)
	{
	}

	public void RecordVisit([Optional] DateTime? inTimeOpened)
	{
	}

	[DebugButton("Remove Visited Record", "UI", true, false)]
	private static void DoRemoveVisitedRecord(string inVisitContentName)
	{
	}

	private static string GetLastVisitTimeVariableName(string inVisitContentName)
	{
		return null;
	}
}
