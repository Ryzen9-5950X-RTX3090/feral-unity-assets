using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class UI_CharmSlotCallout : MonoBehaviour
{
	[SerializeField]
	private RectTransform _boundingRect;

	[SerializeField]
	private UICalloutTail _calloutTail;

	[SerializeField]
	private WWImage _charmSlotA;

	[SerializeField]
	private WWImage _charmSlotB;

	[SerializeField]
	private Transform _target;

	[SerializeField]
	private float _moveSpeed;

	private Camera _uiCamera;

	private Vector2 _targetDirection;

	private Vector2 _smoothedDirection;

	public Transform Target
	{
		get
		{
			return null;
		}
	}

	public void SetTarget(Transform inTarget, Camera inTargetCamera)
	{
	}

	public void SetTargetDirection(Vector2 inTargetDirection)
	{
	}

	private void Update()
	{
	}
}
