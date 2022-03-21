using UnityEngine;

public class TimeClock : ManagedBehaviour
{
	public enum ERotator
	{
		X,
		Y,
		Z
	}

	[SerializeField]
	private Transform _secondHandPivot;

	[SerializeField]
	private Transform _minuteHandPivot;

	[SerializeField]
	private Transform _hourHandPivot;

	[SerializeField]
	private Transform _dayHandPivot;

	[SerializeField]
	private ERotator _secondHandRotator;

	[SerializeField]
	private ERotator _minuteHandRotator;

	[SerializeField]
	private ERotator _hourHandRotator;

	[SerializeField]
	private ERotator _dayHandRotator;

	private Vector3 _initialEulerSecondHand;

	private Vector3 _initialEulerMinuteHand;

	private Vector3 _initialEulerHourHand;

	private Vector3 _initialEulerDayHand;

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	private void SetRotation(Transform inTransform, ERotator inRotator, float inValue, Vector3 inInitialEuler)
	{
	}
}
