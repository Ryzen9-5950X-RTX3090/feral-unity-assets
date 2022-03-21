using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public static class CoreBundleManager2Extensions
{
	public static QRoutine LoadGlobalBundledAsset<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<CoreBundleManager2.LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static QRoutine LoadBundledAsset<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<CoreBundleManager2.LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadBundledAssetAndWait>d__2<>))]
	public static IEnumerator LoadBundledAssetAndWait<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<CoreBundleManager2.LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static QRoutine InstantiateBundledAsset<T>(this GameObject inGameObject, string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<CoreBundleManager2.LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	[IteratorStateMachine(typeof(<InstantiateBundledAssetAndWait>d__4<>))]
	public static IEnumerator InstantiateBundledAssetAndWait<T>(this GameObject inGameObject, string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal, [Optional] Action<CoreBundleManager2.LoadedAssetBundleEntry> inLoadedAssetBundleResult) where T : UnityEngine.Object
	{
		return null;
	}

	public static ValueTuple<string, string> MultiBundleElements(this string inString)
	{
		return default(ValueTuple<string, string>);
	}
}
