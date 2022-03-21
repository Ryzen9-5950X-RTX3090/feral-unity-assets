using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class Buoyancy : ManagedBehaviour
{
	[SerializeField]
	private Vector3 _centerOfMass;

	[SerializeField]
	private float density;

	[SerializeField]
	private int slicesPerAxis;

	[SerializeField]
	private bool isConcave;

	[SerializeField]
	private int voxelsLimit;

	private const float DAMPFER = 0.1f;

	private const float WATER_DENSITY = 1000f;

	private float voxelHalfHeight;

	private Vector3 localArchimedesForce;

	private List<Vector3> voxels;

	private bool isMeshCollider;

	private List<Vector3[]> forces;

	private Collider _collider;

	private Rigidbody _rigidbody;

	public override void MStart()
	{
	}

	private List<Vector3> SliceIntoVoxels(bool concave)
	{
		return null;
	}

	private static bool PointIsInsideMeshCollider(Collider c, Vector3 p)
	{
		return default(bool);
	}

	private static void FindClosestPoints(IList<Vector3> list, out int firstIndex, out int secondIndex)
	{
	}

	private static void WeldPoints(IList<Vector3> list, int targetCount)
	{
	}

	private float GetWaterLevel(float x, float z)
	{
		return default(float);
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
