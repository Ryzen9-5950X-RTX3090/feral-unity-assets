using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UI_ChatPositionDragger : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IInitializePotentialDragHandler
{
	public enum DragFunction
	{
		Position,
		ResizeUp,
		ResizeDown,
		ResizeLeft,
		ResizeRight,
		ResizeDownRight
	}

	[SerializeField]
	private RectTransform _bodyToDrag;

	[SerializeField]
	private RectTransform _windowRect;

	[SerializeField]
	private DragFunction _dragFunction;

	[SerializeField]
	private Vector2 _minSize;

	[SerializeField]
	private UnityEvent _onClamp;

	[SerializeField]
	private UnityEvent _onSizeChange;

	public int anchorCornerIndex;

	private Vector3 _lastPointerPosition;

	private Vector3[] _bodyWorldCorners;

	private Vector3[] _windowWorldCorners;

	public DragFunction CurrentDragFunction
	{
		get
		{
			return default(DragFunction);
		}
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

	public void ClampPosition(bool inInstant = false)
	{
	}

	private void DoPositionDrag(Vector3 inDelta)
	{
	}

	private void DoSizeDrag(Vector3 inDelta, DragFunction inResizeDirection)
	{
	}
}
