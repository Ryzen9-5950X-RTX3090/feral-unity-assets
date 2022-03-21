using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BundledDef : BaseDef
{
	[Header("Bundle")]
	[Tooltip("Bundle name without full path")]
	public string bundleID;

	public string fullBundleID;

	public static Dictionary<string, string> bundleRootDict;

	public static string RepairBundleIDString(string inString)
	{
		return null;
	}

	public override void LoadEntry()
	{
	}
}
