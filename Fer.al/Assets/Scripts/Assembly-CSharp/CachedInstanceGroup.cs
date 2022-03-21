using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CachedInstanceGroup
{
	public string editorGroupName;

	[NonSerialized]
	public ActorCacheGroup cacheGroup;

	public Transform transform;

	public bool useReferences;

	public int maxCount;

	public float timeout;

	public List<string> pendingHashes;

	public List<ActorCachedInstance> instances;

	public ActorCacheGroup ActorCacheGroup
	{
		get
		{
			return default(ActorCacheGroup);
		}
		set
		{
		}
	}
}
