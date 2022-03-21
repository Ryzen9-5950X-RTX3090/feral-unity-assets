using System.Collections;
using UnityEngine;

public class SkinnedCollisionHelper : MonoBehaviour
{
	private class CVertexWeight
	{
		public int index;

		public Vector3 localPosition;

		public float weight;

		public CVertexWeight(int i, Vector3 p, float w)
		{
		}
	}

	private class CWeightList
	{
		public Transform transform;

		public ArrayList weights;
	}

	public bool forceUpdate;

	public bool updateOncePerFrame;

	private CWeightList[] nodeWeights;

	private SkinnedMeshRenderer skinnedMeshRenderer;

	private MeshCollider meshCollider;

	private void Start()
	{
	}

	public void UpdateCollisionMesh()
	{
	}

	private void Update()
	{
	}
}
