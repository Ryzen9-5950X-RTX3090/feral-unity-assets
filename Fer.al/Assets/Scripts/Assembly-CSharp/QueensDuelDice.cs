using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QueensDuelDice : MonoBehaviour
{
	internal enum EDiceFaceValue
	{
		Sword,
		Twiggle,
		Kobold,
		Captain
	}

	public GameObject hoverFX;

	public GameObject sparkFX;

	public Material playerMaterial;

	public Material opponentMaterial;

	public MeshRenderer meshRenderer;

	public Rigidbody body;

	public GameObject selectionIndicator;

	public float riseTime;

	public float riseHeight;

	public float diceShakeRotateSpeed;

	public float diceShakeRotateSpeedRnd;

	public float dropTime;

	public float dropTimeVariance;

	public float initialPositionRandomnes;

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

	internal bool _isLocked;

	private QueensDuelDiceSpot _occupiedSpot;

	internal EDiceFaceValue diceFaceValue;

	private Vector3 _risePosition;

	private bool _playerDice;

	private bool _canSelect;

	private bool _rising;

	private float _diceShakeRotateSpeed;

	private Vector3 rotateDirO;

	private QueensDuelDiceManager _diceManager;

	private QueensDuelGame _game;

	private Vector3? _previousMousePosition;

	internal bool isLocked
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal QueensDuelDiceSpot OccupiedSpot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal void Init(bool inPlayerDice)
	{
	}

	internal void SetDiceFaceValue()
	{
	}

	private void SetDiceGameValue()
	{
	}

	[IteratorStateMachine(typeof(<Rise>d__48))]
	private IEnumerator Rise()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Roll>d__49))]
	private IEnumerator Roll()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<PhoDrop>d__50))]
	private IEnumerator PhoDrop()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SetOrientationBasedOnFaceValue>d__51))]
	private IEnumerator SetOrientationBasedOnFaceValue(float inTimeToOrient)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Shake>d__52))]
	private IEnumerator Shake()
	{
		return null;
	}

	internal void Cleanup(bool inActive)
	{
	}

	internal void StartShake(bool inPlayFX = true)
	{
	}

	internal void ShowSelected(bool inShow)
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseUp()
	{
	}

	[IteratorStateMachine(typeof(<MoveTo>d__59))]
	internal IEnumerator MoveTo(Vector3 inPos, float inSpeedMultiplier = 1f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<AutoRoll>d__60))]
	internal IEnumerator AutoRoll()
	{
		return null;
	}
}
