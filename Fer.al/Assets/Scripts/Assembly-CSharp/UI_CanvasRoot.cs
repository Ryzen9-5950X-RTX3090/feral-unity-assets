using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

public class UI_CanvasRoot : SingletonManagedBehaviour<UI_CanvasRoot>
{
	private static bool _developerConsoleVisible;

	[SerializeField]
	private Camera _uiCamera;

	[SerializeField]
	private Canvas _windowCanvas;

	[SerializeField]
	private Canvas _overlayCanvas;

	[SerializeField]
	private Canvas _popupCanvas;

	[SerializeField]
	private Canvas _recordingCanvas;

	[SerializeField]
	private GraphicRaycaster _inputBlocker;

	[SerializeField]
	private float _windowDepth;

	[SerializeField]
	private List<UI_Window> _globalWindows;

	[SerializeField]
	private Shader _defaultUIShader;

	[SerializeField]
	private Dictionary<Type, Canvas> _attachCanvasOverrides;

	public Camera UICamera
	{
		get
		{
			return null;
		}
	}

	public Canvas WindowCanvas
	{
		get
		{
			return null;
		}
	}

	public Canvas OverlayCanvas
	{
		get
		{
			return null;
		}
	}

	public Canvas PopupCanvas
	{
		get
		{
			return null;
		}
	}

	public Canvas RecordingCanvas
	{
		get
		{
			return null;
		}
	}

	[DebugButton("Enable Console", "Console", true, true)]
	public static void EnableConsole()
	{
	}

	[DebugButton("Disable Console", "Console", true, true)]
	public static void DisableConsole()
	{
	}

	public override void MAwake()
	{
	}

	public void BlockInput(bool block)
	{
	}

	public Canvas GetCanvas<T>(CoreWindowManager.UILayer inDesiredLayer) where T : UI_Window
	{
		return null;
	}

	public void AttachWindow<T>(UI_Window inWindow) where T : UI_Window
	{
	}

	public void AddAttachWindowOverride(Type inType, Canvas inCanvas)
	{
	}

	public void RemoveAttachWindowOverride(Type inType, Canvas inCanvas)
	{
	}

	public void MoveWindowToFront(UI_Window inWindow)
	{
	}

	public void UpdateDepthPositions()
	{
	}

	public UI_Window GetForwardMostWindow([Optional] UI_Window inWindowToIgnore)
	{
		return null;
	}
}
