using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class LazyLayoutElement
{
	public RectTransform rectTransform;

	public LazyLayoutInfo layoutInfo;

	public int siblingIndex;

	public bool allowAnimation;

	public bool snapNextPos;

	public bool snapNextSize;

	private Vector2 _currentPos;

	public Vector2 targetPos;

	private Vector2 _animatedCurrentPos;

	private Vector2 _currentSize;

	public Vector2 targetSize;

	private Vector2 _animatedCurrentSize;

	private Tweener _posTween;

	private Tweener _sizeTween;

	public bool isActive;

	public bool isVisible;

	public Vector2 CurrentPos
	{
		get
		{
			return default(Vector2);
		}
	}

	public Vector2 CurrentSize
	{
		get
		{
			return default(Vector2);
		}
	}

	public LazyLayoutElement()
	{
	}

	public LazyLayoutElement(RectTransform inTransform)
	{
	}

	public virtual void UpdateElement()
	{
	}

	private void OnTweenUpdate()
	{
	}

	public void SetActive(bool inActive)
	{
	}

	public void SetTransform(Transform inTransform)
	{
	}

	public void SetTransform(RectTransform inTransform)
	{
	}

	public float GetPreferredSize(int inAxis)
	{
		return default(float);
	}
}
