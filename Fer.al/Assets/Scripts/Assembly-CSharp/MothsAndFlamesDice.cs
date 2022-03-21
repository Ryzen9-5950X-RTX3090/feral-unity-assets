using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MothsAndFlamesDice : MonoBehaviour
{
	internal enum EDiceFaceValue
	{
		Moth,
		Flame,
		Other
	}

	private enum EDiceState
	{
		Wait,
		Rise,
		Shake,
		RevealWait,
		Reveal
	}

	public Rigidbody body;

	public float riseTime;

	public float riseHeight;

	public float diceShakeRotateSpeed;

	public float diceShakeRotateSpeedRnd;

	public float dropTime;

	public float dropTimeVariance;

	public float initialPositionRandomnes;

	public float revealMoveTime;

	public GameObject diceGlowBlueFX;

	public GameObject diceGlowOrangeFX;

	public GameObject diceSnuffsOutFX;

	public GameObject diceTrailFX;

	public GameObject diceHitFX;

	[Tooltip("Entry 0 is replaced by this transform.")]
	public Transform[] sideLocators;

	internal int diceNumberValue;

	internal int desiredNumberValue;

	internal int diceIndex;

	internal Vector3 initialPosition;

	internal Vector3 placedPosition;

	internal static Vector3[] endRotation1;

	internal static Vector3[] endRotation2;

	internal static Vector3[] endRotation3;

	internal static Vector3[] endRotation4;

	internal static Vector3[] endRotation5;

	internal static Vector3[] endRotation6;

	internal EDiceFaceValue diceFaceValue;

	private float _diceShakeRotateSpeed;

	private Vector3 rotateDirO;

	private Vector3 _risePosition;

	private MothsAndFlamesGame _game;

	private MothsAndFlamesDiceManager _diceManager;

	private Coroutine _diceShakeCoroutine;

	private Transform _cupCenter;

	private EDiceState _diceState;

	private EDiceState DiceState
	{
		get
		{
			return default(EDiceState);
		}
		set
		{
		}
	}

	internal void Init(int inIndex)
	{
	}

	internal void Unload()
	{
	}

	internal void SetDiceFaceValue()
	{
	}

	internal static EDiceFaceValue GetFaceValue(int inNumberValue)
	{
		return default(EDiceFaceValue);
	}

	[IteratorStateMachine(typeof(<Rise>d__44))]
	private IEnumerator Rise()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Shake>d__45))]
	private IEnumerator Shake()
	{
		return null;
	}

	internal void PreReveal()
	{
	}

	[IteratorStateMachine(typeof(<Roll>d__47))]
	private IEnumerator Roll()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MoveToReveal>d__48))]
	internal IEnumerator MoveToReveal()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<PhoDrop>d__49))]
	private IEnumerator PhoDrop()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ShowResults>d__50))]
	internal IEnumerator ShowResults(bool inResultsWin, bool inFlamesSelected)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SetOrientationBasedOnFaceValue>d__51))]
	private IEnumerator SetOrientationBasedOnFaceValue(float inTimeToOrient)
	{
		return null;
	}

	internal void Cleanup(bool inActive)
	{
	}

	internal void StartShake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
