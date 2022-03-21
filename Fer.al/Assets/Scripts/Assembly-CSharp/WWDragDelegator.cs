using UnityEngine;
using UnityEngine.EventSystems;

public class WWDragDelegator : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler
{
	private class DragTarget : IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
	{
		private IInitializePotentialDragHandler _initializePotentialDragHandler;

		private IBeginDragHandler _beginDragHandler;

		private IEndDragHandler _endDragHandler;

		private IDragHandler _dragHandler;

		private IScrollHandler _scrollHandler;

		public DragTarget(GameObject inSrc)
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

		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public void OnScroll(PointerEventData eventData)
		{
		}
	}

	[SerializeField]
	private GameObject _horizontalDragTargetObject;

	[SerializeField]
	private GameObject _verticalDragTargetObject;

	private DragTarget _horizontalDragTarget;

	private DragTarget _verticalDragTarget;

	private DragTarget _currentDragTarget;

	private void OnEnable()
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

	public void OnScroll(PointerEventData eventData)
	{
	}
}
