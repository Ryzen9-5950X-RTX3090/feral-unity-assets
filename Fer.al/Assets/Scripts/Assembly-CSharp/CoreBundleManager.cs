using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class CoreBundleManager : CoreManagerBase<CoreBundleManager>
{
	private int? _maxActiveBundles;

	private int? _maxConcurrentDownloads;

	public List<BundleDownloadQueue> downloadingBundleQueueList;

	public static Dictionary<string, string> streamingAssetsFileList;

	private Dictionary<BundleQueue, List<DownloadingBundle>> _downloadBundleQueueByID;

	public List<DownloadingBundle> currentDownloadingBundles;

	public int? overrideConcurrentDownloads;

	private static string[] _nonePostfixes;

	private static string[] _lqPostfixes;

	private static string[] _mqPostfixes;

	private static string[] _hqPostfixes;

	private static Dictionary<string, AssetBundle> _loadedGlobalAssetBundles;

	private static Dictionary<string, AssetBundle> _loadedStandardAssetBundles;

	private static Dictionary<string, AssetBundle> _loadedLevelAssetBundles;

	private HashSet<string> _currentAsyncAssetsLoading;

	private static string[] _platformNames;

	private static Dictionary<string, string> _getBundleFileNameCache;

	private int MaxActiveBundles
	{
		get
		{
			return default(int);
		}
	}

	private int MaxConcurrentDownloads
	{
		get
		{
			return default(int);
		}
	}

	public Dictionary<BundleQueue, List<DownloadingBundle>> DownloadBundleQueueByID
	{
		get
		{
			return null;
		}
	}

	public List<DownloadingBundle> CurrentDownloadingBundleQueue
	{
		get
		{
			return null;
		}
	}

	public static string[] PlatformNames
	{
		get
		{
			return null;
		}
	}

	public DownloadingBundle GetDownloadingBundleFromQueue(BundleQueue inQueueID, ManifestDef inManifestDef)
	{
		return null;
	}

	public DownloadingBundle AddDownloadToQueue(BundleQueue inQueueID, ManifestDef inManifestDef)
	{
		return null;
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__18))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadStreamingAssetsManifest>d__19))]
	private IEnumerator LoadStreamingAssetsManifest()
	{
		return null;
	}

	public float? GetDownloadProgressForDownloadingBundle(BundleQueue inQueueID, ManifestDef inManifestDef)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DownloadBundles>d__21))]
	private IEnumerator DownloadBundles()
	{
		return null;
	}

	private static void HandleDownloadFailure(DownloadingBundle downloadingBundle)
	{
	}

	public static T[] GetLocalAssetsAtPath<T>(string path) where T : class
	{
		return null;
	}

	public static string RepairBundleIDString(string inString)
	{
		return null;
	}

	public ManifestDef GetManifestDefForPathWithQualityLevel(string inPath, AssetQualityLevel inQualityLevel)
	{
		return null;
	}

	public static Dictionary<string, AssetBundle> GetAssetBundleListForType(BundleLoadType inType)
	{
		return null;
	}

	private AssetBundle LoadAssetBundle(ManifestDef inDef, BundleLoadType inType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadAssetBundleAsync>d__35))]
	private IEnumerator LoadAssetBundleAsync(ManifestDef inDef, BundleLoadType inType, Action<AssetBundle> returnBundle)
	{
		return null;
	}

	public bool CheckIfAssetBundleMatchesDefID(ManifestDef inDef, ref AssetBundle inBundle)
	{
		return default(bool);
	}

	public void UnloadAssetBundle(ManifestDef inDef, BundleLoadType inType, bool inFullUnload)
	{
	}

	public void UnloadAssetBundle(string inPath, AssetQualityLevel inQuality, BundleLoadType inType, bool inFullUnload)
	{
	}

	public static void UnloadAllAssetBundles(BundleLoadType inType, bool inFullUnload)
	{
	}

	public static void ForceUnloadAllAssetBundles()
	{
	}

	public T LoadBundledAssetNow<T>(string inPath, BundleLoadType inType = BundleLoadType.LoadAsset, AssetQualityLevel inQuality = AssetQualityLevel.Low) where T : UnityEngine.Object
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadBundledAsset>d__43<>))]
	public IEnumerator LoadBundledAsset<T>(string inPath, Action<T> inResult, BundleLoadType inType = BundleLoadType.LoadAsset, BundleQueue inQueue = BundleQueue.Default, AssetQualityLevel inQuality = AssetQualityLevel.Low, bool inAttemptNonasync = false, bool inManualBundleUnload = false) where T : UnityEngine.Object
	{
		return null;
	}

	[IteratorStateMachine(typeof(<UnloadAssetBundleAtEndOfFrame>d__44))]
	private IEnumerator UnloadAssetBundleAtEndOfFrame(string inPath, ManifestDef inDef, BundleLoadType inType, bool inFullUnload = false)
	{
		return null;
	}

	private static string[] GetPostFixes(AssetQualityLevel inAssetQualityLevel)
	{
		return null;
	}

	private T LoadLocalAsset<T>(string inPath, AssetQualityLevel inQualityLevel) where T : UnityEngine.Object
	{
		return null;
	}

	public static SimplePlatform GetSimplePlatformFromBuildTarget()
	{
		return default(SimplePlatform);
	}

	public static SimplePlatform GetSimplePlatformFromRunTime()
	{
		return default(SimplePlatform);
	}

	public static int IndexOf(StringBuilder sb, string value, int startIndex, bool ignoreCase)
	{
		return default(int);
	}

	public static string GetBundleIDFromFileName(string inBundleFileName)
	{
		return null;
	}

	public static string GetBundleName(string inBundlePath)
	{
		return null;
	}

	public static string GetBundleFileName(string inBundlePath, bool inEditorMode = false)
	{
		return null;
	}
}
