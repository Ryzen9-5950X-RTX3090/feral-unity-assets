using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Audio/Volumes/VA Capsule")]
public class VA_Capsule : VA_VolumetricShape
{
	[Tooltip("If you set this, then all shape settings will automatically be copied from the collider")]
	public CapsuleCollider CapsuleCollider;

	[Tooltip("The center of the capsule shape (if you set CapsuleCollider, this will be automatically overwritten)")]
	public Vector3 Center;

	[Tooltip("The radius of the capsule shape (if you set CapsuleCollider, this will be automatically overwritten)")]
	public float Radius;

	[Tooltip("The height of the capsule shape (if you set CapsuleCollider, this will be automatically overwritten)")]
	public float Height;

	[Tooltip("The direction of the capsule shape (if you set CapsuleCollider, this will be automatically overwritten)")]
	public int Direction;

	[Tooltip("mark true if the object moves/resizes and the matrix must be recalculated every frame")]
	public bool _isMoving;

	private static Matrix4x4 RotationX;

	private static Matrix4x4 RotationY;

	private static Matrix4x4 RotationZ;

	private Matrix4x4 _matrix;

	public Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	protected virtual void Reset()
	{
	}

	private void Start()
	{
	}

	protected override void LateUpdate()
	{
	}

	private void UpdateFields()
	{
	}

	private bool LocalPointInCapsule(Vector3 localPoint, float halfHeight)
	{
		return default(bool);
	}

	private Vector3 SnapLocalPoint(Vector3 localPoint, float halfHeight)
	{
		return default(Vector3);
	}
}
