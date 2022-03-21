using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class TweenTarget : MonoBehaviour
{
	public enum ColorTarget
	{
		None,
		Mesh,
		UnitySprite,
		UnityImage,
		UnityText,
		CanvasGroup
	}

	[SerializeField]
	private TweenData _tweenData;

	[Tooltip("used to group tweens together so you can play them by ID")]
	public string ID;

	public ColorTarget fadeTarget;

	public ColorTarget colorTarget;

	public Transform moveToTarget;

	public UnityEvent OnPlayCallback;

	public UnityEvent OnStartCallback;

	public UnityEvent OnUpdateCallback;

	public UnityEvent OnCompleteCallback;

	public UnityEvent OnStepCallback;

	private Tweener _tweener;

	public Tweener Tweener
	{
		get
		{
			return null;
		}
	}

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

	public void PlayTween(bool inReversed = false)
	{
	}

	[ContextMenu("Create Tween")]
	public void CreateTween()
	{
	}

	private T AddTweenCallbacks<T>(T inTarget) where T : Tweener
	{
		return null;
	}
}
