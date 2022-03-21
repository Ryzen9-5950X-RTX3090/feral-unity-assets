using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScaleWhenLocalPlayerClose : ManagedBehaviour
{
	private Transform _target;

	[SerializeField]
	private FeralAudioInfo _audioScaleUp;

	[SerializeField]
	private FeralAudioInfo _audioScaleDown;

	[SerializeField]
	private FeralAudioInfo _audioScaledUpLoop;

	[SerializeField]
	private FeralAudioInfo _audioScaledDownLoop;

	[SerializeField]
	[Header("Distance")]
	[Tooltip("Distance")]
	private float _distance;

	[SerializeField]
	[Header("Within Distance")]
	[Tooltip("Scale")]
	private float _scaleToWithinDistance;

	[SerializeField]
	[Tooltip("Time")]
	private float _scaleTimeWithinDistance;

	[SerializeField]
	[Header("Outside Distance")]
	[Tooltip("Scale")]
	private float _scaleToOutsideDistance;

	[SerializeField]
	[Tooltip("Time")]
	private float _scaleTimeOutsideDistance;

	private bool? _withinRange;

	public bool? withinRange
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<WaitForAvatarLocal>d__14))]
	private IEnumerator WaitForAvatarLocal()
	{
		return null;
	}

	public override void MUpdate()
	{
	}

	private void Scale(float inScale, float inTimer)
	{
	}
}
