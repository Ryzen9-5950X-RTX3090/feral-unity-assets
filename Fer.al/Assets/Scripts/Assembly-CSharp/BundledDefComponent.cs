using System.Collections.Generic;
using UnityEngine;

public class BundledDefComponent : DefComponent
{
	[Header("Bundle")]
	[Tooltip("Bundle name without full path")]
	public string bundleID;

	private string _fullBundleID;

	public static Dictionary<string, string> bundleIDRootFromChartName;

	public string FullBundleID
	{
		get
		{
			return null;
		}
	}

	protected virtual string FullBundleIDParentPath
	{
		get
		{
			return null;
		}
	}

	public string BundleIDRoot
	{
		get
		{
			return null;
		}
	}

	protected override void LoadEntry()
	{
	}
}
