using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class CoreBundleManager2 : CoreManagerBase<CoreBundleManager2>
{
	public enum LoadedAssetBundleState
	{
		Init,
		Downloading,
		Downloaded,
		FailedToDownload,
		Loading,
		Loaded,
		FailedToLoad,
		Ready
	}

	public class LoadedAssetBundleEntry
	{
		public LoadedAssetBundleState state;

		public ManifestDef bundleDef;

		public string bundleID;

		public AssetBundle assetBundle;

		public BundleLoadType loadType;

		public float progress;

		private float _lastRefTime;

		public float downloadProgress;

		private List<GameObject> _references;

		public bool CanTimeout
		{
			get
			{
				return default(bool);
			}
		}

		public float LastRefTime
		{
			get
			{
				return default(float);
			}
		}

		public float TimeLeft
		{
			get
			{
				return default(float);
			}
		}

		public List<GameObject> References
		{
			get
			{
				return null;
			}
		}

		public int RefCount
		{
			get
			{
				return default(int);
			}
		}

		public bool AddReference(GameObject inReferenceObject)
		{
			return default(bool);
		}

		public void UpdateReferences()
		{
		}

		public void Unload(bool inFullUnload)
		{
		}
	}

	public Dictionary<string, Sprite> spriteCache;

	private static string _bundleTarCacheFolderPath;

	private static string _bundleCacheFolderPath;

	private static string _bundleIncludedFolderPath;

	private List<string> _removeLoadedAssetBundles;

	private static Dictionary<string, LoadedAssetBundleEntry> _loadedGlobalAssetBundles;

	private static Dictionary<string, LoadedAssetBundleEntry> _loadedStandardAssetBundles;

	private static Dictionary<string, LoadedAssetBundleEntry> _loadedLevelAssetBundles;

	public static Dictionary<BundleLoadType, Dictionary<string, LoadedAssetBundleEntry>> LoadedAssetBundles;

	private Dictionary<string, Shader> _globalShaders;

	private QRoutineGroup _bundleManagerQRoutineGroup;

	public Dictionary<BundlePriority, QRoutineGroup> qroutineGroupsByPriority;

	private readonly Vector3 _instantiateLocation;

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

	public void SetCachedSprite(string inBundleID, Sprite inSprite)
	{
	}

	public Sprite GetCachedSpriteInstance(string inBundleID)
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

	public static bool FastFileExists(string inFilePath)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InternalDownloadBundleRoutine>d__16))]
	private IEnumerator InternalDownloadBundleRoutine(ManifestDef inDef, LoadedAssetBundleEntry inLoadedAssetBundleEntry)
	{
		return null;
	}

	public void MUpdateUnloadAssetBundlesWithNoRefs(bool inIgnoreTimeouts = false)
	{
	}

	public static void ClearFailedBundles()
	{
	}

	public static LoadedAssetBundleEntry GetLoadedAssetBundleEntryWithManifestDef(ManifestDef inDef)
	{
		return null;
	}

	public static ValueTuple<Dictionary<string, LoadedAssetBundleEntry>, string, LoadedAssetBundleEntry> GetLoadedAssetBundleEntryWithDefID(string inDefID)
	{
		return default(ValueTuple<Dictionary<string, LoadedAssetBundleEntry>, string, LoadedAssetBundleEntry>);
	}

	public static void UnloadAssetBundleWithDefID(string inDefID, bool inFullUnload)
	{
	}

	public static void RemoveAssetBundleReference(string inDefID, GameObject inReference)
	{
	}

	public static void CoreReset()
	{
	}

	[IteratorStateMachine(typeof(<LoadAssetBundleAsync>d__31))]
	private IEnumerator LoadAssetBundleAsync(ManifestDef inDef, BundleLoadType inType, Action<AssetBundle> returnAssetBundle)
	{
		return null;
	}

	public static void UnloadAllAssetBundlesOfType(BundleLoadType inType, bool inFullUnload = true)
	{
	}

	public static void UnloadAllLevelAssetBundles()
	{
	}

	public static void ForceUnloadAllAssetBundles()
	{
	}

	public static void ForceUnloadUnreferencedBundles()
	{
	}

	public Shader GlobalShaderFind(string inName)
	{
		return null;
	}

	private void LoadLocalBundledAsset<T>(string inBundleID, BundleLoadType inType, Action<T> inResult, AssetQualityLevel inQuality) where T : UnityEngine.Object
	{
	}

	public static bool HasLocalAssetAtPath(string inPath, AssetQualityLevel inQualityLevel)
	{
		return default(bool);
	}

	public static bool HasLocalAssetsAtPath(string inPath)
	{
		return default(bool);
	}

	public static T[] GetLocalAssetsAtPath<T>(string path) where T : class
	{
		return null;
	}

	public static T LoadLocalAssetAtPath<T>(string inPath, AssetQualityLevel inQualityLevel, bool inShowWarning = true) where T : UnityEngine.Object
	{
		return null;
	}

	private void InitQRoutine()
	{
	}

	public QRoutineGroup GetQRoutineGroupForGameObject(GameObject inGameObject, BundlePriority inPriority)
	{
		return null;
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__49))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	public override void MUpdate()
	{
	}

	public static bool BundleExists(string inBundleID)
	{
		return default(bool);
	}

	public static QRoutine LoadGlobalAsset<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static IEnumerator LoadGlobalAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static QRoutine LoadBundledLevel(string inBundleID, AssetQualityLevel inQuality = AssetQualityLevel.None, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult)
	{
		return null;
	}

	public static IEnumerator LoadBundledLevelAndWait(string inBundleID, AssetQualityLevel inQuality = AssetQualityLevel.None, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult)
	{
		return null;
	}

	public static QRoutine LoadBundledAsset<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static IEnumerator LoadBundledAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static QRoutine InstantiateBundledAsset<T>(string inBundleID, GameObject inReferenceObject, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static IEnumerator InstantiateBundledAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static bool HasLoadedBundledAsset(string inBundleID, BundleLoadType inType, AssetQualityLevel inQuality)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<ActuallyLoadBundledAsset>d__61<>))]
	private IEnumerator ActuallyLoadBundledAsset<T>(string inBundleID, BundleLoadType inType, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality, Action<LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}
}
