using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class Interactable : ManagedBehaviour
{
	public enum EItemType
	{
		None,
		Enigma,
		SocialExpanseLockpick,
		SocialExpanseChest,
		Inspiration,
		RockFlip,
		DigSpot,
		SocialExpanseBronzeChest,
		SocialExpanseSilverChest,
		SocialExpanseGoldChest,
		DailyQuest
	}

	[Serializable]
	public class InteractableStateInfo
	{
		public AnimationClip animationClip;

		public WrapMode animationWrapMode;
	}

	public enum EInteractableMessage
	{
		Start,
		Cancel,
		Finish
	}

	public enum EInteractableType
	{
		NONE,
		DIG,
		DIVE,
		CUT,
		NET,
		BASH
	}

	public delegate void OnRespawnDelegate();

	[RootSelector("Interactable DefId", "InteractableChartData", false, false)]
	public string interactableDefId;

	private string _interactableDefIdOverride;

	[SerializeField]
	protected bool _forceToTerrain;

	[Tooltip("This will override the 'Force To Terrain'")]
	public bool isGlideCollectable;

	[SerializeField]
	[Tooltip("Is this a target being shot (ie: betwixt rift)?")]
	protected bool _isTarget;

	public bool hideInteractableMessage;

	public Vector3 interactImageOffsetModifier;

	public Vector3 interactImageOffsetModifierFirstPerson;

	public float interactRangeOverride;

	public EInteractableType interactableType;

	[DeBeginGroup]
	[DeHeader("Interactable States", null, null, FontStyle.Bold, 11)]
	public InteractableStateInfo idleState;

	public InteractableStateInfo interactingState;

	public InteractableStateInfo interactedState;

	[DeEndGroup]
	[SerializeField]
	[Header("Jiggle")]
	private bool _jiggleWhileInteracting;

	[SerializeField]
	private Vector3 _jiggleMaxRotation;

	[SerializeField]
	private float _jiggleRotationSpeed;

	[SerializeField]
	[Tooltip("particle fx that is just playing all the time on the interactable")]
	private GameObject _idleFx;

	[SerializeField]
	[Tooltip("This is a prefab reference to instantiate FX when finishing")]
	private GameObject _interactedFx;

	[SerializeField]
	[Tooltip("This is a reference to FX within the prefab to play while interacting")]
	private GameObject groupInteractedFX;

	[SerializeField]
	[Tooltip("This is a prefab reference to instantiate FX when respawning")]
	private GameObject _respawnFX;

	[SerializeField]
	private float _destructionTimer;

	[SerializeField]
	private GameObject _destructionObject;

	[SerializeField]
	[Tooltip("Plays when the interaction starts")]
	private AudioScriptableObject _audioStartInteract;

	[SerializeField]
	[Tooltip("Plays when the interaction in complete")]
	private AudioScriptableObject _audioInteract;

	[SerializeField]
	[Header("Continuous Harvest")]
	[Tooltip("Allows the harvest to continue with a single button press. Disabling requires the player to press the harvest after each successful harvest.")]
	private bool _continuousHarvest;

	internal bool interacting;

	internal bool isSocialExpanseDigSpot;

	protected bool _allowInteraction;

	private MinimapBlip _minimapBlip;

	private bool _wasInRange;

	private bool _wasInVisibleRange;

	private bool _showPrompt;

	private bool _doJiggle;

	private bool _initialized;

	private bool _simpleAnimationInitialized;

	private static bool _initializerNeedsSorting;

	private static List<Interactable> _allInteractables;

	private static IEnumerator _interactableInitializer;

	private Quaternion _initialRotation;

	private WWSimpleAnimation _wwSimpleAnimation;

	private ParticleSystem[] _fxInteracting;

	internal NetworkedObjectInfo networkedObjectInfo;

	internal bool isSnoozing;

	private Vector3? _interactImageOffset;

	private Vector3? _interactImageOffsetFirstPerson;

	private bool _interactRangeIsCalculated;

	private float _interactRange;

	private const float VISIBILITY_RANGE = 5000f;

	private float? _interactTimer;

	private string _interactImageDefId;

	private string _interactTooltipDefId;

	private SocialExpanseChestObject _SocialExpanseChestObject;

	private InteractableDefComponent _interactableDef;

	private static int _lastFramePlayerPositionUpdated;

	private static bool _playerIsNull;

	private static Vector3 _playerPosition;

	private Coroutine _toggleVisibility;

	private const float TOGGLE_TIME = 1f;

	private Vector3 _fullScale;

	private Transform _cachedTransform;

	public string InteractableDefId
	{
		get
		{
			return null;
		}
	}

	public bool isTarget
	{
		get
		{
			return default(bool);
		}
	}

	public bool ForceToTerrain
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public Vector3 interactImageOffset
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 interactImageOffsetFirstPerson
	{
		get
		{
			return default(Vector3);
		}
	}

	public float interactRange
	{
		get
		{
			return default(float);
		}
	}

	public float interactTimer
	{
		get
		{
			return default(float);
		}
	}

	private string interactImageDefId
	{
		get
		{
			return null;
		}
	}

	public string InteractTooltipDefId
	{
		get
		{
			return null;
		}
	}

	public InteractableDefComponent interactableDef
	{
		get
		{
			return null;
		}
	}

	public float distanceToPlayer
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public event OnRespawnDelegate OnRespawn
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public virtual bool ContinuousHarvest()
	{
		return default(bool);
	}

	public void SetContinuousHarvest(bool inEnable)
	{
	}

	protected static void UpdatePlayerPosition()
	{
	}

	public override void MStartAfterLocal()
	{
	}

	private void Initialize()
	{
	}

	private static void AddToInitializer(Interactable inInteractable)
	{
	}

	[IteratorStateMachine(typeof(<InteractableInitializer>d__99))]
	private static IEnumerator InteractableInitializer()
	{
		return null;
	}

	public override void MUpdate()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public override void MOnDestroy()
	{
	}

	internal void GiveToPlayer(string inDefId, int inAmount)
	{
	}

	private void ToggleInteractableParticles(bool inValue)
	{
	}

	[IteratorStateMachine(typeof(<ToggleVisibility>d__106))]
	private IEnumerator ToggleVisibility(bool inVisibilityRange, bool inFastScale = false)
	{
		return null;
	}

	private void InitializeSimpleAnimation()
	{
	}

	[IteratorStateMachine(typeof(<FinalizeInteractablePoint>d__108))]
	public IEnumerator FinalizeInteractablePoint(bool shouldDestroy)
	{
		return null;
	}

	internal void Respawn()
	{
	}

	[IteratorStateMachine(typeof(<PlayRespawnFX>d__110))]
	private IEnumerator PlayRespawnFX()
	{
		return null;
	}

	protected void ShowPrompt(bool inShowPrompt)
	{
	}

	public List<string> ActionIconDefIds()
	{
		return null;
	}

	public List<Action> InteractActions()
	{
		return null;
	}

	public void OnInteractionStart()
	{
	}

	public void OnInteractionCancel()
	{
	}

	public virtual void Interact()
	{
	}

	public virtual void PlayAudioAndFX()
	{
	}

	[IteratorStateMachine(typeof(<Jiggle>d__118))]
	private IEnumerator Jiggle()
	{
		return null;
	}

	public virtual void RequestInteraction(EInteractableMessage inInteractableMessage)
	{
	}

	private void AddClips(InteractableStateInfo inInfo)
	{
	}

	private void SetInfo(InteractableStateInfo inInfo, bool inInteractableParticlesOn = false)
	{
	}

	private void CalcInteractRange()
	{
	}

	private void CalcInteractImageOffset()
	{
	}

	private void CalcInteractImageOffsetFirstPerson()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void InteractImmediately()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[CoreResetTarget]
	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}
}
