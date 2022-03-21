using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class VisibleCullingGroup : ManagedBehaviour
{
	[Serializable]
	public enum VisibleDistanceType
	{
		Far = 10,
		Close = 20,
		Custom = 30
	}

	[SerializeField]
	private VisibleDistanceType visibleDistanceType;

	[SerializeField]
	private bool useRaycast;

	[SerializeField]
	private bool onlyDisableRenderers;

	[SerializeField]
	[InspectorDisableOrHideByValue("IsCustomVisibleDistanceType", false, true)]
	private float _customVisibleDistance;

	private RaycastHit? _lastHit;

	private static RaycastHit[] _visibilityHitsNoAlloc;

	private float _lastDistanceToCamera;

	private float VisibleDistance
	{
		get
		{
			return default(float);
		}
	}

	private bool IsCustomVisibleDistanceType
	{
		get
		{
			return default(bool);
		}
	}

	private Ray VisibilityRay
	{
		get
		{
			return default(Ray);
		}
	}

	private Vector3 CameraPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	private static bool Preview
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	private float DistanceToCamera
	{
		get
		{
			return default(float);
		}
	}

	private bool Visible
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void MStartAfterLocal()
	{
	}

	private RaycastHit? RaycastToCamera(float inDistance)
	{
		return null;
	}

	private bool TestAndSetVisibility()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<VisibilityRoutine>d__18))]
	private IEnumerator VisibilityRoutine()
	{
		return null;
	}

	private void SetVisible(bool inVisible)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
