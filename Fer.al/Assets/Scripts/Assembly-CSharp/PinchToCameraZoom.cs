using System;
using Rewired;
using UnityEngine;

public class PinchToCameraZoom : MonoBehaviour
{
	[SerializeField]
	private UI_PinchPanel _pinchPanel;

	[SerializeField]
	private int _playerId;

	[SerializeField]
	private float _sensitivity;

	private CustomController _controller;

	[NonSerialized]
	private bool initialized;

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	private void OnInputSourceUpdate()
	{
	}
}
