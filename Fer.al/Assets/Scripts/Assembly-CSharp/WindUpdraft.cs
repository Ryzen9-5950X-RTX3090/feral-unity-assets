using UnityEngine;

[ExecuteAlways]
public class WindUpdraft : ManagedBehaviour
{
	[SerializeField]
	[Range(0.1f, 10f)]
	private float _heightScale;

	[SerializeField]
	[Range(0.1f, 5f)]
	private float _radiusScale;

	[SerializeField]
	[Range(0.5f, 3f)]
	private float _speedScale;

	[SerializeField]
	private GameObject _topPoint;

	[SerializeField]
	private GameObject _bottomPoint;

	[SerializeField]
	private GameObject _updraftEnterExitAudioTrigger;

	protected ParticleSystem _particleSystem;

	protected BoxCollider _boxCollider;

	private bool _isLocalPlayerOnUpdraftRune;

	private bool _isUpdraftEnabled;

	private float _velocity;

	private float _previousHeightScale;

	private float _previousRadiusScale;

	private float _previousSpeedScale;

	private float _updraftDistance;

	private Vector3 _forceDirectionNormalized;

	public const float _heightScaleLowerBound = 0.1f;

	public const float _heightScaleUppderBound = 10f;

	public const float _radiusScaleLowerBound = 0.1f;

	public const float _radiusScaleUppderBound = 5f;

	public const float _speedScaleLowerBound = 0.5f;

	public const float _speedScaleUpperBound = 3f;

	protected virtual bool isUpdraftEnabled
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	private Avatar_Local Avatar
	{
		get
		{
			return null;
		}
	}

	public float HeightScale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float RadiusScale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float SpeedScale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public Vector3 ForceDirectionNormalized
	{
		get
		{
			return default(Vector3);
		}
	}

	public override void MStart()
	{
	}

	internal void ForceOnTriggerEnterCheck(Collider other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	protected virtual void TriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Update()
	{
	}

	protected virtual void EnterUpdraftRune()
	{
	}

	protected virtual void ExitUpdraftRune()
	{
	}

	private void EnterUpdraft()
	{
	}

	private void ExitUpdraft()
	{
	}

	private void CheckForPropertyChange()
	{
	}

	private void OnPropertyChanged()
	{
	}

	public override void MOnDestroy()
	{
	}
}
