using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NetworkedSceneGroupListObjects : ManagedBehaviour
{
	[Tooltip("How many are active at once")]
	public int numberAvailable;

	public Transform parentTransform;

	public Interactable.EItemType groupType;

	public List<NetworkedObjectInfo> groupObjects;

	private Dictionary<string, NetworkedObjectInfo> _placedItems;

	private static List<GameObject> _allToTurnOn;

	private static IEnumerator _objectsOnCoroutine;

	private static void AddToTurnOn(GameObject inGO)
	{
	}

	[IteratorStateMachine(typeof(<ObjectsOnCoroutine>d__8))]
	private static IEnumerator ObjectsOnCoroutine()
	{
		return null;
	}

	public override void MOnDestroy()
	{
	}

	private GameObject GetRootGameObject(NetworkedObjectInfo inNetworkedObjectInfo)
	{
		return null;
	}

	private Transform GetRockFlipTransform(Transform inTransform)
	{
		return null;
	}

	internal void QuestSetupGroupObjects(List<string> inObjectsToTurnOn)
	{
	}

	internal void QuestSetupGroupObjects(string inUUID)
	{
	}
}
