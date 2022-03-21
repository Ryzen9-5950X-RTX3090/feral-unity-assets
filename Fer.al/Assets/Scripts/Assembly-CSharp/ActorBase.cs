using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using RootMotion.FinalIK;
using UnityEngine;
using WW.Waiters;

public class ActorBase : WorldObjectMover<ActorInfo>
{
	private class AnimatorLayerTransitionInfo
	{
		public int layer;

		public bool visibility;

		public float duration;

		public float time;

		public AnimatorLayerTransitionInfo(int inLayer, bool inVisibility, float inDuration, float inTime = 0f)
		{
		}
	}

	private class ActorBodyPartInstantiatedDecal
	{
		public ActorInfoDecalEntry decalEntry;

		public string lastRefreshedDefID;

		public GameObject sprite;

		public GameObject outlineSprite;

		public GameObject mirrorSprite;

		public GameObject mirrorOutlineSprite;
	}

	private class ActorBodyPartInstantiatedEyeDecal
	{
		public ActorInfoDecalEntry decalEntry;

		public GameObject shapeSprite;

		public GameObject shapeClipSprite;

		public GameObject shapeBlinkSprite;

		public GameObject pupilSprite;

		public GameObject mirrorShapeSprite;

		public GameObject mirrorShapeClipSprite;

		public GameObject mirrorShapeBlinkSprite;

		public GameObject mirrorPupilSprite;
	}

	[Serializable]
	public class ActorBodyPart
	{
		public ActorBase parentActorBase;

		public ActorInfoBodyPart bodyPartInfo;

		public ActorInfoBodyPart lastBodyPartInfo;

		public ActorBodyPartNodeDefComponent bodyPartNode;

		public bool combined;

		public bool initedJointMatching;

		public bool initedAdditiveAnimations;

		public GameObject instanceObject;

		public Transform instanceTransform;

		[NonSerialized]
		public bool instanceRendererBroken;

		public SkinnedMeshRenderer instanceRenderer;

		public List<Material> instanceMaterials;

		public GameObject attachmentInstanceObject;

		public Mesh instanceMesh;

		private Camera _decalCamera;

		private int _decalRenderTextureRatio;

		private RenderTexture _decalRenderTexture;

		private GameObject _decalParentGroup;

		private int _decalParentGroupXPos;

		private Transform _decalEditorSpriteGroup;

		private Transform _decalMainSpriteGroup;

		private Transform _decalDefaultMaskGroup;

		private List<Transform> _decalMaskGroups;

		private List<ActorBodyPartInstantiatedDecal> _decalsInstantiated;

		private Camera _eyeDecalCamera;

		private RenderTexture _eyeDecalRenderTexture;

		private RenderTexture _eyeDecalBlinkRenderTexture;

		private GameObject _eyeDecalParentGroup;

		private int _eyeDecalParentGroupXPos;

		private Transform _eyeDecalSpriteGroup;

		private bool _eyeBlinkState;

		private float _eyeBlinkTimer;

		private Material _eyeShapeMaterial;

		private Material _eyePupilMaterial;

		private List<ActorBodyPartInstantiatedEyeDecal> _eyeDecalsInstantiated;

		public Dictionary<string, ActorBoneInfo> skeletonMap;

		private Transform _fxAttachNode;

		public bool IsBuilding
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GameObject EyeDecalParentGroup
		{
			get
			{
				return null;
			}
		}

		public List<ActorInfoDecalEntry> DecalEntries
		{
			get
			{
				return null;
			}
		}

		public List<ActorInfoDecalEntry> EyeDecalEntries
		{
			get
			{
				return null;
			}
		}

		public Transform FXAttachNode
		{
			get
			{
				return null;
			}
		}

		public void MUpdate()
		{
		}

		public void Destroy([Optional] GameObject inInstanceObjectOverride, [Optional] List<ActorBoneInfo> inSkeletonMapOverride)
		{
		}

		public void UpdateAdditiveAnimations()
		{
		}

		public void DeinitAdditiveAnimations()
		{
		}

		public void ApplyColorsFromParentInfo()
		{
		}

		public void ApplyColors(HSVColor inColor1, HSVColor inColor2, HSVColor inColor3, HSVColor inColor4)
		{
		}

		[IteratorStateMachine(typeof(<InstantiateRoutine>d__55))]
		public IEnumerator InstantiateRoutine()
		{
			return null;
		}

		public void DestroyDecalSystem()
		{
		}

		private void InitDecalSystem()
		{
		}

		private void InstantiateDecalSprite(ActorBodyPartInstantiatedDecal inInstantiatedDecal, Material inMaterial)
		{
		}

		public void RefreshDecalsPreRoutine()
		{
		}

		public void RefreshDecalsPostRoutine()
		{
		}

		public void RefreshDecalsRoutine()
		{
		}

		private void InitEyeDecalSystem()
		{
		}

		private void DestroyEyeDecalSystem(bool inDestroyRenderTex)
		{
		}

		[IteratorStateMachine(typeof(<RefreshEyeDecals>d__64))]
		public IEnumerator RefreshEyeDecals()
		{
			return null;
		}

		private void AddJointsToSkeletonMap(Transform inRootJoint, Transform inParentJoint, HashSet<string> inSkinnedBones)
		{
		}

		public Transform GetSkeletonJointTransform(string inName)
		{
			return null;
		}
	}

	[Serializable]
	public class AttachedClothingItem
	{
		public ActorBase parentActorBase;

		public ActorInfoClothingItem clothingItemInfo;

		public ActorClothingDefComponent clothingDefComponent;

		public ActorAttachNodeDefComponent attachNode;

		public bool combined;

		public GameObject instanceObject;

		public Transform instanceTransform;

		public Mesh instanceMesh;

		public Renderer instanceRenderer;

		public Material instanceMaterial;

		private Texture2D _baseTexture;

		private Texture2D _baseColorIDTexture;

		public GameObject attachmentInstanceObject;

		public Dictionary<string, ActorBoneInfo> skeletonMap;

		public void Destroy()
		{
		}

		public void Instantiate()
		{
		}

		public void ApplyMaterialKeywords()
		{
		}

		public void ApplyMaterialColors()
		{
		}

		[IteratorStateMachine(typeof(<InstantiateRoutine>d__18))]
		private IEnumerator InstantiateRoutine()
		{
			return null;
		}

		private void AddJointsToSkeletonMap(Transform inRootJoint, Transform inParentJoint)
		{
		}

		public Transform GetSkeletonJointTransform(string inName)
		{
			return null;
		}
	}

	[Serializable]
	public struct ActorBoneInfo
	{
		public Transform bone;

		public Transform actorRoot;

		public Vector3 initialPos;

		public Quaternion initialRot;

		public Vector3 initialScale;

		public ActorBoneInfo(Transform inTrans, Transform inActorRoot)
		{
		}

		public Vector3 GetBoneLocalPosition()
		{
			return default(Vector3);
		}

		public Vector3 TransformPosition(Vector3 inLocalSpacePos)
		{
			return default(Vector3);
		}

		public Quaternion GetBoneLocalRotation()
		{
			return default(Quaternion);
		}

		public Quaternion TransformRotation(Quaternion inLocalSpaceRotation)
		{
			return default(Quaternion);
		}

		public Vector3 GetBoneScaleOffset()
		{
			return default(Vector3);
		}
	}

	public enum EGlideState
	{
		None,
		Gliding,
		GlideFalling
	}

	private List<IK> _bodyIKs;

	private List<DynamicBone> _bones;

	private Dictionary<IK, bool> _bodyIKDictionaries;

	private Dictionary<DynamicBone, bool> _boneDictionaries;

	private List<Animator> _animators;

	private List<AnimatorLayerTransitionInfo> _animatorTransitions;

	private List<AnimatorLayerTransitionInfo> _animatorCachedTransitionsToRemove;

	private static int _animatorUpdateIndex;

	private static List<ActorBase> _animatorUpdateRegisteredActors;

	private static QRoutine _animatorUpdateQRoutine;

	private static List<ActorBase> _animatorUpdateCurrentActors;

	private static List<string> _additiveAnimationParameterNames;

	private ActorActionType _nextActionType;

	private bool _nextActionBreakLoop;

	private static readonly int Action;

	private static readonly int ActionTrigger;

	private HashSet<string> _loadingAnimations;

	private Dictionary<string, AnimationClipDataObject> _loadedAnimations;

	private List<ActorBodyPart> _attachedBodyParts;

	private Dictionary<string, ActorBodyPart> _attachedNodeToBodyPartDict;

	private ActorBodyPart _headBodyPart;

	private ActorBodyPart _bodyBodyPart;

	private static Material _decalSharedMaterial;

	private static Material _eyeShapeSharedMaterial;

	private static Material _eyePupilSharedMaterial;

	private static Material _maskedBlitMat;

	private static Material _standardBlitMat;

	private static readonly int Decal2Tex;

	private static readonly int ColorId1Hsv;

	private static readonly int ColorId2Hsv;

	private static readonly int ColorId3Hsv;

	private static readonly int ColorId4Hsv;

	private static readonly int DecalTex;

	private GameObject _combinedBodyPartsObject;

	private SkinnedMeshRenderer _combinedBodyPartsRenderer;

	private Material _combinedBodyMaterial;

	private Texture2D _combinedBodyTexture;

	private Mesh _combinedBodyMesh;

	private List<ValueTuple<Mesh, SkinnedMeshRenderer, bool>> _tempCombineMeshes;

	[NonSerialized]
	protected UI_ActorBubble _bubble;

	private List<AttachedClothingItem> _attachedClothingItems;

	private Dictionary<string, AttachedClothingItem> _attachNodeToClothingItemDict;

	private Color _lastFakeLightMultColor;

	private Color _lastFakeLightAddColor;

	private bool _failedWingJointMatching;

	private Texture2D _materialBaseTexture;

	private float _lastWorldY;

	private static readonly int MainTexTintFloor;

	private List<Material> _allBodyPartMaterials;

	private ActorMoverState _moverState;

	private CharacterController _moverCharController;

	private bool _moverCharControllerChecked;

	private EGlideState _glideState;

	private Dictionary<string, bool> _moverAnimatorHasParamDict;

	private Quaternion _moverLastRotation;

	private Vector3? _moverLastPosition;

	private float _moverCurrentPitch;

	private float _moverNoMoveTimer;

	private float _moverAnimationSpeedPercent;

	private bool _manuallyTriggerJump;

	protected bool _isRespawning;

	protected bool _isTransitionDeparting;

	protected bool _isTransitionArriving;

	private GameObject _teleportAwayFX;

	private GameObject _teleportArriveFX;

	private GameObject _boundaryDeathFX;

	private GameObject _boundaryRespawnFX;

	private static int _collisionLayerMask;

	private float _moverMaxSwimDepth;

	private bool _moverWaterDiving;

	private bool _moverWaterLastSwimming;

	private bool _moverWaterSwimming;

	private float _moverWaterHeight;

	private float _moverWaterGroundHeight;

	private float _moverWaterDepth;

	private float _moverSwimLineHeight;

	private bool _moverWaterLineNodeChecked;

	private Transform _moverWaterLineNode;

	private ControllerColliderHit _moverLastControllerHit;

	private Vector3 _lastMoverCheckedGroundedPosition;

	protected Vector3 _lastGoodPosition;

	protected Quaternion _lastGoodRotation;

	protected bool _moverIsGrounded;

	protected bool _moverLastIsGrounded;

	protected bool _moverIsSliding;

	protected bool _moverIsGlidePosing;

	protected RaycastHit _moverGroundHit;

	protected bool _moverReadyToJump;

	protected float _moverDesiredSpeed;

	protected float _moverCurrentSpeed;

	protected Vector3 _moverMovementVector;

	protected float _moverCurrentVerticalVelocity;

	protected float _moverCurrentTurnRotation;

	protected float _moverCurrentJumpForce;

	protected Quaternion _moverTargetRotation;

	protected float _moverTargetRotationAngleDiff;

	protected float _moverCurrentOffsetRotationSmoothDampVelocity;

	protected float _moverRoll;

	private const float _moverAirborneTurnSpeedProportion = 5.4f;

	private const float _moverGroundedRayDistance = 1f;

	private const float _moverMinEnemyDotCoeff = 0.2f;

	private const float _moverInverseOneEighty = 1f / 180f;

	private const float _moverStickingGravityProportion = 0.3f;

	private const float _moverGroundAcceleration = 30f;

	private const float _moverGroundDeceleration = 20f;

	private const float _moverTurnAcceleration = 100f;

	protected int _framesSinceLastRespawnInfoSent;

	private Transform _rotateTransform;

	private static bool _runByDefault;

	private WW.Waiters.Waiter _mobileRunWaiter;

	private float _lastMoverVelocityMaxSpeedPercent;

	private List<Vector3> _raycastPositions;

	private List<RaycastHit> _raycastHits;

	private RaycastHit[] _alignRaycastHitsNoAlloc;

	private Vector3 _lastMoverCheckedAlignPosition;

	private static int _moverAlignMask;

	private float _moverTargetTurnBlend;

	private float _moverMaxTurnAngle;

	private float _moverTurnBlend;

	private float _moverLastTurnAngle;

	private float _moverIdleTimer;

	private float _moverSleepTimer;

	private bool _moverLastSwimmingAudio;

	private bool _moverLastMovingAudio;

	private bool _moverFlying;

	private float _randomIdleAudio;

	private Vector3? _moverLastGoodPosition;

	private Quaternion? _moverLastGoodRotation;

	private static readonly int Speed;

	private static readonly int DirectionX;

	[SerializeField]
	[Header("Quality")]
	private DynamicAssetQualityLevel _shaderQuality;

	[SerializeField]
	private DynamicAssetQualityLevel _textureQuality;

	[SerializeField]
	private DynamicAssetQualityLevel _meshQuality;

	[SerializeField]
	[Header("Object")]
	private bool _ignoreClassDefScale;

	[SerializeField]
	private ActorCombineType _combineType;

	[Space]
	[SerializeField]
	private bool _applySilhouette;

	[SerializeField]
	private Color32 silhouetteColor;

	[SerializeField]
	private Outline.Mode silhouetteMode;

	[SerializeField]
	[Header("Mover")]
	private ActorMoverNavType _moverNavType;

	[SerializeField]
	private bool _moverEnableTransformVelocityAnimation;

	[SerializeField]
	private float _moverMaxSpeed;

	[SerializeField]
	private float _moverMaxSpeedRunning;

	[SerializeField]
	private bool _moverStickToGround;

	[SerializeField]
	private float _moverGravity;

	[SerializeField]
	private float _moverJumpForce;

	[SerializeField]
	private bool _useFSpineAnimator;

	[SerializeField]
	private bool _useFTailAnimator;

	[SerializeField]
	private bool _useIdleBreaks;

	public bool _doCameraRelativeInput;

	public bool _ignoreDistanceFromLocalAvatarCheck;

	[Space]
	[SerializeField]
	[Space(6f)]
	[Header("UI")]
	private bool _useBubble;

	private static QRoutineGroup _actorQRoutineMainGroup;

	private static QRoutineGroup _actorSetNewInfoQRoutineGroup;

	private static QRoutineGroup _actorBuildQRoutineGroup;

	private static QRoutineGroup _actorHighPriorityBuildQRoutineGroup;

	private static QRoutineGroup _actorAssetsQRoutineGroup;

	private static QRoutineGroup _actorAssetsBodyPartsQRoutineGroup;

	private static QRoutineGroup _actorAssetsDecalsQRoutineGroup;

	private QRoutineGroup _actorBodyQRoutineGroup;

	private QRoutineGroup _actorClothingQRoutineGroup;

	private Dictionary<ActorInfoDirtyType, bool> _dirtyTypes;

	[NonSerialized]
	private bool _isRefreshingDirty;

	private ActorInfoDirtyType[] _dirtyEnumTypes;

	private QRoutine _refreshDirtyUpdateCheckRoutine;

	private QRoutine _refreshDirtyRoutine;

	public Action<ActorBase> OnSkeletonsRefreshed;

	private GameObject _bodySkeletonObject;

	private GameObject _wingSkeletonObject;

	private Dictionary<string, ActorBoneInfo> _bodySkeletonMap;

	private Transform _bodySkeletonRootJoint;

	private Transform _bodySkeletonGameNodeJoint;

	private Dictionary<string, ActorBoneInfo> _wingSkeletonMap;

	private Transform _wingSkeletonRootJoint;

	private Transform _wingSkeletonGameNodeJoint;

	private Dictionary<string, Transform> _wingFXAttachJoints;

	private Transform _cameraLookBody;

	private Transform _cameraLookTail;

	private Transform _cameraLookHead;

	public bool cullAnimations;

	private ActorBaseDataObjectNoSO _actorData;

	private List<Outline> _silhouettes;

	private Color32 _lastAppliedSilhouetteColor;

	private Outline.Mode _lastAppliedSilhouetteMode;

	protected float _deltaTime;

	private ActorBuildState _buildState;

	private float _bodyScale;

	private float _offsetTransformYOffset;

	[NonSerialized]
	private Transform _offsetTransform;

	[NonSerialized]
	private Transform _bodyTransform;

	private LevelGate[] _levelGates;

	private RaycastHit[] _visibilityHitsNoAlloc;

	private List<Renderer> _cachedChildRenderers;

	private bool _lastMeshesAreVisible;

	private static int _unbuildCount;

	private static List<Avatar_Network> _registeredNetworkAvatars;

	public Animator BodyAnimator
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

	public Animator WingAnimator
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

	public List<Animator> Animators
	{
		get
		{
			return null;
		}
	}

	public static List<string> AdditiveAnimationParameterNames
	{
		get
		{
			return null;
		}
	}

	public bool AnimationInAction
	{
		get
		{
			return default(bool);
		}
	}

	public bool AnimationInFalling
	{
		get
		{
			return default(bool);
		}
	}

	public bool AnimationInJumping
	{
		get
		{
			return default(bool);
		}
	}

	public bool AnimationInSwimming
	{
		get
		{
			return default(bool);
		}
	}

	public bool AnimationInDiving
	{
		get
		{
			return default(bool);
		}
	}

	public bool AnimationInGliding
	{
		get
		{
			return default(bool);
		}
	}

	public List<ActorBodyPart> AttachedBodyParts
	{
		get
		{
			return null;
		}
	}

	public ActorBodyPart HeadBodyPart
	{
		get
		{
			return null;
		}
	}

	public ActorBodyPart BodyBodyPart
	{
		get
		{
			return null;
		}
	}

	private int DecalResolution
	{
		get
		{
			return default(int);
		}
	}

	private bool NeedsRefreshSharedInstances
	{
		get
		{
			return default(bool);
		}
	}

	private static Material MaskedBlitMat
	{
		get
		{
			return null;
		}
	}

	private static Material StandardBlitMat
	{
		get
		{
			return null;
		}
	}

	public SkinnedMeshRenderer CombinedBodyPartsRenderer
	{
		get
		{
			return null;
		}
	}

	public UI_ActorBubble Bubble
	{
		get
		{
			return null;
		}
	}

	public ActorClothingBuildState ClothingBuildState
	{
		get
		{
			return default(ActorClothingBuildState);
		}
	}

	public List<AttachedClothingItem> AttachedClothingItems
	{
		get
		{
			return null;
		}
	}

	public List<Material> AllBodyPartMaterials
	{
		get
		{
			return null;
		}
	}

	public ActorMoverState MoverState
	{
		get
		{
			return default(ActorMoverState);
		}
		set
		{
		}
	}

	public CharacterController MoverCharController
	{
		get
		{
			return null;
		}
	}

	public bool IsGrounded
	{
		get
		{
			return default(bool);
		}
	}

	public EGlideState GlideState
	{
		get
		{
			return default(EGlideState);
		}
		set
		{
		}
	}

	public Vector3 MoverMoveInputVector
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float MoverCurrentVerticalVelocity
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool IsTransitionDeparting
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsTransitionArriving
	{
		get
		{
			return default(bool);
		}
	}

	private static int COLLISION_LAYER_MASK
	{
		get
		{
			return default(int);
		}
	}

	public bool MoverSwimming
	{
		get
		{
			return default(bool);
		}
	}

	private Transform MoverWaterLineNode
	{
		get
		{
			return null;
		}
	}

	private Vector2 MoverInputVector
	{
		get
		{
			return default(Vector2);
		}
	}

	private bool MoverHasInputVector
	{
		get
		{
			return default(bool);
		}
	}

	private bool MoverInputJump
	{
		get
		{
			return default(bool);
		}
	}

	private bool MoverInputJumpDown
	{
		get
		{
			return default(bool);
		}
	}

	private Transform RotateTransform
	{
		get
		{
			return null;
		}
	}

	protected GameSettingsManager.ControlSetting ControlMode
	{
		get
		{
			return default(GameSettingsManager.ControlSetting);
		}
	}

	public bool MoverDontAllowMovement
	{
		get
		{
			return default(bool);
		}
	}

	public bool RunInput
	{
		get
		{
			return default(bool);
		}
	}

	public bool WalkInput
	{
		get
		{
			return default(bool);
		}
	}

	public float MoverMaxSpeed
	{
		get
		{
			return default(float);
		}
	}

	public float MoverVelocityMagnitude
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

	public float MoverVelocityMaxSpeedPercent
	{
		get
		{
			return default(float);
		}
	}

	public Quaternion? MoverLastGoodRotation
	{
		get
		{
			return null;
		}
	}

	public ActorActionType MoverLastGoodActionType
	{
		[CompilerGenerated]
		get
		{
			return default(ActorActionType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public WorldObjectMoverNodeType MoverLastGoodNodeType
	{
		[CompilerGenerated]
		get
		{
			return default(WorldObjectMoverNodeType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DynamicAssetQualityLevel ShaderQuality
	{
		get
		{
			return null;
		}
	}

	public DynamicAssetQualityLevel TextureQuality
	{
		get
		{
			return null;
		}
	}

	public DynamicAssetQualityLevel MeshQuality
	{
		get
		{
			return null;
		}
	}

	public ActorCombineType CombineType
	{
		get
		{
			return default(ActorCombineType);
		}
		set
		{
		}
	}

	public bool ApplySilhouette
	{
		get
		{
			return default(bool);
		}
	}

	public ActorMoverNavType MoverNavType
	{
		get
		{
			return default(ActorMoverNavType);
		}
		set
		{
		}
	}

	public float MoverGravity
	{
		get
		{
			return default(float);
		}
	}

	public float MoverJumpForce
	{
		get
		{
			return default(float);
		}
	}

	public bool UseFSpineAnimator
	{
		get
		{
			return default(bool);
		}
	}

	public bool UseFTailAnimator
	{
		get
		{
			return default(bool);
		}
	}

	public bool UseIdleBreaks
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool UseBubble
	{
		set
		{
		}
	}

	public bool SetStickToGround
	{
		set
		{
		}
	}

	public static QRoutineGroup ActorQRoutineMainGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup ActorSetNewInfoQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup ActorBuildQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup ActorHighPriorityBuildQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup ActorAssetsQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup ActorAssetsBodyPartsQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup ActorAssetsDecalsQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public QRoutineGroup ActorInstanceBodyQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public QRoutineGroup ActorInstanceClothingQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public bool IsRefreshingDirty
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool IsAnyDirty
	{
		get
		{
			return default(bool);
		}
	}

	private ActorInfoDirtyType[] DirtyEnumTypes
	{
		get
		{
			return null;
		}
	}

	public List<ActorInfoDirtyType> AllDirty
	{
		get
		{
			return null;
		}
	}

	private Dictionary<string, ActorBoneInfo> BodySkeletonMap
	{
		get
		{
			return null;
		}
	}

	private Transform BodySkeletonRootJoint
	{
		get
		{
			return null;
		}
	}

	private Transform BodySkeletonGameNodeJoint
	{
		get
		{
			return null;
		}
	}

	private Dictionary<string, ActorBoneInfo> WingSkeletonMap
	{
		get
		{
			return null;
		}
	}

	private Transform WingSkeletonRootJoint
	{
		get
		{
			return null;
		}
	}

	private Transform WingSkeletonGameNodeJoint
	{
		get
		{
			return null;
		}
	}

	public Transform CameraLookBody
	{
		get
		{
			return null;
		}
	}

	public Transform CameraLookTail
	{
		get
		{
			return null;
		}
	}

	public Transform CameraLookHead
	{
		get
		{
			return null;
		}
	}

	public virtual string ActorName
	{
		get
		{
			return null;
		}
	}

	public ActorClassDefComponent ClassDef
	{
		get
		{
			return null;
		}
	}

	public bool IsLocal
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCustomizerAvatar
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsNetworkAvatar
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsNPCAvatar
	{
		get
		{
			return default(bool);
		}
	}

	public ActorBuildState BuildState
	{
		get
		{
			return default(ActorBuildState);
		}
		set
		{
		}
	}

	public float BodyScale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float OffsetTransformYOffset
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public Transform OffsetTransform
	{
		get
		{
			return null;
		}
	}

	public Transform BodyTransform
	{
		get
		{
			return null;
		}
	}

	private LevelGate[] LevelGates
	{
		get
		{
			return null;
		}
	}

	public bool IsVisibleToAnyCamera
	{
		get
		{
			return default(bool);
		}
	}

	public bool MeshesAreVisible
	{
		get
		{
			return default(bool);
		}
	}

	public override QRoutineGroup BuildQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public List<Renderer> CachedChildRenderers
	{
		get
		{
			return null;
		}
	}

	private void ClearAnimation()
	{
	}

	[IteratorStateMachine(typeof(<UpdateAnimationQueue>d__22))]
	private static IEnumerator UpdateAnimationQueue()
	{
		return null;
	}

	private void RegisterForAnimationUpdate()
	{
	}

	private void UnregisterForAnimationUpdate()
	{
	}

	private void InitAnimation()
	{
	}

	private bool IsGetCurrentStateInfo(string inStateName)
	{
		return default(bool);
	}

	private bool IsGetNextStateInfo(string inStateName)
	{
		return default(bool);
	}

	private void MUpdateAnimation()
	{
	}

	public void AnimatorSetLayerVisibility(int inLayerIndex, bool inVisibility, float inDuration = 0.25f)
	{
	}

	public void AnimatorSetLayerVisibility(int[] inOnLayers, int[] inOffLayers, float inDuration = 0.25f)
	{
	}

	public void SetBool(string inTrigger, bool inValue)
	{
	}

	public void SetInt(string inTrigger, int inValue)
	{
	}

	public void BreakLoop()
	{
	}

	public void SetAction(ActorActionType inValue)
	{
	}

	public void SetTrigger(string inTrigger)
	{
	}

	public override void MOnEnable()
	{
	}

	[IteratorStateMachine(typeof(<ActionCoroutine>d__57))]
	private IEnumerator ActionCoroutine()
	{
		return null;
	}

	public void AnimationIdleBreak01(bool notifyMover = true)
	{
	}

	public void AnimationIdleBreak02(bool notifyMover = true)
	{
	}

	public void AnimationIdleBreak03(bool notifyMover = true)
	{
	}

	public void AnimationStartJump(bool notifyMover = true)
	{
	}

	public void AnimationFinishLoop(bool notifyMover = true)
	{
	}

	public void AnimationStartFall(bool notifyMover = true)
	{
	}

	public void AnimationStartGlide(bool notifyMover = true)
	{
	}

	public void AnimationDig(bool notifyMover = true)
	{
	}

	public void AnimationHarvest(bool notifyMover = true)
	{
	}

	public void AnimationDizzy(bool notifyMover = true)
	{
	}

	public void AnimationDive(bool notifyMover = true)
	{
	}

	public void AnimationSleep(bool notifyMover = true)
	{
	}

	public void AnimationBoolSwim(bool inValue, bool notifyMover = true)
	{
	}

	public void AnimationBoolDecal(bool inValue)
	{
	}

	public void AnimationTeleportArrival()
	{
	}

	public void AnimationTeleportDepart()
	{
	}

	public void AnimationBoundaryDeath()
	{
	}

	public void AnimationBoundaryRespawn()
	{
	}

	public void FreezeAnimation(bool inFreeze)
	{
	}

	[IteratorStateMachine(typeof(<LoadAnimationAndWait>d__79))]
	private IEnumerator LoadAnimationAndWait(string inAnimationID)
	{
		return null;
	}

	private void UnloadAnimation(string inAnimationID)
	{
	}

	private void MUpdateBodyParts()
	{
	}

	[IteratorStateMachine(typeof(<BuildBodyParts>d__97))]
	private IEnumerator BuildBodyParts()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RefreshSharedInstances>d__100))]
	private IEnumerator RefreshSharedInstances()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RefreshBodyParts>d__101))]
	private IEnumerator RefreshBodyParts()
	{
		return null;
	}

	private void ClearBodyParts()
	{
	}

	private void DestroyBodyParts()
	{
	}

	public ActorBodyPart GetAttachedBodyPartOfType(string inBodyPartNodeDefID)
	{
		return null;
	}

	public ActorBodyPart GetAttachedBodyPartOfType(ActorBodyPartNodeDefComponent inBodyPartNode)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SetBodyPartWithInfo>d__121))]
	public IEnumerator SetBodyPartWithInfo(ActorInfoBodyPart inInfo, ActorBodyPartNodeDefComponent inBodyPartNode)
	{
		return null;
	}

	private void DestroyBodyPartCombine()
	{
	}

	[IteratorStateMachine(typeof(<BuildBodyPartCombine>d__131))]
	private IEnumerator BuildBodyPartCombine()
	{
		return null;
	}

	private Vector2 GetAtlasOffsetLine(int inIndex, int inCount)
	{
		return default(Vector2);
	}

	private Vector2 GetAtlasSizeSquare(int inCount)
	{
		return default(Vector2);
	}

	private Vector2 GetAtlasOffsetSquare(int inCount, int inIndex)
	{
		return default(Vector2);
	}

	[IteratorStateMachine(typeof(<BuildBubble>d__138))]
	private IEnumerator BuildBubble()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildClothing>d__145))]
	private IEnumerator BuildClothing()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RefreshClothing>d__146))]
	private IEnumerator RefreshClothing()
	{
		return null;
	}

	private void ClearClothing()
	{
	}

	private void DestroyClothing()
	{
	}

	public bool HasAttachedClothingItemWithDefID(string inClothingItemDefID)
	{
		return default(bool);
	}

	public AttachedClothingItem GetAttachedClothingItemWithItemDefID(string inClothingItemDefID)
	{
		return null;
	}

	public AttachedClothingItem GetAttachedClothingItemOnNode(BaseDef inAttachNode)
	{
		return null;
	}

	public AttachedClothingItem GetAttachedClothingItemOnGroup(ActorAttachNodeGroupDefComponent inAttachNodeGroup)
	{
		return null;
	}

	public void RemoveAttachedClothingItemOnNode(BaseDef inAttachNode)
	{
	}

	public void RemoveAttachedClothingItemOnGroup(BaseDef inAttachNodeGroup)
	{
	}

	public void RemoveAttachedClothingItem(AttachedClothingItem inAttachedItem)
	{
	}

	public AttachedClothingItem AddAttachedClothingItemWithDefComponent(ActorClothingDefComponent inDefComponent)
	{
		return null;
	}

	public bool HasVisibleClothingItem(string inClothingDefID, [Optional] Camera inCamera, float inMaxSqrDist = 30f)
	{
		return default(bool);
	}

	public static bool DoesAnyVisibleNetworkAvatarHaveClothingItem(string inClothingDefID, [Optional] Camera inCamera, float inMaxSqrDist = 30f)
	{
		return default(bool);
	}

	public void Log(string inLogMessage)
	{
	}

	public void LogError(string inLogMessage)
	{
	}

	private void InitFakeLighting()
	{
	}

	private void MUpdateFakeLighting()
	{
	}

	public void UpdateLighting(bool inForced)
	{
	}

	public void SetFakeLightColors(Color inMultColor, Color inAddColor)
	{
	}

	private void InitJointMatching()
	{
	}

	private void LateUpdateJointMatching()
	{
	}

	private void InitJointScaling()
	{
	}

	public void LateUpdateJointScaling()
	{
	}

	public virtual void RegisterListeners()
	{
	}

	public virtual void UnregisterListeners()
	{
	}

	private void BuildMaterial()
	{
	}

	private void RefreshMaterial()
	{
	}

	private void MUpdateMaterial()
	{
	}

	public void ApplyMaterialKeywords()
	{
	}

	public void ApplyMaterialBodyPartColors()
	{
	}

	private void BuildMover()
	{
	}

	private void SetGlideWingTraceEnabled(bool inIsEnabled)
	{
	}

	private bool FastHasParameter(string inParamName)
	{
		return default(bool);
	}

	public void MoverReset()
	{
	}

	public void ManuallyTriggerJump()
	{
	}

	private void MUpdateMoverWater()
	{
	}

	public void OnHarvestPointMessage(InteractablePointMessage inMessage)
	{
	}

	private float MapClampAndRamp(float inValue, bool doRamp = true)
	{
		return default(float);
	}

	private void MUpdateMover()
	{
	}

	private void OnControllerColliderHit(ControllerColliderHit inHit)
	{
	}

	protected void MUpdateMoverIsGrounded()
	{
	}

	private void RequestRespawn()
	{
	}

	protected void OnRespawnReceived(WorldObjectRecievedRespawnMessage inMessage)
	{
	}

	[IteratorStateMachine(typeof(<ReceivedRespawn>d__267))]
	private IEnumerator ReceivedRespawn(Vector3 inPosition, Quaternion inRotation, bool inIsMe)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TeleportToWorldLocation>d__268))]
	public IEnumerator TeleportToWorldLocation(string worldMapId)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RespawnToWorldLocation>d__269))]
	public IEnumerator RespawnToWorldLocation(string worldMapId)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TransitionDeparture>d__270))]
	public IEnumerator TransitionDeparture(bool inIsMe, bool useFadeOut, string transitionType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TransitionArrival>d__271))]
	public IEnumerator TransitionArrival(bool inIsMe, bool useFadeIn, string transitionType)
	{
		return null;
	}

	protected override void MUpdateMoverNodeQueue()
	{
	}

	private void MUpdateMoverSmoothFollowTarget()
	{
	}

	protected override void HandleNodeType(WorldObjectMoverNode inNode)
	{
	}

	public override void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation)
	{
	}

	protected void MUpdateMoverLocalCharacterController()
	{
	}

	private void UpdateGlideState()
	{
	}

	private void ChangeGlidingState(EGlideState inGlideState)
	{
	}

	private void SetGlidingStateToFalse()
	{
	}

	public void OnGlideResponse(WorldObjectGlideMessage inMessage)
	{
	}

	public void MoverFinishMouseOrbit()
	{
	}

	protected void MUpdateMoverLocalCharacterController_StandardMode()
	{
	}

	protected virtual void MUpdateMoverLocalCharacterController_SimplifiedMode()
	{
	}

	public void DebugSetMoverMaxSpeed(float inSpeed, bool forRunning = false)
	{
	}

	private void MUpdateMoverAlignToGround()
	{
	}

	private void MUpdateMoverAnimation()
	{
	}

	protected void MUpdateMoverAudio()
	{
	}

	protected void MoverResetNodeAndPositionData()
	{
	}

	protected void MoverSetNodeTypeAndDetails(WorldObjectMoverNodeType nodeType, ActorActionType actionType)
	{
	}

	public void ExitLevelWithPos(Vector3 inPos)
	{
	}

	public void NavigateToPos(Vector3 inPos, [Optional] float? inRotation)
	{
	}

	public bool IsDirty(ActorInfoDirtyType inType)
	{
		return default(bool);
	}

	public void SetDirty(ActorInfoDirtyType inType, bool inValue = true)
	{
	}

	public void SetAllDirty(bool inValue = true)
	{
	}

	private void InitRefreshDirtyUpdateCheck()
	{
	}

	[IteratorStateMachine(typeof(<RefreshDirtyUpdateCheckRoutine>d__465))]
	private IEnumerator RefreshDirtyUpdateCheckRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RefreshDirtyRoutine>d__466))]
	private IEnumerator RefreshDirtyRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildSkeletons>d__498))]
	private IEnumerator BuildSkeletons()
	{
		return null;
	}

	private void RefreshSkeletons()
	{
	}

	private void AddWingFXAttachJointsFromSkeleton(ref Dictionary<string, Transform> refWingFXAttachJoints, Dictionary<string, ActorBoneInfo> inSkeleton)
	{
	}

	private void ClearSkeletons()
	{
	}

	private void DestroySkeleton()
	{
	}

	private void AddJointsToMap(Transform inParentJoint, ref Dictionary<string, ActorBoneInfo> refJointMap)
	{
	}

	public Transform GetSkeletonJointTransform(string inName)
	{
		return null;
	}

	public Transform GetJointTransformWithAttachNode(ActorAttachNodeDefComponent inAttachNode)
	{
		return null;
	}

	private void InitSurfaceFXNodes()
	{
	}

	private void AddSurfaceFXTerrainNodeToJoint(string inJointName)
	{
	}

	private void AddSurfaceFXWaterNodeToJoint(string inJointName)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	public static void ClearRegistered()
	{
	}

	public static ActorBase CreateActor(string inWorldObjectDefID, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback)
	{
		return null;
	}

	public ActorBase CreateActorClone(string inWorldObjectDefID, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback)
	{
		return null;
	}

	public ActorBase CreateActorClone(Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback)
	{
		return null;
	}

	private void RefreshRebuild()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	protected virtual void OnActorStart()
	{
	}

	protected virtual void OnActorDestroy()
	{
	}

	public bool IsVisibleAndCloseToCamera([Optional] Camera inCamera, float inMaxSqrDist = 30f)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<Build>d__562))]
	public override IEnumerator Build()
	{
		return null;
	}

	public QRoutine WaitForBuild()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForBuildRoutine>d__566))]
	public IEnumerator WaitForBuildRoutine()
	{
		return null;
	}

	protected virtual void OnFinishedBuilding()
	{
	}

	public void SetActorLayer()
	{
	}

	private void MUpdateOffsetTransform()
	{
	}

	public void ClearCachedChildRenderers()
	{
	}

	private void MUpdateMeshVisibility()
	{
	}

	public override void MUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void UnBuild()
	{
	}

	private void OnValidate()
	{
	}

	private void RegisterAsNetworkAvatar()
	{
	}

	private void UnregisterAsNetworkAvatar()
	{
	}
}
