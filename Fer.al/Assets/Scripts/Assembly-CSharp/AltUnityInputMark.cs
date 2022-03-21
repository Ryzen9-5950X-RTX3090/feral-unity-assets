using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AltUnityInputMark : UnityEngine.MonoBehaviour
{
	public CanvasGroup CanvasGroup;

	public AnimationCurve VisibilityCurve;

	private Transform _transform;

	private Action<AltUnityInputMark> _onFinished;

	private float _time;

	private float _currentTime;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Transform Transform
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Init(float time, Action<AltUnityInputMark> onFinished)
	{
	}

	public void Show(Vector2 pos)
	{
	}

	private void Update()
	{
	}

	private void Finish()
	{
	}
}
