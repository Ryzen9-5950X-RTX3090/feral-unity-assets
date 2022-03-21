using UnityEngine;

public class UI_ScreenSpaceTransform : ManagedBehaviour
{
	public enum VisibilityState
	{
		Off,
		HiddenFromDistance,
		HiddenFromDirection,
		HiddenFromGeometry,
		Visible
	}

	[SerializeField]
	protected AnimationCurve _alphaByDistance;

	[SerializeField]
	protected AnimationCurve _scaleByDistance;

	[SerializeField]
	protected bool _showAlways;

	[SerializeField]
	protected bool _ignoreCollision;

	private VisibilityState _currentVisibilityState;

	private float _destAlpha;

	private float _destAlphaSpeed;

	private Camera _targetCamera;

	private Transform _targetTransform;

	[SerializeField]
	private Vector3 _worldOffset;

	[SerializeField]
	private Vector2 _anchoredPositionOffset;

	private RectTransform _rectTransform;

	private UI_ScreenSpaceTransformCanvas _parentCanvas;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	protected float _lastDistance;

	private RaycastHit[] _visibilityHitsNoAlloc;

	public bool ShowAlways
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool IgnoreCollision
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public VisibilityState CurrentVisibilityState
	{
		get
		{
			return default(VisibilityState);
		}
		set
		{
		}
	}

	public float DestAlpha
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float DestAlphaSpeed
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public Camera TargetCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform TargetTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 WorldOffset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public RectTransform RectTransform
	{
		get
		{
			return null;
		}
	}

	public UI_ScreenSpaceTransformCanvas ParentCanvas
	{
		get
		{
			return null;
		}
	}

	public CanvasGroup CanvasGroup
	{
		get
		{
			return null;
		}
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	protected virtual void UpdateVisibilityAndAlpha()
	{
	}

	protected virtual void OnDistanceFromCameraChanged(float inDistance)
	{
	}

	protected Transform RaycastToCameraHitSomething()
	{
		return null;
	}

	private void UpdatePosition()
	{
	}

	public virtual void SSTUpdate()
	{
	}
}
