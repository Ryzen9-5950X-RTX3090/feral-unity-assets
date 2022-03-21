using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class DOTweenAnimator : MonoBehaviour
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
		MoveAnchoredPosition,
		SizeDelta,
		TextureOffset,
		Color_Manual
	}

	public enum ColorTarget
	{
		None,
		NGUI,
		Mesh,
		UnitySprite,
		UnityImage,
		UnityText,
		CanvasGroup
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

	[Tooltip("used to group tweens together so you can play them by ID")]
	public string ID;

	public bool relative;

	[Tooltip("if this tween is part of an open/close group for a window, you probably want this false")]
	public bool autokill;

	public bool from;

	public bool giveStartValue;

	public bool setToStartValueOnCreate;

	public Vector3 vec3Value;

	public Vector3 vec3ValueStart;

	public Transform moveToTarget;

	public float floatValue;

	public float floatValueStart;

	public Color colorValue;

	public Color colorValueStart;

	public ColorTarget fadeTarget;

	public ColorTarget colorTarget;

	public bool extraUseSharedMaterial;

	public string extraPropertyName;

	public bool snapping;

	public RotateMode rotateMode;

	public bool local;

	public UnityEvent OnPlayCallback;

	public UnityEvent OnStartCallback;

	public UnityEvent OnUpdateCallback;

	public UnityEvent OnCompleteCallback;

	public UnityEvent OnStepCallback;

	private Tweener _tweener;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayTweenForward()
	{
	}

	public void PlayTweenBackward()
	{
	}

	public void StopTween(bool inRewind)
	{
	}

	public void PlayTween(bool inReversed = false, bool inRestart = true)
	{
	}

	[ContextMenu("Create Tween")]
	public void CreateTween()
	{
	}

	private Tweener CreateMoveTween(bool inLocal)
	{
		return null;
	}

	private Tweener CreateMoveToTargetTween()
	{
		return null;
	}

	private Tweener CreateMoveAnchoredPositionTween()
	{
		return null;
	}

	private Tweener CreateSizeDeltaTween()
	{
		return null;
	}

	private Tweener CreateScaleTween()
	{
		return null;
	}

	private Tweener CreateRotateTween(bool inLocal)
	{
		return null;
	}

	private Tweener CreateAlphaTween(bool inUseSharedMaterial, [Optional] string inCustomPropertyName)
	{
		return null;
	}

	private Tweener CreateColorTween(bool inUseSharedMaterial, [Optional] string inCustomPropertyName)
	{
		return null;
	}

	private Tweener CreateTextureOffsetTween(bool inUseSharedMaterial)
	{
		return null;
	}

	private T ApplyTweenSettings<T>(T inTarget) where T : Tweener
	{
		return null;
	}
}
