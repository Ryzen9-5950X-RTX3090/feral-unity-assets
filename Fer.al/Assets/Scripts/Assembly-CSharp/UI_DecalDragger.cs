using UnityEngine;
using UnityEngine.EventSystems;

public class UI_DecalDragger : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private RectTransform _boundingRect;

	[SerializeField]
	private UI_LazyListItemDetailPanel_DecalEntry _decalDetailPanel;

	private bool _isShowing;

	private PointerEventData _dragPointer;

	private bool _isDragging;

	private Vector2 _targetPosition;

	private Vector2 _offset;

	public bool IsShowing
	{
		get
		{
			return default(bool);
		}
	}

	public void Show(Vector2 inScreenPos)
	{
	}

	public void Show(bool inShow)
	{
	}

	public Vector2? GetScreenPoint()
	{
		return null;
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

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private Vector2 ClampPosition(Vector2 inPositionToClamp)
	{
		return default(Vector2);
	}

	private void Update()
	{
	}
}
