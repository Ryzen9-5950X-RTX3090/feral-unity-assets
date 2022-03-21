using System.Collections.Generic;
using UnityEngine;

public class UI_TooltipController : SingletonManagedBehaviour<UI_TooltipController>
{
	public enum Side
	{
		Top = 0,
		Bottom = 5,
		Left = 10,
		Right = 15
	}

	[SerializeField]
	private RectTransform _tooltipBounds;

	[SerializeField]
	private float _baseOffset;

	private RectTransform _recordingCanvas;

	private UI_TooltipBody _tooltipBody;

	private List<UI_Tooltip> _targetCandidates;

	private UI_Tooltip _currentTarget;

	private bool _isOnRecordingLayer;

	private Vector3[] _targetWorldCorners;

	private Vector3[] _bodyWorldCorners;

	private Vector3[] _boundsWorldCorners;

	public override void MStart()
	{
	}

	private void Init()
	{
	}

	public void AddTooltipTarget(UI_Tooltip inTarget)
	{
	}

	public void RemoveTooltipTarget(UI_Tooltip inTarget)
	{
	}

	public void NotifyTooltipTextChanged(UI_Tooltip inTarget)
	{
	}

	public override void MUpdate()
	{
	}

	private void ClampPosition()
	{
	}

	private Vector3 InverseTransformPoint(Vector3 worldPoint)
	{
		return default(Vector3);
	}

	private void RefreshCurrentTarget()
	{
	}

	private bool RefreshTargetUILayer()
	{
		return default(bool);
	}
}
