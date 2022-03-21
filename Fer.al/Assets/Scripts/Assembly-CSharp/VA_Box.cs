using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Audio/Volumes/VA Box")]
public class VA_Box : VA_VolumetricShape
{
	[Tooltip("If you set this, then all shape settings will automatically be copied from the collider")]
	public BoxCollider BoxCollider;

	[Tooltip("The center of the box shape (if you set BoxCollider, this will be automatically overwritten)")]
	public Vector3 Center;

	[Tooltip("The size of the box shape (if you set BoxCollider, this will be automatically overwritten)")]
	public Vector3 Size;

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

	private bool LocalPointInBox(Vector3 localPoint)
	{
		return default(bool);
	}

	private Vector3 SnapLocalPoint(Vector3 localPoint)
	{
		return default(Vector3);
	}

	private Vector3 ClipLocalPoint(Vector3 localPoint)
	{
		return default(Vector3);
	}
}
