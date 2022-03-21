using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UI_PinchPanel : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[Serializable]
	public class PinchEvent : UnityEvent<float>
	{
	}

	[Serializable]
	public class PinchPosEvent : UnityEvent<float, Vector2>
	{
	}

	[Serializable]
	public class TwoFingerDragEvent : UnityEvent<Vector2, Vector2>
	{
	}

	public PinchEvent OnPinch;

	public PinchPosEvent OnPinchPos;

	public UnityEvent OnPinchStart;

	public UnityEvent OnPinchEnd;

	public TwoFingerDragEvent OnTwoFingerDrag;

	private List<PointerEventData> _activeTouches;

	protected bool _pinchStarted;

	protected bool IsMultitouching
	{
		get
		{
			return default(bool);
		}
	}

	public void OnPointerDown(PointerEventData inEventData)
	{
	}

	public void OnPointerUp(PointerEventData inEventData)
	{
	}

	private bool ActiveTouchesCheck()
	{
		return default(bool);
	}

	public void GetPinchValues(out float pinchDelta, out Vector2 screenPosition)
	{
	}

	public bool GetTwoFingerDragValues(out Vector2 dragDelta, out Vector2 screenPosition)
	{
		return default(bool);
	}

	private void Update()
	{
	}

	private void Pinch(float inPinchDelta, Vector2 inScreenPosition)
	{
	}

	private void TwoFingerDrag(Vector2 inDragDelta, Vector2 inScreenPosition)
	{
	}
}
