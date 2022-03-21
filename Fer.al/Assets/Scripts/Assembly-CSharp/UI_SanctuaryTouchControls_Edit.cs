using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_SanctuaryTouchControls_Edit : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IInitializePotentialDragHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
	private enum ObjectDragMode
	{
		Position = 0,
		Rotation = 5
	}

	[SerializeField]
	private float _zoomSensitivity;

	[SerializeField]
	private float _panSensitivity;

	[SerializeField]
	private float _objectRotateSensitivity;

	private List<PointerEventData> _pointers;

	private Vector2 _dragOffset;

	private ObjectDragMode _objectDragMode;

	private SanctuaryController Controller
	{
		get
		{
			return null;
		}
	}

	private bool IsMultiTouching
	{
		get
		{
			return default(bool);
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	private void SetDragOffset(PointerEventData inEventData)
	{
	}

	private void SetDragOffset(Vector2 inScreenPosition)
	{
	}
}
