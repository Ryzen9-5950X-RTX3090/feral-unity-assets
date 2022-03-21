using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Audio/Volumes/VA Sphere")]
public class VA_Sphere : VA_VolumetricShape
{
	[Tooltip("If you set this, then all shape settings will automatically be copied from the collider")]
	public SphereCollider SphereCollider;

	[Tooltip("The center of the sphere shape (if you set SphereCollider, this will be automatically overwritten)")]
	public Vector3 Center;

	[Tooltip("The radius of the sphere shape (if you set SphereCollider, this will be automatically overwritten)")]
	public float Radius;

	public Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	protected virtual void Reset()
	{
	}

	protected override void LateUpdate()
	{
	}

	private void UpdateFields()
	{
	}

	private bool LocalPointInSphere(Vector3 localPoint)
	{
		return default(bool);
	}

	private Vector3 SnapLocalPoint(Vector3 localPoint)
	{
		return default(Vector3);
	}
}
