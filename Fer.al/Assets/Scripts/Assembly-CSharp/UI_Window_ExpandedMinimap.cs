using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[ManagedBehaviourManager("MinimapManager")]
public class UI_Window_ExpandedMinimap : UI_Window
{
	[SerializeField]
	private RectTransform _mapPanel;

	[SerializeField]
	private RectTransform _mapContainer;

	[SerializeField]
	private RectTransform _elementContainer;

	[SerializeField]
	private UI_MinimapBlip _blipReference;

	[SerializeField]
	private WWTextMeshProUGUI _labelLevelName;

	[SerializeField]
	private WWTextMeshProUGUI _labelTime;

	private List<GameObject> _imageGameObjects;

	private string _lastRoomDefId;

	private float _scrollVelocity;

	[SerializeField]
	private float _minZoom;

	[SerializeField]
	private float _maxZoom;

	[SerializeField]
	private float _currentZoom;

	[SerializeField]
	private float _zoomSensitivity;

	[SerializeField]
	private float _zoomDeacceleration;

	[SerializeField]
	private float _pinchZoomSensitivity;

	[SerializeField]
	private float _zoomPercentage;

	[SerializeField]
	private Vector2 _zoomModifier;

	[SerializeField]
	private RectTransform _draggableRect;

	[SerializeField]
	private Vector3 _zoomPosition;

	[SerializeField]
	private Vector3 _priorZoomPosition;

	public static UI_Window_ExpandedMinimap instance
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

	public RectTransform elementContainer
	{
		get
		{
			return null;
		}
	}

	public UI_MinimapBlip blipReference
	{
		get
		{
			return null;
		}
	}

	public WWTextMeshProUGUI labelLevelName
	{
		get
		{
			return null;
		}
	}

	public WWTextMeshProUGUI labelTime
	{
		get
		{
			return null;
		}
	}

	private Camera UICamera
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public void BtnClicked_ZoomIn()
	{
	}

	public void BtnClicked_ZoomOut()
	{
	}

	public void BtnClicked_Waypoint()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void InitMinimap()
	{
	}

	private void SetMinimapMap()
	{
	}

	public override void MUpdate()
	{
	}

	public void OnPinchPos(float inPinchDelta, Vector2 inScreenPos)
	{
	}

	private void Zoom(float inZoom, Vector2 inScreenSpaceFocusPoint)
	{
	}

	private void LateUpdate()
	{
	}

	public override void OnReceiveFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}

	public void BtnClicked_OpenQuickTravel()
	{
	}
}
