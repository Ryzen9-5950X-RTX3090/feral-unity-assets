using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Audio/Volumes/VA Mesh")]
public class VA_Mesh : VA_VolumetricShape
{
	[Tooltip("If you set this, then all shape settings will automatically be copied from the collider")]
	public MeshCollider MeshCollider;

	[Tooltip("If you set this, then all shape settings will automatically be copied from the collider")]
	public MeshFilter MeshFilter;

	[Tooltip("The mesh of the mesh shape (if you set MeshCollider or MeshFilter, this will be automatically overwritten)")]
	public Mesh Mesh;

	[Tooltip("How far apart each volume checking ray should be separated to avoid miscalculations. This value should be based on the size of your mesh, but be kept quite low")]
	public float RaySeparation;

	[SerializeField]
	private VA_MeshTree tree;

	public bool IsBaked
	{
		get
		{
			return default(bool);
		}
	}

	public void ClearBake()
	{
	}

	public void Bake()
	{
	}

	protected virtual void Reset()
	{
	}

	protected override void LateUpdate()
	{
	}

	private Vector3 FindClosestLocalPoint(Vector3 localPoint)
	{
		return default(Vector3);
	}

	private void UpdateFields()
	{
	}

	private int RaycastHitCount(Vector3 origin, Vector3 direction, float separation)
	{
		return default(int);
	}

	private bool LocalPointInMesh(Vector3 localPoint, Vector3 worldPoint)
	{
		return default(bool);
	}

	private Vector3 SnapLocalPoint(Vector3 localPoint)
	{
		return default(Vector3);
	}
}
