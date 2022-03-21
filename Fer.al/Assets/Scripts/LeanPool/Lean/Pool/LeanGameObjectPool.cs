using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Pool
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanPool#LeanGameObjectPool")]
	[AddComponentMenu("Lean/Pool/Lean GameObject Pool")]
	public class LeanGameObjectPool : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		public class Delay
		{
			public GameObject Clone;

			public float Life;
		}

		public enum NotificationType
		{
			None,
			SendMessage,
			BroadcastMessage,
			IPoolable,
			BroadcastIPoolable
		}

		public static LinkedList<LeanGameObjectPool> Instances;

		[SerializeField]
		[FormerlySerializedAs("Prefab")]
		private GameObject prefab;

		public NotificationType Notification;

		public int Preload;

		public int Capacity;

		public bool Recycle;

		public bool Persist;

		public bool Stamp;

		public bool Warnings;

		[SerializeField]
		private List<GameObject> spawnedClonesList;

		private HashSet<GameObject> spawnedClonesHashSet;

		[SerializeField]
		private List<GameObject> despawnedClones;

		[SerializeField]
		private List<Delay> delays;

		private LinkedListNode<LeanGameObjectPool> node;

		private static Dictionary<GameObject, LeanGameObjectPool> prefabMap;

		private static List<IPoolable> tempPoolables;

		public GameObject Prefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Spawned
		{
			get
			{
				return default(int);
			}
		}

		public int Despawned
		{
			get
			{
				return default(int);
			}
		}

		public int Total
		{
			get
			{
				return default(int);
			}
		}

		public static bool TryFindPoolByPrefab(GameObject prefab, ref LeanGameObjectPool foundPool)
		{
			return default(bool);
		}

		public static bool TryFindPoolByClone(GameObject clone, ref LeanGameObjectPool pool)
		{
			return default(bool);
		}

		public void Spawn()
		{
		}

		public GameObject Spawn(Vector3 position, Quaternion rotation, [Optional] Transform parent, bool worldPositionStays = true)
		{
			return null;
		}

		public bool TrySpawn(Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays, ref GameObject clone)
		{
			return default(bool);
		}

		[ContextMenu("Despawn Oldest")]
		public void DespawnOldest()
		{
		}

		private bool TryDespawnOldest(ref GameObject clone, bool registerDespawned)
		{
			return default(bool);
		}

		[ContextMenu("Despawn All")]
		public void DespawnAll()
		{
		}

		public void Despawn(GameObject clone, float t = 0f)
		{
		}

		[ContextMenu("Preload One More")]
		public void PreloadOneMore()
		{
		}

		[ContextMenu("Preload All")]
		public void PreloadAll()
		{
		}

		[ContextMenu("Clean")]
		public void Clean()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void RegisterPrefab()
		{
		}

		private void UnregisterPrefab()
		{
		}

		private void DespawnWithDelay(GameObject clone, float t)
		{
		}

		private void TryDespawn(GameObject clone)
		{
		}

		private void DespawnNow(GameObject clone, bool register = true)
		{
		}

		private GameObject CreateClone(Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays)
		{
			return null;
		}

		private GameObject DoInstantiate(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		private void SpawnClone(GameObject clone, Vector3 position, Quaternion rotation, Transform parent, bool worldPositionStays)
		{
		}

		private void InvokeOnSpawn(GameObject clone)
		{
		}

		private void InvokeOnDespawn(GameObject clone)
		{
		}

		private void MergeSpawnedClonesToList()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
