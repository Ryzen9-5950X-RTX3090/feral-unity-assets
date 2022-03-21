using UnityEngine;

public class FadeFXWithDistance : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _fx;

	[SerializeField]
	private Vector2 _distanceRange;

	[SerializeField]
	private float _heightOffset;

	[SerializeField]
	private bool _opaqueWhenClose;

	[SerializeField]
	private bool _opaqueWhenFar;

	[SerializeField]
	private Collider _stickToCollider;

	[SerializeField]
	private int _rotateSpeed;

	private float _distanceFromPlayer;

	private float _distanceRatio;

	private Color _startingColor;

	private float _difference;

	private float _previousClampedDistance;

	private Vector3 _closestPoint;

	private Quaternion _destinationRotation;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
