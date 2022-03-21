using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActorCacheManager : SingletonManagerBase<ActorCacheManager>
{
	private Dictionary<string, Material> _materials;

	private Dictionary<string, Sprite> _decals;

	public List<CachedInstanceGroup> _cachedInstanceGroups;

	[NonSerialized]
	private static GameObject _cacheGroupGameObject;

	public static GameObject CacheGroupGameObject
	{
		get
		{
			return null;
		}
	}

	public Material GetMaterialByBundlePath(string inBundlePath)
	{
		return null;
	}

	public Sprite GetDecalSpriteByBundlePath(string inBundlePath)
	{
		return null;
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__5))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	private static void CreateCacheGroupGameObject()
	{
	}

	public void ClearCache()
	{
	}

	public override void Init()
	{
	}

	private CachedInstanceGroup GetCachedInstanceGroup(ActorCacheGroup inGroup)
	{
		return null;
	}

	public ActorCachedInstance GetCachedInstanceWithHash(ActorCacheGroup inGroup, string inHash)
	{
		return null;
	}

	public void SetInstanceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inInstance, bool inClone)
	{
	}

	public GameObject GetNewInstanceWithHash(ActorCacheGroup inGroup, string inHash)
	{
		return null;
	}

	public GameObject GetReferenceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inReference)
	{
		return null;
	}

	public void DereferenceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inReference)
	{
	}

	public void SetPendingWithHash(ActorCacheGroup inGroup, string inHash)
	{
	}

	public void RemovePendingWithHash(ActorCacheGroup inGroup, string inHash)
	{
	}

	public bool IsPendingWithHash(ActorCacheGroup inGroup, string inHash)
	{
		return default(bool);
	}

	public override void MUpdate()
	{
	}
}
