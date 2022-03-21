using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FakeLight : ManagedBehaviour
{
	private static List<FakeLight> activeInScene;

	[Header("Color")]
	public FakeLightBlendMode blendMode;

	public Color color;

	public Color color2;

	[Header("Shape")]
	public float falloff;

	[Header("Animation")]
	public bool animated;

	public float animationSpeedLow;

	public float animationSpeedHigh;

	public AnimationCurve animationCurve;

	private float _animatedLerp;

	private float _animatedTime;

	private float _animatedSpeed;

	private static QRoutineGroup _fakeLightParentQRoutineGroup;

	private QRoutineGroup _lightQRoutineGroup;

	private static QRoutineGroup FakeLightParentQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	private QRoutineGroup LightQRoutineGroup
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

	private void UpdateAnimation(float inDelta)
	{
	}

	[IteratorStateMachine(typeof(<UpdateAnimationRoutine>d__21))]
	private IEnumerator UpdateAnimationRoutine()
	{
		return null;
	}

	private Color GetFinalColor()
	{
		return default(Color);
	}

	public static void GetColorsForPosition(Vector3 inPos, out Color outMultColor, out Color outAddColor)
	{
	}
}
