using System;
using UnityEngine;

public class BundleDownloadCollection : QRoutineCollection
{
	private GameObject _targetGameObject;

	public BundleDownloadCollection(GameObject inTargetGameObject)
	{
	}

	public QRoutine AddBundleGlobalLoadIfExists<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal) where T : UnityEngine.Object
	{
		return null;
	}

	public QRoutine AddBundleGlobalLoad<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal) where T : UnityEngine.Object
	{
		return null;
	}

	public QRoutine AddBundleLoadIfExists<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal) where T : UnityEngine.Object
	{
		return null;
	}

	public QRoutine AddBundleLoad<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal) where T : UnityEngine.Object
	{
		return null;
	}

	public QRoutine AddBundleInstantiateIfExists<T>(string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal) where T : UnityEngine.Object
	{
		return null;
	}

	public QRoutine AddBundleInstantiate<T>(string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal) where T : UnityEngine.Object
	{
		return null;
	}
}
