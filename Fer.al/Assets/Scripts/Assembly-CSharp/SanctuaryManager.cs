using UnityEngine;

public class SanctuaryManager : SingletonManagerBase<SanctuaryManager>
{
	[RootSelector("Sanctuary Data", "BundleIDChartData", false, false)]
	public string sanctuaryDataPath;

	private static int _sanctuaryLayer;

	[SerializeField]
	private LayerMask _portalRenderMask;

	[SerializeField]
	[Header("Variables")]
	private Color _colorValid;

	[SerializeField]
	private Color _colorInvalid;

	[SerializeField]
	private Color _gridColor;

	[SerializeField]
	private bool _allowOverlappingItems;

	[SerializeField]
	private bool _forceGroundItemsToGround;

	[SerializeField]
	private bool _forceWallItemsToWall;

	[SerializeField]
	private bool _useGridPositioning;

	[SerializeField]
	private bool _enableStaticObjects;

	[SerializeField]
	private bool _showGrid;

	[SerializeField]
	private float _highlightNudge;

	[SerializeField]
	private float _roundTo;

	[SerializeField]
	private int _maxColliders;

	[SerializeField]
	private float _globalRoomFadeOut;

	[SerializeField]
	private float _globalRoomFadeWait;

	[SerializeField]
	private float _globalRoomFadeIn;

	[SerializeField]
	private float _stepHeight;

	public static int sanctuaryLayer
	{
		get
		{
			return default(int);
		}
	}

	public LayerMask portalRenderMask
	{
		get
		{
			return default(LayerMask);
		}
	}

	public bool inSanctuary
	{
		get
		{
			return default(bool);
		}
	}

	public bool inSanctuaryInterior
	{
		get
		{
			return default(bool);
		}
	}

	public bool inSanctuaryExterior
	{
		get
		{
			return default(bool);
		}
	}

	public Color colorValid
	{
		get
		{
			return default(Color);
		}
	}

	public Color colorInvalid
	{
		get
		{
			return default(Color);
		}
	}

	public Color gridColor
	{
		get
		{
			return default(Color);
		}
	}

	public bool allowOverlappingItems
	{
		get
		{
			return default(bool);
		}
	}

	public bool forceGroundItemsToGround
	{
		get
		{
			return default(bool);
		}
	}

	public bool forceWallItemsToWall
	{
		get
		{
			return default(bool);
		}
	}

	public bool useGridPositioning
	{
		get
		{
			return default(bool);
		}
	}

	public bool enableStaticObjects
	{
		get
		{
			return default(bool);
		}
	}

	public bool showGrid
	{
		get
		{
			return default(bool);
		}
	}

	public float highlightNudge
	{
		get
		{
			return default(float);
		}
	}

	public float roundTo
	{
		get
		{
			return default(float);
		}
	}

	public int maxColliders
	{
		get
		{
			return default(int);
		}
	}

	public float globalRoomFadeOut
	{
		get
		{
			return default(float);
		}
	}

	public float globalRoomFadeWait
	{
		get
		{
			return default(float);
		}
	}

	public float globalRoomFadeIn
	{
		get
		{
			return default(float);
		}
	}

	public float stepHeight
	{
		get
		{
			return default(float);
		}
	}

	public bool sanctuaryHasLoaded
	{
		get
		{
			return default(bool);
		}
	}

	public bool mySanctuary
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsWall(Vector3 inNormal)
	{
		return default(bool);
	}

	public bool ShouldTeleport(string inInventoryId, int inGridId, Vector3 inLocalPosition)
	{
		return default(bool);
	}

	public SanctuarySurface GetSanctuarySurface(int inSurfaceIdx)
	{
		return null;
	}
}
