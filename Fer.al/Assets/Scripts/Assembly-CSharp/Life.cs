using System;
using System.Collections.Generic;
using UnityEngine;

public class Life : ManagedBehaviour
{
	[Serializable]
	public class ObjectInfo
	{
		public GameObject prefab;

		public Vector3 position;

		public Vector3 rotation;
	}

	[Serializable]
	public class TreeInfo
	{
		public List<int> terrainTreeIndexes;

		public ObjectInfo[] objectInfos;
	}

	[SerializeField]
	private TreeInfo[] treeInfos;

	public override void MStart()
	{
	}

	private void AttachToTrees()
	{
	}

	private void SpawnObjects(TreeInfo inTreeInfo, TreeInstance inTreeInstance)
	{
	}
}
