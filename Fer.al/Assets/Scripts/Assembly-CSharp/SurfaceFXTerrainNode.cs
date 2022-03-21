using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SurfaceFXTerrainNode : ManagedBehaviour
{
	public enum SurfaceFXNodeState
	{
		Planted,
		Lifted
	}

	private SurfaceFXNodeState _state;

	private string _currentGroundID;

	private Dictionary<string, float> _currentGroundMix;

	private Vector3 _lastRaycastPosition;

	private Transform _lastRaycastTransform;

	private string _lastRaycastTransformName;

	private Color? _color;

	private RaycastHit[] raycastGroundResults;

	private Vector3 _lastPosition;

	private float _lastLiftedY;

	private float _lastPlantedY;

	public SurfaceFXNodeState State
	{
		get
		{
			return default(SurfaceFXNodeState);
		}
		set
		{
		}
	}

	[IteratorStateMachine(typeof(<InstantiateFXBundle>d__1))]
	private IEnumerator InstantiateFXBundle(string inBundleID)
	{
		return null;
	}

	private Color? GetColor(RaycastHit inHit)
	{
		return null;
	}

	private void RaycastCurrentGroundID()
	{
	}

	private float[] GetTextureMix(Vector3 inWorldPos)
	{
		return null;
	}

	private int GetMainTexture(Vector3 inWorldPos)
	{
		return default(int);
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<UpdateRoutine>d__21))]
	private IEnumerator UpdateRoutine()
	{
		return null;
	}
}
