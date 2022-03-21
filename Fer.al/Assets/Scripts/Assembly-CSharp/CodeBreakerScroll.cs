using System.Collections.Generic;
using UnityEngine;

public class CodeBreakerScroll : MonoBehaviour
{
	public Collider scrollCollider;

	public Camera raycastCamera;

	public float scrollScale;

	public float scrollKnobScale;

	public GameObject notesContainer;

	public List<GameObject> scrollKnobs;

	private Vector3 lastPos;

	private float _minScrollY;

	private float _maxScrollY;

	private float _scrollY;

	private bool _dragging;

	private int _pausedCount;

	private float _playScrollSfxTimer;

	private bool Paused
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage)
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseUp()
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseOver()
	{
	}

	private void UpdateKnobRotation()
	{
	}

	private void OnScrollMoved(float amount)
	{
	}

	public void SetMaxScrollPosition(float inMaxScroll, bool autoScrollToMax = false)
	{
	}

	public void Clear()
	{
	}
}
