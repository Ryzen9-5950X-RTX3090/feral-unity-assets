using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class Avatar_AutoMovement : MonoBehaviour
{
	private Avatar_Local Avatar
	{
		get
		{
			return null;
		}
	}

	public bool IsMoving
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool GetIsMoving()
	{
		return default(bool);
	}

	public void SetCameraRotationOverride(Vector2 rotationOverride)
	{
	}

	public void DisableCameraRotationOverride()
	{
	}

	public void CameraStartLookAt(Vector3 point)
	{
	}

	public void CameraStopLookAt()
	{
	}

	[IteratorStateMachine(typeof(<MovePlayerThroughPoints>d__11))]
	public IEnumerator MovePlayerThroughPoints(List<Vector3> points, [Optional] AvatarAutoMovementOptions movementOptions, [Optional] Action finishedCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MovePlayerThroughPoints>d__12))]
	public IEnumerator MovePlayerThroughPoints(List<ValueTuple<Vector3, AvatarAutoMovementOptions>> targets, [Optional] Action finishedCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MovePlayerThroughPoints>d__13))]
	public IEnumerator MovePlayerThroughPoints(List<ValueTuple<Vector3, AvatarAutoMovementOptions, Action>> targets, [Optional] Action finalFinishedCallback)
	{
		return null;
	}

	public void MoveToPoint(Vector3 point)
	{
	}

	public void MoveToPoint(Vector3 point, AvatarAutoMovementOptions movementOptions)
	{
	}

	public void MoveToPoint(Vector3 point, Action finishedCallback)
	{
	}

	public void MoveToPoint(Vector3 point, AvatarAutoMovementOptions movementOptions, Action finishedCallback)
	{
	}

	[IteratorStateMachine(typeof(<MoveToPointCoroutine>d__18))]
	private IEnumerator MoveToPointCoroutine(Vector3 point, AvatarAutoMovementOptions movementOptions, Action finishedCallback)
	{
		return null;
	}

	private bool IsStalled(Vector3? previousPlayerStartPoint, Vector3 playerStartPoint, List<float> rollingAverageDistanceTraveled)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<WalkAround>d__20))]
	private IEnumerator WalkAround(float speedPercent)
	{
		return null;
	}
}
