using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MinimapManager : SingletonManagerBase<MinimapManager>
{
	public enum ERotationType
	{
		RotateMap,
		RotatePlayer
	}

	public enum EBlipType
	{
		None,
		CityFera,
		Clothing,
		Dye,
		Expanse,
		HarvestPoint,
		MainQuest,
		CasualGame,
		Player,
		Friend,
		NetworkPlayer,
		Portal,
		SideQuest,
		SpecificLocation,
		TradingPost,
		TreasureChest,
		UnitOfCinder,
		Npc,
		Area,
		BlackMarket,
		Lounge,
		SunkenThicket,
		Uncrafting,
		Furniture,
		ParlorGame,
		QuestGiver,
		DailyQuest,
		DailyQuestGiver,
		SpawnPoint,
		QuestHarvestPoint,
		SkyMerchant,
		Max
	}

	[Serializable]
	public class MinimapDetails
	{
		public float blipScale;

		public float blipAreaScale;

		public float indicatorScale;

		public float indicatorEdgeBuffer;

		public float mapScale;

		public float radius;

		public float zoomAmount;

		public float zoom;

		public float zoomMin;

		public float zoomMax;
	}

	[Serializable]
	public class SavedBlipDisplay
	{
		public List<EBlipType> blipTypes;

		public List<bool> enabled;
	}

	private class BlipPriorityParent
	{
		public int priority;

		public RectTransform rectTransform;
	}

	[SerializeField]
	private ERotationType _rotationType;

	[RootSelector("Blip CityFera", "BundleIDChartData", false, false)]
	public string blipCityFera;

	[RootSelector("Blip Clothing", "BundleIDChartData", false, false)]
	public string blipClothing;

	[RootSelector("Blip Dye", "BundleIDChartData", false, false)]
	public string blipDye;

	[RootSelector("Blip Expanse", "BundleIDChartData", false, false)]
	public string blipExpanse;

	[RootSelector("Blip Harvest Point", "BundleIDChartData", false, false)]
	public string blipHarvestPoint;

	[RootSelector("Blip Main Quest", "BundleIDChartData", false, false)]
	public string blipMainQuest;

	[RootSelector("Blip Quest Giver", "BundleIDChartData", false, false)]
	public string blipQuestGiver;

	[RootSelector("Blip Parlor Game", "BundleIDChartData", false, false)]
	public string blipParlorGame;

	[RootSelector("Blip Player", "BundleIDChartData", false, false)]
	public string blipPlayer;

	[RootSelector("Blip Friend", "BundleIDChartData", false, false)]
	public string blipFriend;

	[RootSelector("Blip Network Player", "BundleIDChartData", false, false)]
	public string blipNetworkPlayer;

	[RootSelector("Blip Portal", "BundleIDChartData", false, false)]
	public string blipPortal;

	[RootSelector("Blip Side Quest", "BundleIDChartData", false, false)]
	public string blipSideQuest;

	[RootSelector("Blip Specific Location", "BundleIDChartData", false, false)]
	public string blipSpecificLocation;

	[RootSelector("Blip Trading Post", "BundleIDChartData", false, false)]
	public string blipTradingPost;

	[RootSelector("Blip Treasure Chest", "BundleIDChartData", false, false)]
	public string blipTreasureChest;

	[RootSelector("Blip Unit of Cinder", "BundleIDChartData", false, false)]
	public string blipUnitOfCinder;

	[RootSelector("Blip NPC", "BundleIDChartData", false, false)]
	public string blipNpc;

	[RootSelector("Blip Area", "BundleIDChartData", false, false)]
	public string blipArea;

	[RootSelector("Black Market", "BundleIDChartData", false, false)]
	public string blipBlackMarket;

	[RootSelector("Lounge", "BundleIDChartData", false, false)]
	public string blipLounge;

	[RootSelector("Sunken Thicket", "BundleIDChartData", false, false)]
	public string blipSunkenThicket;

	[RootSelector("Uncrafting", "BundleIDChartData", false, false)]
	public string blipUncrafting;

	[RootSelector("Furniture", "BundleIDChartData", false, false)]
	public string blipFurniture;

	[RootSelector("Casual", "BundleIDChartData", false, false)]
	public string blipCasualGame;

	[RootSelector("Blip Daily Quest", "BundleIDChartData", false, false)]
	public string blipDailyQuest;

	[RootSelector("Blip Daily Quest Giver", "BundleIDChartData", false, false)]
	public string blipDailyQuestGiver;

	[RootSelector("Blip Quest Harvest Point", "BundleIDChartData", false, false)]
	public string blipQuestHarvestPoint;

	[RootSelector("Blip Sky Merchant", "BundleIDChartData", false, false)]
	public string blipSkyMerchant;

	[SerializeField]
	private FeralAudioInfo _audioZoomIn;

	[SerializeField]
	private FeralAudioInfo _audioZoomOut;

	[SerializeField]
	private FeralAudioInfo _audioMap;

	[SerializeField]
	private Material _minimapMaterial;

	[SerializeField]
	private Color _colorFollowFavorite;

	[SerializeField]
	private Color _colorFollow;

	[SerializeField]
	private Color _colorNetworkPlayer;

	[SerializeField]
	[RootSelector("Blip UI Reference", "BundleIDChartData", false, false)]
	private string _blipPrefabId;

	private UI_MinimapBlip _blipUIPrefabReference;

	[SerializeField]
	private bool _tooltipsOnBlips;

	private GameObject _minimapCloned;

	private float _screenWidth;

	private float _screenHeight;

	private float _screenMin;

	private Vector3 _screenCenter;

	public List<MinimapBlip> minimapBlips;

	private bool _showMap;

	private int _playerMinimapLevel;

	public MinimapDetails minimap;

	public MinimapDetails minimapExpanded;

	public bool IsExpanded;

	[SerializeField]
	private float _displayOffscreenRotationNudge;

	private SavedBlipDisplay _savedBlipDisplay;

	private WeatherState? _lastWeatherState;

	private string _weatherString;

	private List<BlipPriorityParent> _priorityTransforms;

	private List<BlipPriorityParent> _priorityTransformsExpanded;

	private bool _priorityTransformListIsDirty;

	private List<MinimapBlip> _blipsToInitialize;

	private IEnumerator _initializer;

	private bool _initializerNeedsSorting;

	public ERotationType rotationType
	{
		get
		{
			return default(ERotationType);
		}
	}

	public Color colorFollowFavorite
	{
		get
		{
			return default(Color);
		}
	}

	public Color colorFollow
	{
		get
		{
			return default(Color);
		}
	}

	public Color colorNetworkPlayer
	{
		get
		{
			return default(Color);
		}
	}

	public bool tooltipsOnBlips
	{
		get
		{
			return default(bool);
		}
	}

	public Material minimapMaterial
	{
		get
		{
			return null;
		}
	}

	private Vector3 screenCenter
	{
		get
		{
			return default(Vector3);
		}
	}

	public MinimapMap minimapMap
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

	public float mapScale
	{
		get
		{
			return default(float);
		}
	}

	public float blipAreaScale
	{
		get
		{
			return default(float);
		}
	}

	public float blipScale
	{
		get
		{
			return default(float);
		}
	}

	public float indicatorScale
	{
		get
		{
			return default(float);
		}
	}

	public float indicatorEdgeBuffer
	{
		get
		{
			return default(float);
		}
	}

	public float radius
	{
		get
		{
			return default(float);
		}
	}

	public float zoom
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float minZoom
	{
		get
		{
			return default(float);
		}
	}

	public float maxZoom
	{
		get
		{
			return default(float);
		}
	}

	public float zoomAmount
	{
		get
		{
			return default(float);
		}
	}

	public int PlayerMinimapLevel
	{
		get
		{
			return default(int);
		}
	}

	public string sceneName
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

	public string currentTime
	{
		get
		{
			return null;
		}
	}

	public string currentWeather
	{
		get
		{
			return null;
		}
	}

	private void LoadBlipDisplay()
	{
	}

	private void SaveBlipDisplay()
	{
	}

	public void SetBlipDisplay(EBlipType inBlipType, bool inEnabled)
	{
	}

	public bool GetBlipDisplay(EBlipType inBlipType)
	{
		return default(bool);
	}

	public bool ShouldBlipDisplay(EBlipType inBlipType)
	{
		return default(bool);
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnLevelLoaded(Message inMessage)
	{
	}

	private void OnLoadingStarted(Message inMessage)
	{
	}

	private void OnLoadingFinished(Message inMessage)
	{
	}

	private void OnHideHUDCommand(HideHUDCommand inCommand)
	{
	}

	public void LoadMinimapViaBundlePath(string inBundleIdDefId, bool inCloseMinimapWindow = true)
	{
	}

	public void GetMinimapBlipData(MinimapBlip inMinimapBlip, Action<MinimapBlipData> Callback)
	{
	}

	[IteratorStateMachine(typeof(<GetMinimapBlipDataRoutine>d__121))]
	private IEnumerator GetMinimapBlipDataRoutine(MinimapBlip inMinimapBlip, Action<MinimapBlipData> Callback)
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private void ClearNulls(bool inExpandedMap)
	{
	}

	public void UpdateElements(RectTransform inMapContainer, ERotationType inRotationType, Transform inPlayerTransform)
	{
	}

	private int SortPriority(BlipPriorityParent inTA, BlipPriorityParent inTB)
	{
		return default(int);
	}

	private void SortPriority(bool inExpandedMap)
	{
	}

	private void UpdateIndicator(MinimapBlip inBlip)
	{
	}

	private void UpdateBlip(RectTransform inMapContainer, ERotationType inRotationType, MinimapBlip inBlip, Vector3 inPlayerPosition, Transform inPlayer)
	{
	}

	public int GetBlipMinimapLevel(MinimapBlip inBlip)
	{
		return default(int);
	}

	public int GetPlayerMinimapLevel(Vector3 inPlayerPosition)
	{
		return default(int);
	}

	private int GetMapIndex(float inBlipY)
	{
		return default(int);
	}

	public string GetRoomName()
	{
		return null;
	}

	private Quaternion GetEdgeOfMapRotation(Vector3 inPosition)
	{
		return default(Quaternion);
	}

	public void UpdateMinimap(RectTransform inMapPanel, RectTransform inMapContainer, RectTransform inMapRotator, Transform inMapNorth, Transform inRotationReference, ERotationType inRotationType, Transform inPlayerTransform)
	{
	}

	public Transform GetPlayerTransform()
	{
		return null;
	}

	public Transform GetRotationReference()
	{
		return null;
	}

	public static Vector3 MinimapRotationOffset(Transform inTransform, Vector3 inPosition)
	{
		return default(Vector3);
	}

	public static Vector3 KeepInRectBounds(RectTransform inRect, Vector3 inPosition, out bool outOfBounds)
	{
		return default(Vector3);
	}

	public static Vector3 GetPositionOffset(Transform inTransform, Transform inOtherTransform)
	{
		return default(Vector3);
	}

	public static Vector3 GetPositionOffset(Vector3 inPosition, Vector3 inOtherPosition)
	{
		return default(Vector3);
	}

	public static bool IsVisibleOnScreen(Vector3 inScreenPosition)
	{
		return default(bool);
	}

	public static float GetDistance(Vector3 inBlipPosition, Vector3 inPlayerPosition)
	{
		return default(float);
	}

	public static float GetBlipRadius(RectTransform inRectTransform)
	{
		return default(float);
	}

	public void ZoomIn()
	{
	}

	public void ZoomOut()
	{
	}

	public void ExpandMinimap()
	{
	}

	private void ClampZoom()
	{
	}

	[IteratorStateMachine(typeof(<Initializer>d__155))]
	private IEnumerator Initializer()
	{
		return null;
	}

	private void Initialize(MinimapBlip inMinimapBlip)
	{
	}

	public void Add(MinimapBlip inMinimapBlip)
	{
	}

	public void Remove(MinimapBlip inMinimapBlip)
	{
	}

	private void SpawnBlipUI(MinimapBlip inBlip)
	{
	}

	private void SpawnBlipIndicator(MinimapBlip inBlip)
	{
	}

	private void OnMinimapOpened(WindowOpenedMessage inMessage)
	{
	}

	private void SpawnUIBlips()
	{
	}

	private void OnMinimapClosed(WindowClosedMessage inMessage)
	{
	}

	private void OnExpandedMinimapOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnExpandedMinimapClosed(WindowClosedMessage inMessage)
	{
	}

	private void RefreshBlipParents()
	{
	}

	private void AddBlipToPriorityGroup(MinimapBlip inBlip)
	{
	}
}
