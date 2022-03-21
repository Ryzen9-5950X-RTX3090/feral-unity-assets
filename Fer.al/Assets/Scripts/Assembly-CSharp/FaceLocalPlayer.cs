using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FaceLocalPlayer : ManagedBehaviour
{
	private bool _ignoreRange;

	private Transform _headNode;

	private Transform _target;

	[SerializeField]
	[Header("General")]
	private float _bodyFacePlayerRange;

	[SerializeField]
	private float _bodyRotationSpeed;

	[SerializeField]
	private bool _allowBodyPitch;

	[SerializeField]
	private float _bodyPitchDegreeLimit;

	[SerializeField]
	private float _facingAngleLimit;

	[SerializeField]
	private bool _facePlayerCamera;

	[SerializeField]
	[Header("Neck")]
	private string _neckNodeName;

	[SerializeField]
	private float _neckRotationSpeed;

	[SerializeField]
	private bool _allowNeckPitch;

	[SerializeField]
	private float _neckPitchDegreeLimit;

	[SerializeField]
	private float _neckFacingAngleLimit;

	public Transform Target
	{
		set
		{
		}
	}

	internal bool UseHeadOnly
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<WaitForAvatarLocal>d__21))]
	private IEnumerator WaitForAvatarLocal()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForCameraLocal>d__22))]
	private IEnumerator WaitForCameraLocal()
	{
		return null;
	}

	public override void MUpdate()
	{
	}
}
