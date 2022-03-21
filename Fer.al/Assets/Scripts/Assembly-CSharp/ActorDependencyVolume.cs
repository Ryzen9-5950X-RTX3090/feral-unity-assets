using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ActorDependencyVolume : ManagedBehaviour
{
	[SerializeField]
	[FormerlySerializedAs("_sphereScale")]
	public float sphereScale;

	[SerializeField]
	[FormerlySerializedAs("_rectangleScale")]
	public Vector3 rectangleScale;

	[SerializeField]
	[FormerlySerializedAs("_shape")]
	public ActorDependencyVolumeController.EShape shape;

	[SerializeField]
	[FormerlySerializedAs("_dependencies")]
	public ActorDependencyVolumeController.Dependencies dependencies;

	private float? _sphereRangeSq;

	private Bounds? _bounds;

	[HideInInspector]
	public ActorDependencyVolumeController.EState desiredState;

	[HideInInspector]
	public ActorDependencyVolumeController.EState currentState;

	[SerializeField]
	private UnityEvent OnEnter;

	[SerializeField]
	private UnityEvent OnExit;

	[HideInInspector]
	public List<ActorBase> actorsInVolume;

	public float sphereRangeSq
	{
		get
		{
			return default(float);
		}
	}

	public Bounds bounds
	{
		get
		{
			return default(Bounds);
		}
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public void VolumeEnter()
	{
	}

	public void VolumeExit()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
