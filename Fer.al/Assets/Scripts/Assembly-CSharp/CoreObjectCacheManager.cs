using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class CoreObjectCacheManager : CoreManagerBase<CoreObjectCacheManager>
{
	[Serializable]
	public class CachedObject
	{
		public string bundleID;

		public bool forceCachedTexture;

		public UnityEngine.Object objectReference;

		public List<GameObject> gameObjectReferences;

		public bool manualUnload;

		public BundleLoadType bundleLoadType;

		public string bundlePath;

		public AssetQualityLevel qualityLevel;
	}

	public List<CachedObject> _cachedObjects;

	private string _forcedCachedPrefix;

	private int _fixDuplicateCache;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private string GetStoredBundleID(string inBundleID, AssetQualityLevel inQuality, Type inType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetAndSetCachedTexture>d__6<>))]
	public IEnumerator GetAndSetCachedTexture<T>(UnityEngine.Object inObject, GameObject inGameObjectReference, [Optional] Action<T> inObjectCallback) where T : UnityEngine.Object
	{
		return null;
	}

	private void DestroyForcedCachedObject(CachedObject inCachedObject)
	{
	}

	[IteratorStateMachine(typeof(<GetCachedObject>d__8<>))]
	public IEnumerator GetCachedObject<T>(string inBundleID, GameObject inGameObjectReference, BundleLoadType inBundleLoadType, BundleQueue inBundleQueue, [Optional] Action<T> inObjectCallback, AssetQualityLevel inQuality = AssetQualityLevel.None, string inPriorBundleID = "", bool inManualBundleUnload = false) where T : UnityEngine.Object
	{
		return null;
	}

	public void ClearCachedObject(string inBundleID, AssetQualityLevel inQuality, Type inType, GameObject inGameObjectReference)
	{
	}

	public void ClearCachedObject(GameObject inGameObjectReference)
	{
	}

	[IteratorStateMachine(typeof(<CacheRoutine>d__12))]
	private IEnumerator CacheRoutine()
	{
		return null;
	}

	private void FixDuplicateCache(int inIdx)
	{
	}
}
