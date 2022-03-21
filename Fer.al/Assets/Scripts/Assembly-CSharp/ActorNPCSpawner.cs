using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class ActorNPCSpawner : ManagedBehaviour
{
	[Serializable]
	public enum LoadType
	{
		Always = 0,
		Far = 10,
		Close = 20,
		Custom = 30
	}

	private Animator _animator;

	private ActorBase _actorBase;

	[RootSelector("World Object Prefab", "WorldObjectChartData", false, false)]
	public string actorPrefabDefID;

	[RootSelector("NPC", "ActorNPCChartData", false, false)]
	public string actorNPCDefID;

	[SerializeField]
	private MinimapManager.EBlipType _minimapBlipType;

	[SerializeField]
	private bool _minimapBlipForceDisplayOnExpandedMap;

	private MinimapBlip _minimapBlip;

	[SerializeField]
	private bool _facePlayer;

	public LoadType loadType;

	[SerializeField]
	[InspectorDisableOrHideByValue("IsCustomLoadType", false, true)]
	private float _customLoadDistance;

	[SerializeField]
	private bool waitForLocalPlayerToLoad;

	[SerializeField]
	protected bool _npcBubbleIgnoreCollisionOverride;

	[SerializeField]
	private bool _useIdleBreaks;

	[SerializeField]
	private bool _cullAnimations;

	[SerializeField]
	private UnityEvent OnLoaded;

	private bool _instantiating;

	private bool _instantiated;

	private bool _isVisible;

	private bool _isMoving;

	private static RaycastHit[] _visibilityHitsNoAlloc;

	public Animator Animator
	{
		get
		{
			return null;
		}
	}

	public ActorBase ActorBase
	{
		get
		{
			return null;
		}
	}

	public static GameObject CullingPointOverride
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public GameObject actorSpawned
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

	private bool IsAlwaysLoadType
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsCustomLoadType
	{
		get
		{
			return default(bool);
		}
	}

	private float LoadDistance
	{
		get
		{
			return default(float);
		}
	}

	public override void MStart()
	{
	}

	public override void MStartAfterLocal()
	{
	}

	private void Init()
	{
	}

	private Transform RaycastToCameraHitSomething()
	{
		return null;
	}

	internal void SetMoving(bool inMoving)
	{
	}

	[IteratorStateMachine(typeof(<VisibilityRoutine>d__44))]
	private IEnumerator VisibilityRoutine()
	{
		return null;
	}

	private void InstantiateActor()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
