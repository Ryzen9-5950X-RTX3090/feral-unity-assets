using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class ScreenShotHandler : MonoBehaviour
{
	private Texture2D _savedScreenShot;

	private bool _isHidingUI;

	private bool takeScreenShot;

	private Vector2Int dimensions;

	private Action<Texture2D> _callback;

	public Vector2Int debugDimensions;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	[IteratorStateMachine(typeof(<DoScreenShotRoutine>d__7))]
	private IEnumerator DoScreenShotRoutine()
	{
		return null;
	}

	private string GetDefaultFolder()
	{
		return null;
	}

	private string GetScreenShotFileName()
	{
		return null;
	}

	private void HandleScreenCapture()
	{
	}

	private void ClearSavedScreenShot()
	{
	}

	public void TakeScreenShot(int width, int height, bool isHidingUI, [Optional] Action<Texture2D> inCallback)
	{
	}

	public void SaveScreenShot(string inPath)
	{
	}

	public void SaveScreenShotMobile()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugTakeScreenShot_WithDimensions()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugTakeScreenShot_FullScreen()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void DebugSaveScreenShot()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void ApplicationScreenShot()
	{
	}
}
