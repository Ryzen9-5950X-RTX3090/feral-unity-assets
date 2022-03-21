using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_StageSubjectPositioner : UIBehaviour, IScrollHandler, IEventSystemHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	protected Vector2 _centeredPosition;

	[SerializeField]
	protected Vector2 _defaultRotation;

	[SerializeField]
	[Range(0f, 1f)]
	protected float _defaultZoom;

	[SerializeField]
	protected UI_SpinWithMouse _spinWithMouse;

	[SerializeField]
	protected float _panSensitivity;

	[SerializeField]
	protected float _scrollSpeed;

	[SerializeField]
	protected float _pinchSpeed;

	[SerializeField]
	protected Vector2 _offset;

	[SerializeField]
	protected AnimationCurve _panClampCurve;

	private List<PointerEventData> _activeTouches;

	protected Camera _uiCamera;

	private UI_Stage _stage;

	protected float _normalizedZoom;

	private bool _containsPointer;

	protected bool _zoomEnabled;

	protected bool _spinEnabled;

	protected bool _panEnabled;

	protected Vector2 _defaultPos;

	protected bool IsMultitouching
	{
		get
		{
			return default(bool);
		}
	}

	public UI_Stage Stage
	{
		get
		{
			return null;
		}
	}

	public bool ContainsPointer
	{
		get
		{
			return default(bool);
		}
	}

	public void Setup(Camera inUICamera, UI_Stage inStage)
	{
	}

	public void SetZoomEnabled(bool inEnabled)
	{
	}

	public void SetSpinEnabled(bool inEnabled, bool setRotationToDefault = false)
	{
	}

	public void SetPanEnabled(bool inEnabled)
	{
	}

	public void SetCentered(bool inCentered)
	{
	}

	public void OnScroll(PointerEventData eventData)
	{
	}

	public void OnInitializePotentialDrag(PointerEventData inEventData)
	{
	}

	public void OnBeginDrag(PointerEventData inEventData)
	{
	}

	public void OnDrag(PointerEventData inEventData)
	{
	}

	public void OnEndDrag(PointerEventData inEventData)
	{
	}

	private void OnPinch(float inPinchDelta)
	{
	}

	private void OnTwoFingerDrag(Vector2 inDragDelta)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public Vector2 GetComposerCoordinates()
	{
		return default(Vector2);
	}

	private void Update()
	{
	}

	private void UpdateVirtualCamera()
	{
	}
}
