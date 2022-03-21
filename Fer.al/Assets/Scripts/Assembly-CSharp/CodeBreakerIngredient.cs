using System.Runtime.CompilerServices;
using UnityEngine;

public class CodeBreakerIngredient : MonoBehaviour
{
	public CodeColor color;

	private const float kDestroyFallHeight = -20f;

	public Rigidbody RigidBody
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Collider Collider
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetPhysics(bool inKinematic, bool inColliderEnabled)
	{
	}

	public void Push(Vector3 force)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
