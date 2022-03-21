using UnityEngine;

[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius;

	[Tooltip("The height of the capsule.")]
	public float m_Height;

	private void OnValidate()
	{
	}

	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(bool);
	}

	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(bool);
	}

	private void OnDrawGizmosSelected()
	{
	}
}
