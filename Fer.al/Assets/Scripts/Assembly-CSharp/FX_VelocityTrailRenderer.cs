using System.Collections.Generic;
using UnityEngine;

public class FX_VelocityTrailRenderer : ManagedBehaviour
{
	public float minSpeedTime;

	public float maxSpeedTime;

	private bool _checkedCachedTrailRenderers;

	private List<TrailRenderer> _cachedTrailRenderers;

	private bool _checkedCachedParentActor;

	private ActorBase _cachedParentActor;

	private List<TrailRenderer> CachedTrailRenderers
	{
		get
		{
			return null;
		}
	}

	private ActorBase CachedParentActor
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}
}
