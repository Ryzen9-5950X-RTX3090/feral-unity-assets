using UnityEngine;

public class TouchDrag : MonoBehaviour
{
	public IngredientWheel wheel;

	public Camera raycastCamera;

	public float rotateSpeed;

	public float snapSpeed;

	public float clickTimeThreshold;

	public float clickDragThreshold;

	public float clickCenterRadius;

	private Plane _touchPlane;

	private Rigidbody _connectedBody;

	private Rigidbody _dragBody;

	private Quaternion _startRotation;

	private Quaternion _offsetRotation;

	private bool _holding;

	private float _holdingTimer;

	private Vector3 _initialTouchWorldPos;

	private Vector3 _currentTouchWorldPos;

	private Vector3 _currentTouchPos;

	private float _targetSnapAngle;

	private float _snapAngle;

	private int _pausedCount;

	private bool Paused
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage)
	{
	}

	public bool Touching(out Vector3 projectedPoint, out Vector3 worldPoint)
	{
		return default(bool);
	}

	public void SetSnapAngle(int inBinCount)
	{
	}

	private float GetNearestSnapAngle(float inAngle)
	{
		return default(float);
	}
}
