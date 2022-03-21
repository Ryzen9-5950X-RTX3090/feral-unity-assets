using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SanctuaryLayoutData : ScriptableObject
{
	[Serializable]
	public class BaseMaterialInfo
	{
		public Material blackMaterial;

		public Material fadeMaterial;

		public Material borderMaterial;

		public Material editLineMaterial;
	}

	[Serializable]
	public class RoomScaleInfo
	{
		public Vector3 decorateSize
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 islandSize
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 houseSize
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 greenhouseDecorateSize
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 greenhouseIslandSize
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 greenhouseSize
		{
			get
			{
				return default(Vector3);
			}
		}
	}

	[Serializable]
	public class SkyboxInfo
	{
		public GameObject skybox;

		public Vector3 offset;

		public float scale;
	}

	[Serializable]
	public class InteriorInfo
	{
		public GameObject[] rooms;

		public GameObject[] roomsUpgraded;

		public SkyboxInfo skybox;
	}

	[Serializable]
	public class ExteriorInfo
	{
		public SkyboxInfo skybox;
	}

	public enum ERoomType
	{
		NOTUSED,
		BASIC,
		ENTRY
	}

	[Serializable]
	public class Floor
	{
		public List<RoomX> roomsX;
	}

	[Serializable]
	public class RoomX
	{
		public List<RoomZ> roomsZ;
	}

	[Serializable]
	public class RoomZ
	{
		public RoomData roomData;
	}

	[Serializable]
	public class RoomData
	{
		public ERoomType roomType;

		public int stageOpen;

		public int roomPrefabIdx;
	}

	private int _safeBeginningGridIndexMultiplier;

	private int _worldSpacing;

	[RootSelector("Sanctuary Flooring", "CraftableItemChartData", false, false)]
	public string defaultFlooring;

	[RootSelector("Sanctuary Wallpaper", "CraftableItemChartData", false, false)]
	public string defaultWallpaper;

	[RootSelector("Sanctuary Trim", "CraftableItemChartData", false, false)]
	public string defaultTrim;

	[RootSelector("Sanctuary Ceiling", "CraftableItemChartData", false, false)]
	public string defaultCeiling;

	[NonSerialized]
	public Material defaultFlooringMat;

	[NonSerialized]
	public Material defaultWallpaperMat;

	[NonSerialized]
	public Material defaultTrimMat;

	[NonSerialized]
	public Material defaultCeilingMat;

	[SerializeField]
	[Header("Audio")]
	private FeralAudioInfo[] _interiorAudio;

	[SerializeField]
	private FeralAudioInfo[] _exteriorAudio;

	[SerializeField]
	private FeralAudioInfo _audioSelectObject;

	[SerializeField]
	private FeralAudioInfo _audioRotateItem;

	[SerializeField]
	private FeralAudioInfo _audioDoorOpen;

	[SerializeField]
	private FeralAudioInfo _audioDoorClose;

	[Header("Base Materials")]
	public BaseMaterialInfo baseMaterialInfo;

	public RoomScaleInfo roomScaleInfo;

	[Header("Interior")]
	public InteriorInfo interiorInfo;

	[Header("Exterior")]
	public ExteriorInfo exteriorInfo;

	[Header("Floors")]
	public List<Floor> floors;

	[SerializeField]
	[Header("Edit")]
	private GameObject _editHighlightPrefab;

	[SerializeField]
	[Header("Lights")]
	private GameObject _indoorLightsPrefab;

	[SerializeField]
	private GameObject _exteriorLightsPrefab;

	[SerializeField]
	[Header("Portal")]
	private GameObject _portal;

	[SerializeField]
	[Header("Colors")]
	private Color _colorDay;

	[SerializeField]
	private Color _colorNight;

	[SerializeField]
	[Header("Raycasting")]
	private float _rayDistance;

	[SerializeField]
	[Header("Expansions")]
	private int _maxExpansions;

	public int safeBeginningGridIndexMultiplier
	{
		get
		{
			return default(int);
		}
	}

	public int worldSpacing
	{
		get
		{
			return default(int);
		}
	}

	public FeralAudioInfo[] interiorAudio
	{
		get
		{
			return null;
		}
	}

	public FeralAudioInfo[] exteriorAudio
	{
		get
		{
			return null;
		}
	}

	public FeralAudioInfo audioSelectObject
	{
		get
		{
			return null;
		}
	}

	public FeralAudioInfo audioRotateItem
	{
		get
		{
			return null;
		}
	}

	public FeralAudioInfo audioDoorOpen
	{
		get
		{
			return null;
		}
	}

	public FeralAudioInfo audioDoorClose
	{
		get
		{
			return null;
		}
	}

	public GameObject editHighlightPrefab
	{
		get
		{
			return null;
		}
	}

	public GameObject indoorLightsPrefab
	{
		get
		{
			return null;
		}
	}

	public GameObject exteriorLightsPrefab
	{
		get
		{
			return null;
		}
	}

	public GameObject portal
	{
		get
		{
			return null;
		}
	}

	public Color colorDay
	{
		get
		{
			return default(Color);
		}
	}

	public Color colorNight
	{
		get
		{
			return default(Color);
		}
	}

	public float rayDistance
	{
		get
		{
			return default(float);
		}
	}

	public float maxExpansions
	{
		get
		{
			return default(float);
		}
	}
}
