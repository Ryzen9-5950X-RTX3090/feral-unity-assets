using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using WW.Debug;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryController : ManagedBehaviour
{
	[Serializable]
	public class Data
	{
		public List<SanctuarySurface> sanctuarySurfaces;

		private Light[] _mainLights;

		public Light[] mainLights
		{
			get
			{
				return null;
			}
		}

		public int GetHighestSurfaceIndex()
		{
			return default(int);
		}
	}

	public enum EState
	{
		None,
		Edit,
		GreenhouseEdit
	}

	public enum ETime
	{
		Day,
		Night
	}

	public enum ELocation
	{
		Exterior,
		Interior
	}

	public class LightInfo
	{
		public float intensity;

		public float bounceIntensity;

		public Color color;
	}

	public enum ECursorMode
	{
		NONE,
		CAMERAMOVE,
		CAMERAROTATE,
		OBJECTMOVE,
		OBJECTROTATE
	}

	private SanctuaryLayoutData _layoutData;

	private GameObject _interiorLights;

	private GameObject _exteriorLights;

	private List<Light> _interiorLightComponents;

	private List<Light> _exteiorLightComponents;

	private List<RoomData> _changedServerRoomData;

	private List<RoomData> _serverRoomData;

	private List<RoomData> _serverRoomDataInitialized;

	private static int _playerAndCameraCollisionLayer;

	private static int _playerCollisionLayer;

	private static int _sanctuaryLayer;

	private static int _sanctuaryLayerMask;

	private string _sanctuaryName;

	private int _placementLimit;

	public Data data;

	private EState _desiredState;

	public List<SanctuaryObjectBase> sanctuaryObjectsInScene;

	public static Action<SanctuaryObjectBase> OnSanctuaryObjectAdded;

	public static Action<SanctuaryObjectBase> OnSanctuaryObjectRemoved;

	private GameObject _cursorSanctuaryCameraMove;

	private GameObject _cursorSanctuaryCameraRotate;

	private GameObject _cursorSanctuaryObjectMove;

	private GameObject _cursorSanctuaryObjectRotate;

	private SanctuaryCamera _sanctuaryCamera;

	private UI_Sanctuary _sanctuaryUI;

	private GameObject _exteriorGreenhouseDecorationGround;

	private GameObject _exteriorGreenhouseBuildGround;

	private GameObject _exteriorGreenhouseGround;

	private GameObject _exteriorDecorationGround;

	private GameObject _exteriorBuildGround;

	private GameObject _exteriorHouseGround;

	private SanctuarySafeSpawnObject _exteriorSafeSpawnObject;

	private GameObject _skyboxExteriorGameObject;

	private GameObject _skyboxInteriorGameObject;

	private GameObject _respawnInterior;

	private GameObject _respawnExterior;

	private SanctuaryInterior _sanctuaryInterior;

	private GameObject _safeSpawnExterior;

	private GameObject _safeSpawnHouseEntrance;

	private GameObject _safeSpawnInterior;

	private GameObject _mySanctuaryObject;

	private GameObject _mySanctuaryInterior;

	private GameObject _mySanctuaryExterior;

	private GameObject _mySanctuaryHouse;

	private GameObject _mySanctuaryIsland;

	private GameObject _mySanctuaryGround;

	private GameObject _myGreenhouseGround;

	private GameObject _materialParent;

	private GameObject _portalToInteriorObject;

	private SanctuaryPortal _portalToInterior;

	public List<SanctuaryObjectBase> childSanctuaryObjectBases;

	public List<SanctuaryObjectBase> activeSanctuaryObjectBases;

	public SanctuaryObjectBase activeSanctuaryObjectBaseHouse;

	public SanctuaryObjectBase activeSanctuaryObjectBaseIsland;

	private List<SanctuaryAudio> _exteriorMusicObjects;

	private List<SanctuaryAudio> _interiorMusicObjects;

	private SanctuaryObjectBase _currentSanctuaryObject;

	private Camera _cachedCamera;

	private UI3D_SanctuaryItem _sanctuaryItem3DUI;

	public float respawnExteriorY;

	public GameObject _highlightTracker;

	public GameObject[] _highlights;

	public Material[] _highlightMaterials;

	[SerializeField]
	private GameObject _shopTwiggle;

	[SerializeField]
	private GameObject _workerTwiggle;

	private bool _teleporting;

	private float _priorStepHeight;

	private SanctuarySurface _priorControlledSurface;

	private SanctuarySurface _controlledSurface;

	private LayerMask _cameraCullingMask;

	private bool? _wasInterior;

	private bool _selectedObjectMove;

	private bool _selectedObjectMoveLastUpdate;

	private bool _selectedObjectRotate;

	private bool _selectedObjectRotateLastUpdate;

	private bool _leftMouseButtonDown;

	private bool _leftMouseButtonUp;

	private bool _leftMouseButton;

	private bool _rightMouseButtonDown;

	private bool _rightMouseButtonUp;

	private bool _rightMouseButton;

	private bool _saved;

	private bool _LMBWasDown;

	private bool _RMBWasDown;

	private Vector3 _leftMouseDelta;

	private Vector3 _leftMousePosition;

	private Vector3 _rightMouseDelta;

	private Vector3 _rightMousePosition;

	private List<UpdateItem> updateItems;

	private List<RemoveItem> removeItems;

	private List<LightInfo> _priorLightInfos;

	private static string[] _includedTransformNames;

	private static string[] _excludedTransformNames;

	private static string[] _includedMaterialNames;

	private static string[] _excludedMaterialNames;

	public static SanctuaryController instance
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

	public SanctuaryLayoutData layoutData
	{
		get
		{
			return null;
		}
	}

	public GameObject interiorLights
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorLights
	{
		get
		{
			return null;
		}
	}

	public int expansionIdx
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int purchasedRoomIdx
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<int> enlargedAreas
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

	public List<int> purchasedEnlargedAreas
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

	public int modifiedExpansionIdx
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<int> modifiedEnlargedAreas
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

	public int modifiedPurchaseExpansionIdx
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<SanctuaryHouseDefComponent.TwiggleBuildLocation> twiggleBuildLocations
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

	public static int playerAndCameraCollisionLayer
	{
		get
		{
			return default(int);
		}
	}

	public static int playerCollisionLayer
	{
		get
		{
			return default(int);
		}
	}

	public static int sanctuaryLayer
	{
		get
		{
			return default(int);
		}
	}

	public static int sanctuaryLayerMask
	{
		get
		{
			return default(int);
		}
	}

	public string sanctuaryName
	{
		get
		{
			return null;
		}
	}

	public int placementLimit
	{
		get
		{
			return default(int);
		}
	}

	public EState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(EState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ETime currentTime
	{
		[CompilerGenerated]
		get
		{
			return default(ETime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SanctuaryCamera sanctuaryCamera
	{
		get
		{
			return null;
		}
	}

	public UI_Sanctuary sanctuaryUI
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorGreenhouseDecorationGround
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorGreenhouseBuildGround
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorGreenhouseGround
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorDecorationGround
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorBuildGround
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorHouseGround
	{
		get
		{
			return null;
		}
	}

	public SanctuarySafeSpawnObject exteriorSafeSpawnObject
	{
		get
		{
			return null;
		}
	}

	public GameObject skyboxExteriorGameObject
	{
		get
		{
			return null;
		}
	}

	public GameObject skyboxInteriorGameObject
	{
		get
		{
			return null;
		}
	}

	public GameObject respawnInterior
	{
		get
		{
			return null;
		}
	}

	public GameObject respawnExterior
	{
		get
		{
			return null;
		}
	}

	public SanctuaryInterior sanctuaryInterior
	{
		get
		{
			return null;
		}
	}

	public GameObject safeSpawnExterior
	{
		get
		{
			return null;
		}
	}

	public GameObject safeSpawnHouseEntrance
	{
		get
		{
			return null;
		}
	}

	public GameObject safeSpawnInterior
	{
		get
		{
			return null;
		}
	}

	public GameObject mySanctuaryObject
	{
		get
		{
			return null;
		}
	}

	public GameObject mySanctuaryInterior
	{
		get
		{
			return null;
		}
	}

	public GameObject mySanctuaryExterior
	{
		get
		{
			return null;
		}
	}

	public GameObject mySanctuaryHouse
	{
		get
		{
			return null;
		}
	}

	public GameObject mySanctuaryIsland
	{
		get
		{
			return null;
		}
	}

	public GameObject mySanctuaryGround
	{
		get
		{
			return null;
		}
	}

	public GameObject myGreenhouseGround
	{
		get
		{
			return null;
		}
	}

	public GameObject materialParent
	{
		get
		{
			return null;
		}
	}

	public GameObject portalToInteriorObject
	{
		get
		{
			return null;
		}
	}

	public SanctuaryPortal portalToInterior
	{
		get
		{
			return null;
		}
	}

	public static bool roomOpenL
	{
		get
		{
			return default(bool);
		}
	}

	public static bool roomOpenR
	{
		get
		{
			return default(bool);
		}
	}

	public static bool roomOpenF
	{
		get
		{
			return default(bool);
		}
	}

	public static bool roomOpenB
	{
		get
		{
			return default(bool);
		}
	}

	public static bool roomOpenUp
	{
		get
		{
			return default(bool);
		}
	}

	public static bool roomOpenDown
	{
		get
		{
			return default(bool);
		}
	}

	public RaycastHit lastSurfaceRaycastHit
	{
		[CompilerGenerated]
		get
		{
			return default(RaycastHit);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SanctuarySurface lastSurface
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

	public RaycastHit activeSurfaceRaycastHit
	{
		[CompilerGenerated]
		get
		{
			return default(RaycastHit);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SanctuarySurface activeSurface
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

	public RaycastHit activeSanctuaryObjectRaycastHit
	{
		[CompilerGenerated]
		get
		{
			return default(RaycastHit);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SanctuaryObjectBase activeSanctuaryObject
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

	public SanctuaryObjectBase currentSanctuaryObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Camera cachedCamera
	{
		get
		{
			return null;
		}
	}

	public static string defaultPrefix
	{
		get
		{
			return null;
		}
	}

	public SanctuarySurface controlledSurface
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SanctuaryIndoorRoom currentRoom
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

	public bool isInterior
	{
		get
		{
			return default(bool);
		}
	}

	public float holdTime
	{
		get
		{
			return default(float);
		}
	}

	public float leftMouseButtonHoldTimer
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

	public float rightMouseButtonHoldTimer
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

	public static float deltaTime
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

	public bool moveObject
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool rotateObject
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool wasMoveObject
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool wasRotateObject
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool hasInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool defaultMaterialsInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool hasInitializedInterior
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	internal void MoveObjectToScreenPosition(SanctuaryObjectBase inObjectToMove, Vector2 inScreenPos)
	{
	}

	public override void MStart()
	{
	}

	private void OnWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private void OnWindowClosed(WindowClosedMessage inMessage)
	{
	}

	public void InitializeSanctuary(SanctuaryLayoutData inLayoutData, int inCurrentExpansionIdx, int inPurchasedRoomIdx, List<int> inCurrentEnlargedAreas, List<int> inPurchasedEnlargedAreas, List<SanctuaryHouseDefComponent.TwiggleBuildLocation> inTwiggleBuildLocations)
	{
	}

	[IteratorStateMachine(typeof(<AssignDefaultMatToLayoutData>d__312))]
	private IEnumerator AssignDefaultMatToLayoutData(string inDefId, Action<Material> inMaterial)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<InitializeSanctuaryCoroutine>d__313))]
	private IEnumerator InitializeSanctuaryCoroutine()
	{
		return null;
	}

	private void SetupWorldMapLocations()
	{
	}

	private List<Transform> AddSpawns(List<Transform> inList, Transform inSpawn)
	{
		return null;
	}

	private List<Transform> AddSpawns(List<Transform> inList, List<Transform> inSpawns)
	{
		return null;
	}

	private void SetDefaultMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryIndoorRoom inSanctuaryIndoorRoom)
	{
	}

	private void SetDefaultMaterials(SanctuaryIndoorRoom inSanctuaryIndoorRoom, SanctuaryItemCategory? inCategory)
	{
	}

	private SanctuaryObjectBase CreateTempSanctuaryObjectBase(int inRoomId)
	{
		return null;
	}

	private Item CreateNewItem(ItemType inItemType, BaseDef inDef)
	{
		return null;
	}

	public void Decorate(bool inDecorate)
	{
	}

	public void TeleportToSafeArea(bool inFade, bool inSkipUpdateItens = false)
	{
	}

	[IteratorStateMachine(typeof(<TeleportToSafeAreaCoroutine>d__323))]
	private IEnumerator TeleportToSafeAreaCoroutine(bool inFade, bool inSkipUpdateItens)
	{
		return null;
	}

	private static Transform GetTransformFromName(Transform inTransform, string[] inExcludeNames, string[] inNames)
	{
		return null;
	}

	public static Transform GetTransform(List<Transform> inTransforms, string[] inExcludeNames, string[] inNames)
	{
		return null;
	}

	public static List<Transform> GetTransforms(List<Transform> inTransforms, string[] inExcludeNames, string[] inNames)
	{
		return null;
	}

	public void SetExteriorInteriorFlooring(Material inMaterial)
	{
	}

	public void SetExteriorInteriorWallpaper(Material inMaterial)
	{
	}

	public static void DestroyMeshRenderer(Transform inTransform)
	{
	}

	public static void DestroyMeshRenderer(GameObject inGameObject)
	{
	}

	private void AddCursors()
	{
	}

	private void SetCursor(ECursorMode inMode)
	{
	}

	public void SetIndoorMaterials(SanctuaryItemCategory inCategory, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId)
	{
	}

	[IteratorStateMachine(typeof(<SetIndoorMaterialCoroutine>d__334))]
	private IEnumerator SetIndoorMaterialCoroutine(SanctuaryItemCategory inCategory, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId)
	{
		return null;
	}

	private void SetIndoorMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId)
	{
	}

	[IteratorStateMachine(typeof(<GetSanctuaryMaterial>d__336))]
	private static IEnumerator GetSanctuaryMaterial(GameObject inGameObject, BaseDef inBaseDef, Action<Material> inResult)
	{
		return null;
	}

	public void SetActiveIsland(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void SetActiveHouse(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void AddChildSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void RemoveChildSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void AddActiveSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void RemoveActiveSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	private void CheckLimitReached()
	{
	}

	private void UpdateParents()
	{
	}

	private void UpdateSanctuarySurfaces()
	{
	}

	private SanctuaryObjectBase GetSanctuaryObjectAtMousePosition(out RaycastHit outHit, bool inCheckCurrentSanctuaryObject = false)
	{
		return null;
	}

	public SanctuaryObjectBase GetSanctuaryObjectAtScreenPosition(Vector3 inScreenPosition, out RaycastHit outHit, bool inCheckCurrentSanctuaryObject = false)
	{
		return null;
	}

	private void UpdateCurrentSanctuaryObject()
	{
	}

	public static void DestroyColliders(List<Transform> inTransforms)
	{
	}

	private void UpdateActiveSanctuaryObject()
	{
	}

	public static void CreateMeshCollidersForHouse(GameObject inGameObject)
	{
	}

	public static void CreateMeshCollidersForIsland(GameObject inGameObject)
	{
	}

	public static MeshCollider CreateMeshCollider(GameObject inGameObject)
	{
		return null;
	}

	public static void CreateHouseCollider(GameObject inGameObject)
	{
	}

	public static void CreateTouchCollider(List<GameObject> inGameObjects)
	{
	}

	public static BoxCollider CreateTouchCollider(GameObject inGameObject)
	{
		return null;
	}

	public static void CreateMeshColliderPlayer(List<GameObject> inGameObjects)
	{
	}

	public static MeshCollider CreateMeshColliderPlayer(GameObject inGameObject)
	{
		return null;
	}

	public void SpawnWorldPortal(Transform inParent)
	{
	}

	private void ChangeExteriorComponent(string inName, int inIndex)
	{
	}

	private void ChangeExteriorComponentColor(string inName, Color inColor1, Color inColor2)
	{
	}

	public static void SplitAllMaterialsTracked(Transform inTransform)
	{
	}

	private static bool SkipTransformPerName(string inName)
	{
		return default(bool);
	}

	private static bool SkipMaterialPerName(string inName)
	{
		return default(bool);
	}

	public static void SplitMaterials(List<Transform> inTransforms)
	{
	}

	public static void SplitMaterials(Transform inTransforms)
	{
	}

	public static List<MeshRenderer> GetMeshRenderers(List<Transform> inList)
	{
		return null;
	}

	public static void SetMaterial(List<Transform> inTransforms, Material inMaterial, bool bAllowSkip = true)
	{
	}

	public static void SetMaterial(GameObject inGameObject, Material inMaterial, bool bAllowSkip = true)
	{
	}

	public static void SetMaterial(Transform inTransform, Material inMaterial, bool bAllowSkip = true)
	{
	}

	public static void SetMaterial(MeshRenderer inMeshRenderer, Material inMaterial, bool bAllowSkip = true)
	{
	}

	public static List<Material> GetMaterials(List<Transform> inList)
	{
		return null;
	}

	public static List<Transform> GetRenderersTransform(Transform inParent)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SetStepHeight>d__378))]
	private IEnumerator SetStepHeight()
	{
		return null;
	}

	public void OnCloseDecorateWindow()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnSanctuaryInteriorExteriorChange(SanctuaryInteriorExteriorChange inMessage)
	{
	}

	private void SetPriorStepHeight(float inStepHeight)
	{
	}

	private void SetStepHeight(float inStepHeight)
	{
	}

	private void OnSanctuaryTeleportMessage(SanctuaryTeleportMessage inMessage)
	{
	}

	private void FadeToBlack(float inTime = 1f)
	{
	}

	private void FadeToGame(float inTime = 1f)
	{
	}

	[IteratorStateMachine(typeof(<Fade>d__387))]
	private IEnumerator Fade(SanctuaryTeleportMessage inMessage)
	{
		return null;
	}

	private void OnSanctuaryIndoorRoomMessage(SanctuaryIndoorRoomMessage inMessage)
	{
	}

	public void AddSanctuaryObject(SanctuaryObjectBase inSanctuaryObject)
	{
	}

	public void RemoveSanctuaryObject(SanctuaryObjectBase inSanctuaryObject)
	{
	}

	private void RevertMaterialToDefault(SanctuaryObjectBase inSanctuaryObject)
	{
	}

	public void RemoveAllSanctuaryObjectsInRoom()
	{
	}

	public void RemoveAllSanctuaryObjectsInRoom(int inRoomIdx, bool inForceServerUpdate = false)
	{
	}

	[DebugButton("Save My Sanctuary State", "Sanctuary", false, false)]
	public void SaveMySanctuaryState()
	{
	}

	[IteratorStateMachine(typeof(<UpdateLights>d__395))]
	private IEnumerator UpdateLights()
	{
		return null;
	}

	public void OnNonOwnerUpdateMessage(SanctuaryXtHandler.DenStateUpdateResponse inMessage)
	{
	}

	public void RemoveItem(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void UpdateItem(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public override void MUpdate()
	{
	}

	private void UpdateCameraMode()
	{
	}

	public static bool IsOnGround(Vector3 inNormalDir)
	{
		return default(bool);
	}

	private void SetActiveSkybox(bool inInterior)
	{
	}

	private void SetActiveLights(bool inInterior)
	{
	}

	private void SetActiveAudio(List<SanctuaryAudio> inSanctuaryAudios, bool inActive)
	{
	}

	public static string AddOrdinal(int inValue)
	{
		return null;
	}

	public string GetFloorName()
	{
		return null;
	}

	private void SetSanctuaryObjectActive(SanctuaryObjectBase inSanctuaryObject, bool inActive)
	{
	}

	private void UpdateActions()
	{
	}

	private RaycastHit GetActiveHit()
	{
		return default(RaycastHit);
	}

	private void SetLastGood()
	{
	}

	[IteratorStateMachine(typeof(<ShouldTeleport>d__411))]
	private IEnumerator ShouldTeleport(Action<bool> result)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<CheckTeleportToSafeArea>d__412))]
	private IEnumerator CheckTeleportToSafeArea()
	{
		return null;
	}

	private void UpdateState()
	{
	}

	public void UpdateHighlightColor(bool inValidPosition)
	{
	}

	private void Ray(Ray inRay, int inLayermask, Action<Vector3?> HitPoint)
	{
	}

	private void CreateHighlight()
	{
	}

	private void UpdateHighlight()
	{
	}

	private static void OnSanctuaryObjectUpdateMessage(SanctuaryObjectUpdateMessage inMessage)
	{
	}

	public static Quaternion GetSurfaceRotation(Vector3 inNormal, Transform inTransform)
	{
		return default(Quaternion);
	}

	public bool ItemIsEquipped(Item inItem)
	{
		return default(bool);
	}

	public void SpawnFromUI(Item inItem, bool inWasDragged = false, [Optional] BaseDef inFakeObject, [Optional] Action<GameObject> Callback)
	{
	}

	public void RemoveFromUI(Item inItem, int inRoomIdx = -1)
	{
	}

	private void SpawnPlacedItemFromUI(Item inItem, bool inWasDragged = false, [Optional] BaseDef inFakeObject, [Optional] Action<GameObject> Callback)
	{
	}

	[IteratorStateMachine(typeof(<MovePlacedItemFromUI>d__424))]
	private IEnumerator MovePlacedItemFromUI(SanctuaryObjectBase inSanctuaryObjectBase)
	{
		return null;
	}

	private SanctuarySurface GetSurfaceFromRay(bool inWasDragged, out Vector3 oPosition, out int oSurfaceIndex)
	{
		return null;
	}

	public int GetSurfaceIndex(SanctuaryObjectBase inSanctuaryObject)
	{
		return default(int);
	}

	public int GetSurfaceIndex(SanctuarySurface inSanctuarySurface)
	{
		return default(int);
	}

	public Vector3 GetWorldPosition(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inLocalPosition)
	{
		return default(Vector3);
	}

	public Vector3 GetLocalPosition(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inWorldPosition)
	{
		return default(Vector3);
	}

	public void SetPositionAndRotation(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inLocalPosition, Quaternion inWorldRotation)
	{
	}

	public SanctuarySurface GetSanctuarySurface(int inIndex)
	{
		return null;
	}

	public void AddSurfaces(SanctuarySurface[] inSanctuarySurfaces)
	{
	}

	public void SetState(EState inState)
	{
	}

	public void GoToRoomLeft()
	{
	}

	public void GoToRoomRight()
	{
	}

	public void GoToRoomForward()
	{
	}

	public void GoToRoomBack()
	{
	}

	public void GoToRoomUpstairs()
	{
	}

	public void GoToRoomDownstairs()
	{
	}

	public void GoToDayTime()
	{
	}

	public void GoToNightTime()
	{
	}

	private void UpdateTime()
	{
	}

	public void GoToInterior()
	{
	}

	public void GoToExterior()
	{
	}

	public void CameraReset()
	{
	}

	public void CameraZoomOut()
	{
	}

	public void CameraZoomIn()
	{
	}

	public void RoomUpgrade()
	{
	}

	public void RoomDowngrade()
	{
	}

	public void SaveChanges()
	{
	}

	public void LoadSanctuaryLook(SanctuaryLookItemComponent inSanctuaryLook)
	{
	}

	public void BuildInteriorLayout()
	{
	}

	private void CreateSanctuaryGrounds()
	{
	}

	private void CreateGreenhouseGrounds()
	{
	}

	private void InstanceInteriorRooms()
	{
	}

	private void CreateSanctuaryIndoorRooms()
	{
	}

	public void SetSafeSpawnHouseEntrance(Vector3 inPosition, Vector3 inRotation)
	{
	}

	public SanctuaryIndoorRoom GetRoomIndex(int inIdx)
	{
		return null;
	}

	public SanctuaryIndoorRoom GetRoomIndex(SanctuarySurface inSurface)
	{
		return null;
	}

	private void SetRoomIndexes()
	{
	}

	private void SetRoomSizes()
	{
	}

	private void SetInteriorRoomDoors()
	{
	}

	public bool GetIsInCurrentRoom(Item inItem)
	{
		return default(bool);
	}

	public string GetRoomIdForUI(Item inItem)
	{
		return null;
	}

	private int GetRoomIndexFromRoom(SanctuaryObjectBase inSanctuaryObjectBase)
	{
		return default(int);
	}

	private string GetIdFromRoomForUI(SanctuaryObjectBase inSanctuaryObjectBase)
	{
		return null;
	}

	public string GetRoomIdForUI(int inRoomIndex)
	{
		return null;
	}

	public string GetRoomIdForUI()
	{
		return null;
	}

	public void SetRoomIdFromUI(int inRoomIndex, string inString)
	{
	}

	private void UpdateChangedServerRoomData()
	{
	}

	private RoomData GetServerRoomData(int inRoomIndex)
	{
		return null;
	}

	public void SetRoomIdFromUI(string inString)
	{
	}

	private string GetLocallySavedRoomIdFromRoomIndex(int inRoomIndex)
	{
		return null;
	}

	public float GetRoomLightRotation(int inRoomIndex)
	{
		return default(float);
	}

	public string GetRoomLightColor(int inRoomIndex)
	{
		return null;
	}

	public float GetRoomLightBrightness(int inRoomIndex)
	{
		return default(float);
	}

	private void SetInteriorRoomAddOns()
	{
	}

	public BaseDef GetExpansionDef(int inRoomId)
	{
		return null;
	}

	public BaseDef GetUpgradeDef(int inRoomId)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SpawnPortalToInterior>d__480))]
	private IEnumerator SpawnPortalToInterior()
	{
		return null;
	}

	private void CreateAudio()
	{
	}

	private void CreateRespawns()
	{
	}

	private GameObject CreateBoundary(GameObject inParent, Vector3 inSize)
	{
		return null;
	}

	private GameObject Instance(GameObject inPrefab, GameObject inParent)
	{
		return null;
	}

	private GameObject CreateCubeObject(GameObject inPrefab, GameObject inParent, bool inCastShadows = false)
	{
		return null;
	}

	private static void SetCollider(GameObject inGameObject)
	{
	}

	private bool RoomIsEnlarged(int inRoomIdx)
	{
		return default(bool);
	}

	private GameObject InstanceRoom(SanctuaryLayoutData.RoomData inRoomData, SanctuaryIndoorRoom inSanctuaryIndoorRoom, Transform inParent)
	{
		return null;
	}

	private int GetCurrentRoomIndex()
	{
		return default(int);
	}

	public List<Light> GetLights()
	{
		return null;
	}

	public float GetLightIntensity()
	{
		return default(float);
	}

	public void ChangeLightIntensity(float inIntensity)
	{
	}

	private void ChangeLightIntensityFromRoom()
	{
	}

	public float GetLightRotation()
	{
		return default(float);
	}

	public void ChangeLightRotation(float inValue)
	{
	}

	private void ChangeLightRotationFromRoom()
	{
	}

	public void SetCurrentLightsToWhite()
	{
	}

	public void RevertCurrentLightColor()
	{
	}

	public SanctuaryLightDefComponent GetLightColor()
	{
		return null;
	}

	public void ChangeLightColor(SanctuaryLightDefComponent inValue)
	{
	}

	private void ChangeLightColorFromRoom()
	{
	}

	public void InitializeRoomDetails(List<RoomData> inRoomData)
	{
	}

	public static void SetCastShadowsOff(GameObject inGameObject, bool inIncludeChildren)
	{
	}

	public static void SetCastAndReceiveShadowsOff(List<Transform> inTransforms)
	{
	}

	public static void SetCastAndReceiveShadowsOff(GameObject inGameObject)
	{
	}

	public static void SetCastAndReceiveShadowsOff(Transform inTransform)
	{
	}

	public static void RemoveColliders(List<Transform> inTransforms)
	{
	}

	public static void RemoveColliders(Transform inTransform)
	{
	}

	public static void AddSanctuarySurfaceComponent(List<Transform> inTransforms)
	{
	}

	public static void AddSanctuarySurfaceComponent(Transform inTransform)
	{
	}

	public static void AddSanctuarySurfaceComponent(GameObject inGameObject)
	{
	}

	private GameObject CreateSpawn(GameObject inParent, float inWallY, float inDoorY)
	{
		return null;
	}

	public static void BuildSanctuaryForUI(Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, int inModIndex = -1)
	{
	}

	public static void BuildHouseModForUI(SanctuaryHouseGetModelDefComponent.EHouseMod inType, Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, int inModIndex = -1)
	{
	}

	public bool IsPurchasingRoomOrRoomUpgrade(int inRoomIndex, [Optional] TwiggleItemComponent currentTwiggleJob)
	{
		return default(bool);
	}

	public bool IsPurchasingRoom(int inRoomIndex, [Optional] TwiggleItemComponent currentTwiggleJob)
	{
		return default(bool);
	}

	public bool IsPurchasingRoomUpgrade(int inRoomIndex, [Optional] TwiggleItemComponent currentTwiggleJob)
	{
		return default(bool);
	}

	public bool CanPurchaseRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool CanPurchaseUpgradeRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool CanUpgradeRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool CanDowngradeRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool CanDisableRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool CanEnableRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool CanAddRoom()
	{
		return default(bool);
	}

	public bool GetIsEntranceRoom(int inRoomIndex)
	{
		return default(bool);
	}

	public bool GetRoomUpgradePurchased(int inRoomIndex)
	{
		return default(bool);
	}

	public void SetEnabledRoom(int inRoomIndex)
	{
	}

	public void SetDisabledRoom(int inRoomIndex)
	{
	}

	public void SetPurchaseRoom(int inRoomIndex)
	{
	}

	public void SetUpgrade(int inRoomIndex)
	{
	}

	public void SetPurchaseUpgrade(int inRoomIndex, bool inUpgrade)
	{
	}

	public void SetDowngrade(int inRoomIndex)
	{
	}

	public bool HasModifications()
	{
		return default(bool);
	}

	public bool HasPurchases()
	{
		return default(bool);
	}

	private void ClearPendingPurchases()
	{
	}

	public bool GetRoomEnabled(int inRoomIndex)
	{
		return default(bool);
	}

	public bool GetRoomPurchased(int inRoomIndex)
	{
		return default(bool);
	}

	public bool GetRoomUpgraded(int inRoomIndex)
	{
		return default(bool);
	}

	public bool IsDowngradingAnyRoom()
	{
		return default(bool);
	}

	public bool AnyFurnitureInDowngradingRooms()
	{
		return default(bool);
	}

	private bool SanctuaryObjectExistsInRoom(SanctuaryIndoorRoom inRoom)
	{
		return default(bool);
	}

	public bool AnyFurnitureInRoom(int inRoomIdx = -1)
	{
		return default(bool);
	}

	public void SetSanctuaryJobStart()
	{
	}

	private void ClearAnyDowngradedRooms()
	{
	}

	private void VerifyPurchaseVariable()
	{
	}

	public void ResetSanctuaryJobVariables()
	{
	}

	public void ClearPurchase()
	{
	}

	public void ClearModifications()
	{
	}

	public void SetSanctuaryJobComplete()
	{
	}
}
