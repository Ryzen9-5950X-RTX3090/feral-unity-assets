using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
	public enum UpdateMode
	{
		Normal,
		AnimatePhysics,
		UnscaledTime
	}

	public enum FreezeAxis
	{
		None,
		X,
		Y,
		Z
	}

	private class Particle
	{
		public Transform m_Transform;

		public int m_ParentIndex;

		public float m_Damping;

		public float m_Elasticity;

		public float m_Stiffness;

		public float m_Inert;

		public float m_Friction;

		public float m_Radius;

		public float m_BoneLength;

		public bool m_isCollide;

		public Vector3 m_Position;

		public Vector3 m_PrevPosition;

		public Vector3 m_EndOffset;

		public Vector3 m_InitLocalPosition;

		public Quaternion m_InitLocalRotation;
	}

	[Tooltip("The root of the transform hierarchy to apply physics.")]
	public Transform m_Root;

	[Tooltip("Internal physics simulation rate.")]
	public float m_UpdateRate;

	public UpdateMode m_UpdateMode;

	[Tooltip("How much the bones slowed down.")]
	[Range(0f, 1f)]
	public float m_Damping;

	public AnimationCurve m_DampingDistrib;

	[Tooltip("How much the force applied to return each bone to original orientation.")]
	[Range(0f, 1f)]
	public float m_Elasticity;

	public AnimationCurve m_ElasticityDistrib;

	[Tooltip("How much bone's original orientation are preserved.")]
	[Range(0f, 1f)]
	public float m_Stiffness;

	public AnimationCurve m_StiffnessDistrib;

	[Tooltip("How much character's position change is ignored in physics simulation.")]
	[Range(0f, 1f)]
	public float m_Inert;

	public AnimationCurve m_InertDistrib;

	[Tooltip("How much the bones slowed down when collide.")]
	public float m_Friction;

	public AnimationCurve m_FrictionDistrib;

	[Tooltip("Each bone can be a sphere to collide with colliders. Radius describe sphere's size.")]
	public float m_Radius;

	public AnimationCurve m_RadiusDistrib;

	[Tooltip("If End Length is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public float m_EndLength;

	[Tooltip("If End Offset is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public Vector3 m_EndOffset;

	[Tooltip("The force apply to bones. Partial force apply to character's initial pose is cancelled out.")]
	public Vector3 m_Gravity;

	[Tooltip("The force apply to bones.")]
	public Vector3 m_Force;

	[Tooltip("Collider objects interact with the bones.")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Tooltip("Bones exclude from physics simulation.")]
	public List<Transform> m_Exclusions;

	[Tooltip("Constrain bones to move on specified plane.")]
	public FreezeAxis m_FreezeAxis;

	[Tooltip("Disable physics simulation automatically if character is far from camera or player.")]
	public bool m_DistantDisable;

	public Transform m_ReferenceObject;

	public float m_DistanceToObject;

	private Vector3 m_LocalGravity;

	private Vector3 m_ObjectMove;

	private Vector3 m_ObjectPrevPosition;

	private float m_BoneTotalLength;

	private float m_ObjectScale;

	private float m_Time;

	private float m_Weight;

	private bool m_DistantDisabled;

	private List<Particle> m_Particles;

	public void Reset()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void PreUpdate()
	{
	}

	private void CheckDistance()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void SetWeight(float w)
	{
	}

	public float GetWeight()
	{
		return default(float);
	}

	private void UpdateDynamicBones(float t)
	{
	}

	private void SetupParticles()
	{
	}

	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	public void UpdateParameters()
	{
	}

	private void InitTransforms()
	{
	}

	private void ResetParticlesPosition()
	{
	}

	private void UpdateParticles1()
	{
	}

	private void UpdateParticles2()
	{
	}

	private void SkipUpdateParticles()
	{
	}

	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	private void ApplyParticlesToTransforms()
	{
	}
}
