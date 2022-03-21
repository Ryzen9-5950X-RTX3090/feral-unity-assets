using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MultipleObjectTween : ManagedBehaviour
{
	[Serializable]
	public class TweenInfo
	{
		public string gameObjectName;

		[Header("Position")]
		public bool randomizePosition;

		public Vector3 minRndPosition;

		public Vector3 maxRndPosition;

		[Range(0.1f, 100f)]
		public float minPositionTimer;

		[Range(0.1f, 100f)]
		public float maxPositionTimer;

		[Header("Rotation")]
		public bool randomizeRotation;

		public Vector3 minRndRotation;

		public Vector3 maxRndRotation;

		[Range(0.1f, 100f)]
		public float minRotationTimer;

		[Range(0.1f, 100f)]
		public float maxRotationTimer;

		[Header("Scale")]
		public bool randomizeScale;

		public Vector3 minRndScale;

		public Vector3 maxRndScale;

		[Range(0.1f, 100f)]
		public float minScaleTimer;

		[Range(0.1f, 100f)]
		public float maxScaleTimer;

		[NonSerialized]
		[HideInInspector]
		public List<Transform> foundTransforms;

		public FeralAudioInfo audioMove;

		public FeralAudioInfo audioLoop;

		[NonSerialized]
		[HideInInspector]
		public bool audioLoopTriggered;
	}

	[Serializable]
	public class TransformInfo
	{
		public Vector3 initialPosition;

		public Transform transform;
	}

	[Header("Tweens")]
	public TweenInfo[] tweenInfos;

	[SerializeField]
	[Header("Random Delay")]
	private float _minRndDelay;

	[SerializeField]
	private float _maxRndDelay;

	[SerializeField]
	[Header("Init")]
	private bool _initAfterFirstScaleChange;

	private Vector3 _originalScale;

	private List<TransformInfo> _transformInfos;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<ScaleChange>d__9))]
	private IEnumerator ScaleChange()
	{
		return null;
	}

	private void TweenAfterScale()
	{
	}

	private void SetTweens()
	{
	}

	[IteratorStateMachine(typeof(<TweenObjectPosition>d__12))]
	private IEnumerator TweenObjectPosition(Transform inTransform, TweenInfo inTweenInfo)
	{
		return null;
	}

	private void PlayMoveAudio(TweenInfo inTweenInfo)
	{
	}

	private void PlayLoopAudio(TweenInfo inTweenInfo)
	{
	}

	[IteratorStateMachine(typeof(<TweenObjectRotation>d__15))]
	private IEnumerator TweenObjectRotation(Transform inTransform, TweenInfo inTweenInfo)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TweenObjectScale>d__16))]
	private IEnumerator TweenObjectScale(Transform inTransform, TweenInfo inTweenInfo)
	{
		return null;
	}
}
