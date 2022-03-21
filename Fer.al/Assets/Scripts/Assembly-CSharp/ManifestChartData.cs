using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ManifestChartData : ChartDataObject<ManifestDef, ManifestChartData>
{
	private static string[] _nonePostfixes;

	private static string[] _lqPostfixes;

	private static string[] _mqPostfixes;

	private static string[] _hqPostfixes;

	private bool? _useNewDownloadUrl;

	private static Dictionary<string, string> _getFilePathFromBundleIDCache;

	private static string _bundleTarCacheFolderPath;

	private static string _bundleCacheFolderPath;

	private static string _bundleIncludedFolderPath;

	public override bool PlatformSpecific
	{
		get
		{
			return default(bool);
		}
	}

	public override string DatabaseName
	{
		get
		{
			return null;
		}
	}

	public bool UseNewDownloadUrl
	{
		get
		{
			return default(bool);
		}
	}

	public static string BundleTarCacheFolderPath
	{
		get
		{
			return null;
		}
	}

	public static string BundleCacheFolderPath
	{
		get
		{
			return null;
		}
	}

	public static string BundleIncludedFolderPath
	{
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	public static string[] GetPostFixesInOrder(AssetQualityLevel inAssetQualityLevel)
	{
		return null;
	}

	public static ManifestDef GetDefWithPathAndQualityLevel(string inPath, AssetQualityLevel inQualityLevel, bool inShowErrors = true)
	{
		return null;
	}

	public static string RepairBundleID(string inBundleID)
	{
		return null;
	}

	public static string GetFilePathFromBundleID(string inBundleID, bool inEditorMode = false)
	{
		return null;
	}

	public static string GetBundleIDFromFilePath(string inBundleFilePath)
	{
		return null;
	}

	public bool PruneBundleCache(int inPruneAgeInHours, long inRequiredBytes = -1L, bool inResetOnRequiredMBFailure = false)
	{
		return default(bool);
	}

	public void ClearTarBundleCache()
	{
	}

	public void ClearBundleCache()
	{
	}

	[IteratorStateMachine(typeof(<Init>d__30))]
	public IEnumerator Init()
	{
		return null;
	}
}
