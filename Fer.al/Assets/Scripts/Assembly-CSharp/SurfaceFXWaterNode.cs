using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SurfaceFXWaterNode : ManagedBehaviour
{
	private enum FXState
	{
		Unbuilt,
		Building,
		Built
	}

	private ActorBase _parentActorBase;

	private FXState _fxState;

	private WorldSurfaceDefComponent _currentBuiltFXSurfaceDef;

	private SurfaceFXPrefab _currentBuiltFXBundle;

	private float _currentBuiltFXSurfaceOffset;

	private string _currentGroundID;

	private Dictionary<string, float> _currentGroundMix;

	private Vector3 _lastRaycastPosition;

	private Transform _lastRaycastTransform;

	private string _lastRaycastTransformName;

	private Vector3 _lastHitPosition;

	private Color? _color;

	private ActorBase ParentActorBase
	{
		get
		{
			return null;
		}
	}

	public override void MUpdate()
	{
	}

	public void DestroyBuiltFX()
	{
	}

	[IteratorStateMachine(typeof(<BuildFXRoutine>d__10))]
	private IEnumerator BuildFXRoutine(WorldSurfaceDefComponent inSurfaceDefComponent)
	{
		return null;
	}

	private void UpdateFXPosition()
	{
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
}
