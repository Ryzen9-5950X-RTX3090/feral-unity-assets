using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class SimpleGameObjectPool : MonoBehaviour
{
	private class PooledObject
	{
		public GameObject gameObject;

		public float inactiveTime;
	}

	private GameObject _prefabInstance;

	private string _poolID;

	private static GameObject _poolGroup;

	private static Dictionary<string, SimpleGameObjectPool> _poolsByID;

	private List<GameObject> _poolClients;

	private bool _isReady;

	private List<PooledObject> _inactiveObjects;

	private List<PooledObject> _activeObjects;

	private float _objectDestroyTime;

	private float _poolDestroyTime;

	private float _poolDestroyTimer;

	private int _minimumPooled;

	private static GameObject PoolGroup
	{
		get
		{
			return null;
		}
	}

	public bool IsReady
	{
		get
		{
			return default(bool);
		}
	}

	public static bool HasPool(string inID)
	{
		return default(bool);
	}

	public static SimpleGameObjectPool GetPool(string inID, GameObject inClient)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<CreatePoolWithBundle>d__19))]
	public static IEnumerator CreatePoolWithBundle(string inBundleID, GameObject inClient, int inMinimum = -1, float inObjectDestroyTime = 5f, float inPoolDestroyTime = 30f)
	{
		return null;
	}

	public static SimpleGameObjectPool CreatePoolWithGameObject(string inID, GameObject inClient, GameObject inPrefabInstance, int inMinimum = -1, float inObjectDestroyTime = 5f, float inPoolDestroyTime = 30f)
	{
		return null;
	}

	private void Prime()
	{
	}

	private void OnDestroy()
	{
	}

	public void RegisterPoolClient(GameObject inGameObject)
	{
	}

	public void UnregisterPoolClient(GameObject inGameObject)
	{
	}

	[IteratorStateMachine(typeof(<InstantiateWhenReady>d__25))]
	public IEnumerator InstantiateWhenReady([Optional] Vector3 inPos, [Optional] Quaternion inRot, [Optional] Action<GameObject> inResult)
	{
		return null;
	}

	public void Instantiate([Optional] Vector3 inPos, [Optional] Quaternion inRot, [Optional] Action<GameObject> inResult)
	{
	}

	private void Update()
	{
	}
}
