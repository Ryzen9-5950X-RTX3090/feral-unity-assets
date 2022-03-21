using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorldObjectManager : SingletonManagerBase<WorldObjectManager>
{
	private class ObjectCollection
	{
		private Dictionary<string, WorldObject> _objectsById;

		private Dictionary<string, WorldObject> _objectsByUserUUID;

		public WorldObject GetByObjectId(string objectId)
		{
			return null;
		}

		public WorldObject GetByUserUUID(string uuid)
		{
			return null;
		}

		public void Add(WorldObject o)
		{
		}

		public void TrackUser(UserInfo inUser, WorldObject inObject)
		{
		}

		private void Remove(WorldObject o)
		{
		}

		public void RemoveByObjectId(string objectId)
		{
		}

		public void Clear()
		{
		}
	}

	private ObjectCollection _objects;

	private MethodInfo _createObjectMethodInfo;

	private BundleDownloadCollection _prefabBundleDownloadCollection;

	private bool _initializerNeedsSorting;

	private List<WorldObjectInfoMessage> _worldObjectMessagesToInitialize;

	private IEnumerator _onWorldObjectInfoMessageInitializer;

	private static Dictionary<string, WorldObject> _prefabsByDefId;

	public override void Init()
	{
	}

	public override bool HasFinishCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<FinishCoroutine>d__6))]
	public override IEnumerator FinishCoroutine()
	{
		return null;
	}

	public override void Deinit()
	{
	}

	public static WorldObject GetByObjectId(string objectId)
	{
		return null;
	}

	public static WorldObject GetByUserUUID(string uuid)
	{
		return null;
	}

	public static void RemoveByObjectId(string objectId)
	{
	}

	public static void TrackUser(UserInfo inUser, WorldObject inObject)
	{
	}

	private void OnLevelLoading(Message inMessage)
	{
	}

	[IteratorStateMachine(typeof(<OnWorldObjectInfoMessageInitializer>d__16))]
	private IEnumerator OnWorldObjectInfoMessageInitializer()
	{
		return null;
	}

	private void OnWorldObjectInfoMessage(WorldObjectInfoMessage message)
	{
	}

	internal void ResetInitializerIfNeeded()
	{
	}

	private void WorldObjectInitialize(WorldObjectInfoMessage message)
	{
	}

	private void OnWorldObjectInfoAvatarLocalMessage(WorldObjectInfoAvatarLocalMessage message)
	{
	}

	private void ForceDestroy(WorldObject inWorldObject)
	{
	}

	private void OnWorldObjectActionStartMessage(WorldObjectActionStartMessage inMessage)
	{
	}

	private void OnWorldObjectActionCancelMessage(WorldObjectActionCancelMessage inMessage)
	{
	}

	private void OnWorldObjectActionFinishMessage(WorldObjectActionFinishMessage inMessage)
	{
	}

	public static GameObject CreateClone<T>(string inWorldObjectDefID, WorldObject<T> inObjectToClone, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback) where T : WorldObjectInfo
	{
		return null;
	}

	public static GameObject CreateClone<T>(WorldObject<T> inObjectToClone, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback) where T : WorldObjectInfo
	{
		return null;
	}

	public static GameObject Create<T>(string inWorldObjectDefID, T inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback) where T : WorldObjectInfo
	{
		return null;
	}

	public static GameObject CreateWithID<T>(string inWorldObjectInstanceID, string inWorldObjectDefID, T inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback) where T : WorldObjectInfo
	{
		return null;
	}

	private WorldObject CreateObject(WorldObjectInfoMessage message)
	{
		return null;
	}

	public static WorldObject GetPrefabWithDefID(string inPrefabDefID)
	{
		return null;
	}

	public static void ClearPrefabs()
	{
	}

	private void DownloadPrefabs()
	{
	}
}
