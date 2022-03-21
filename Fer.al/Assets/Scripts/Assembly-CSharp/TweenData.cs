using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

[CreateAssetMenu]
public class TweenData : ScriptableObject
{
	public enum AnimationType
	{
		Move,
		Scale,
		Rotate,
		Alpha_Auto,
		Color_Auto,
		MoveToTransform,
		Alpha_Manual,
		MoveAnchoredPosition
	}

	public bool autoPlay;

	public AnimationType animationType;

	public float duration;

	public float delay;

	[Tooltip("Set to INTERNAL_Custom to use animation curve")]
	public Ease easeType;

	public AnimationCurve customEaseCurve;

	[Tooltip("-1 = infinite loops, 0 = no loops")]
	public int loops;

	public LoopType loopType;

	public bool ignoreTimeScale;

	public bool relative;

	[Tooltip("if this tween is part of an open/close group for a window, you probably want this false")]
	public bool autokill;

	public bool from;

	public bool giveStartValue;

	public bool setToStartValueOnCreate;

	public Vector3 vec3Value;

	public Vector3 vec3ValueStart;

	public float floatValue;

	public float floatValueStart;

	public Color colorValue;

	public Color colorValueStart;

	public bool extraUseSharedMaterial;

	public string extraPropertyName;

	public bool snapping;

	public RotateMode rotateMode;

	public bool local;

	public Tweener CreateTween(TweenTarget inTarget)
	{
		return null;
	}

	private Tweener CreateMoveTween(TweenTarget inTarget, bool inLocal)
	{
		return null;
	}

	private Tweener CreateMoveToTargetTween(TweenTarget inTarget)
	{
		return null;
	}

	private Tweener CreateMoveAnchoredPositionTween(TweenTarget inTarget)
	{
		return null;
	}

	private Tweener CreateScaleTween(TweenTarget inTarget)
	{
		return null;
	}

	private Tweener CreateRotateTween(TweenTarget inTarget, bool inLocal)
	{
		return null;
	}

	private Tweener CreateAlphaTween(TweenTarget inTarget, bool inUseSharedMaterial, [Optional] string inCustomPropertyName)
	{
		return null;
	}

	private Tweener CreateColorTween(TweenTarget inTarget)
	{
		return null;
	}

	private T ApplyTweenSettings<T>(TweenTarget inTarget, T inTweener) where T : Tweener
	{
		return null;
	}
}
