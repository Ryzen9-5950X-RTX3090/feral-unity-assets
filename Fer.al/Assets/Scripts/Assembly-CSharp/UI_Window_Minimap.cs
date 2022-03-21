using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;

public class UI_Window_Minimap : UI_Window
{
	[SerializeField]
	private GameObject _groupMapOn;

	[SerializeField]
	private GameObject _groupMapOff;

	[SerializeField]
	private RectTransform _mapPanel;

	[SerializeField]
	private RectTransform _mapContainer;

	[SerializeField]
	private RectTransform _indicatorContainer;

	[SerializeField]
	private RectTransform _mapRotator;

	[SerializeField]
	private RectTransform _mapNorth;

	[SerializeField]
	private RectTransform _elementContainerMasked;

	[SerializeField]
	[RootSelector("Blip References", "BundleIDChartData", false, false)]
	private string _blipId;

	[SerializeField]
	[RootSelector("Indicator References", "BundleIDChartData", false, false)]
	private string _indicatorId;

	[SerializeField]
	private WWTextMeshProUGUI _labelLevelIntro;

	private string _prevLevelName;

	private Vector3 _lastPlayerPosition;

	private List<GameObject> _imageGameObjects;

	[SerializeField]
	private bool _showTime;

	[SerializeField]
	private bool _showWeather;

	[SerializeField]
	private bool _showLocation;

	[SerializeField]
	private bool _showPosition;

	[SerializeField]
	private UI_ColorizedIcon _blipToggleBackground;

	[SerializeField]
	private UI_ColorizedIcon _blipToggleIcon;

	private bool _mapOn;

	private StringBuilder _tempSB;

	public RectTransform mapPanel
	{
		get
		{
			return null;
		}
	}

	public RectTransform mapContainer
	{
		get
		{
			return null;
		}
	}

	public RectTransform indicatorContainer
	{
		get
		{
			return null;
		}
	}

	public RectTransform mapRotator
	{
		get
		{
			return null;
		}
	}

	public RectTransform mapNorth
	{
		get
		{
			return null;
		}
	}

	public RectTransform elementContainerMasked
	{
		get
		{
			return null;
		}
	}

	public UI_MinimapBlip blipReference
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

	public UI_MinimapIndicator indicatorReference
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

	public static bool DelayShowLocation
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

	public static void OpenWindow(bool inMapOn = true)
	{
	}

	public static void CloseWindow()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void ToggleExpandedMinimap()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	public void BtnClicked_ToggleHarvestBlip()
	{
	}

	private void InitLevelNameIntro(string inText)
	{
	}

	private void InitElements()
	{
	}

	private void InitMinimap()
	{
	}

	private void SetMinimapMap()
	{
	}

	public static List<GameObject> SpawnMapImages(Transform inParent, bool inFullscreen = false)
	{
		return null;
	}

	public void BtnClicked_ZoomIn()
	{
	}

	public void BtnClicked_ZoomOut()
	{
	}

	public void BtnClicked_ExpandMinimap()
	{
	}

	public void SetMapOn(bool inOn)
	{
	}

	private void SetBlipToggleIconColor(bool inDisplay)
	{
	}
}
