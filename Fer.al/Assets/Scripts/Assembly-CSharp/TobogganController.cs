using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using UniRx.Async;
using UnityEngine;

public class TobogganController : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Init>d__27 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TobogganController <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Header("Physics And Control")]
	public Rigidbody rigidbody;

	public GroundChecker groundChecker;

	public float turnForce;

	public float snowForce;

	public float correctiveTurnForce;

	public float extraSlopeForce;

	[Header("Avatar")]
	public Transform avatarParent;

	private ActorBase spawnedActor;

	[Header("FX")]
	public ParticleSystem snowFx;

	public float emissionMultiplier;

	public float angleBetweenSlopeAndSled;

	public CinemachineVirtualCamera virtualCamera;

	[Header("Reset")]
	[Tooltip("Falling below this speed will initiate the reset")]
	public float resetVelocity;

	[Tooltip("Must go above this to be able to reset")]
	public float minimumVelocity;

	[Tooltip("Half this is spent fading out, and half fading in, with the position reset in between")]
	public float resetTime;

	[Tooltip("The boost appied after a reset to help get the player moving on flatter terrain")]
	public float resetForwardForce;

	public float uprightStuckCheckVal;

	public float uprightStuckSlowVal;

	private bool _achievedMinimumVelocity;

	private float _velocity;

	private Transform[] _resetLocators;

	[Tooltip("Minimum magnitude of collision needed to trigger the hit animation")]
	public float hitAnimMinMagnitude;

	[Tooltip("Magnitude at which the hit animation blend parameter hits its maximum")]
	public float hitAnimMaxMagnitude;

	[Tooltip("Minimum length of time between hit animation triggers")]
	public float hitAnimInterval;

	private float hitAnimTimer;

	private float destinationTurnBlend;

	private float turnVelocity;

	[AsyncStateMachine(typeof(<Init>d__27))]
	internal void Init()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ApplyTurnForce()
	{
	}

	private void ApplySnowForce()
	{
	}

	private void ApplyStraighteningForce()
	{
	}

	private void ApplyExtraSlopeForce()
	{
	}

	private void StuckCheck()
	{
	}

	[IteratorStateMachine(typeof(<ResetToboggan>d__34))]
	private IEnumerator ResetToboggan()
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
