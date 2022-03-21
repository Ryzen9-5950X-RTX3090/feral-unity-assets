using UnityEngine;
using UnityEngine.EventSystems;

public class UI_SpinWithMouse : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public PointerEventData.InputButton inputButton;

	public Transform target;

	public float rotationSpeed;

	[SerializeField]
	private bool _useX;

	[SerializeField]
	private bool _useY;

	[Range(0f, 1f)]
	public float decelerationRate;

	[SerializeField]
	[Tooltip("if a raycast done on this layer succeeds then don't spin")]
	private LayerMask _deferCheckRaycastLayerMask;

	private Vector2 _velocity;

	private bool _isDragging;

	private int _lastDraggedFrame;

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

	public void SetRotation(Vector2 inRotation, float inDuration = 0f)
	{
	}

	private void Update()
	{
	}

	private void UpdateRotation()
	{
	}

	private void ApplyDeceleration()
	{
	}
}
