using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unitilities.Tuples;

public class CoreWindowManager : CoreManagerBase<CoreWindowManager>
{
	public enum UILayer
	{
		Window = 0,
		Overlay = 10,
		Popup = 20,
		Recording = 30
	}

	public enum QueuePriority
	{
		Lowest = 0,
		Low = 5,
		Medium = 10,
		High = 15,
		Highest = 20
	}

	public struct QueuedWindow
	{
		public string windowID;

		public Action<UI_Window> OnWindowOpenedCallback;

		public int priority;

		public bool animate;
	}

	private static Dictionary<Type, string> _typeNames;

	protected Dictionary<string, UI_Window> _windows;

	protected List<Queue<QueuedWindow>> _queuedWindows;

	protected List<UI_Window> _openQueuedWindows;

	protected List<Unitilities.Tuples.Tuple<int, string>> _loadingQueuedWindowIDs;

	protected List<string> _loadingWindows;

	protected UI_Panel _focusedPanel;

	protected List<UI_Panel> _focusStack;

	public IEnumerable<UI_Window> Windows
	{
		get
		{
			return null;
		}
	}

	public Dictionary<string, UI_Window> WindowsDict
	{
		get
		{
			return null;
		}
	}

	private static string GetTypeName(Type inType)
	{
		return null;
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public static T GetWindow<T>() where T : UI_Window
	{
		return null;
	}

	public static UI_Window GetWindow(string inWindowID)
	{
		return null;
	}

	public static T GetWindow<T>(string inWindowID) where T : UI_Window
	{
		return null;
	}

	public static UI_Panel GetFocusedWindow()
	{
		return null;
	}

	public static bool ExistsOrIsLoading(string inWindowID)
	{
		return default(bool);
	}

	public static void OpenWindow(string inWindowID, [Optional] Action<UI_Window> inOnWindowOpenedCallback)
	{
	}

	public static void OpenWindow<T>(string inWindowID, [Optional] Action<T> inOnWindowOpenedCallback, bool inAnimate = true) where T : UI_Window
	{
	}

	public static void OpenWindow<T>([Optional] Action<T> inOnWindowOpenedCallback, bool inAnimate = true) where T : UI_Window
	{
	}

	public static void CloseWindow(string inWindowID, bool inAnimate = true)
	{
	}

	public static void CloseWindow<T>(bool inAnimate = true)
	{
	}

	public static void ShowWindow<T>() where T : UI_Window
	{
	}

	public static void HideWindow<T>() where T : UI_Window
	{
	}

	public static void CloseAllWindows([Optional] UI_Window inExceptionWindow, bool inIgnoreWindowLayer = false, bool inIgnoreOverlayLayer = false, bool inIgnorePopupLayer = false)
	{
	}

	public static void RemoveWindow(UI_Window inWindow)
	{
	}

	public static T ToggleWindow<T>() where T : UI_Window
	{
		return null;
	}

	public static T ToggleWindow<T>(string inWindowID, bool inAnimate = true) where T : UI_Window
	{
		return null;
	}

	public static void QueueWindow(string inWindowID, QueuePriority inPriority = QueuePriority.Low, [Optional] Action<UI_Window> inOnWindowOpenedCallback, bool inAnimate = true)
	{
	}

	public static void QueueWindow<T>(QueuePriority inPriority = QueuePriority.Low, [Optional] Action<UI_Window> inOnWindowOpenedCallback, bool inAnimate = true)
	{
	}

	public static void QueueOkWindow(string inMessage, QueuePriority inPriority = QueuePriority.Low, [Optional] Action inOkCallback, bool inAnimate = true)
	{
	}

	public static void QueueOkWindow(string inTitle, string inMessage, QueuePriority inPriority = QueuePriority.Low, [Optional] Action inOkCallback, bool inAnimate = true)
	{
	}

	public static void QueueOkWindow(string inTitle, string inMessage, string inOkBtnText, QueuePriority inPriority = QueuePriority.Low, [Optional] Action inOkCallback, bool inAnimate = true)
	{
	}

	public static void QueueYesNoWindow(string inTitle, string inMessage, string inYesBtnText, string inNoBtnText, QueuePriority inPriority = QueuePriority.Low, [Optional] Action<bool> inResponseCallback, bool inAnimate = true)
	{
	}

	public static void FocusPanel(UI_Panel inPanelToFocus, bool inReplaceCurrentPanel = false)
	{
	}

	public static void DefocusPanel(UI_Panel inPanelToFocus)
	{
	}

	private static void RemoveWindow(string inWindowID)
	{
	}

	private static void AddWindow(UI_Window inWindow)
	{
	}

	[IteratorStateMachine(typeof(<OpenBundledWindow>d__44<>))]
	private static IEnumerator OpenBundledWindow<T>(string inWindowID, [Optional] Action<T> inOnWindowOpenedCallback, bool inAnimate = true) where T : UI_Window
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadBundledWindow>d__45<>))]
	private static IEnumerator LoadBundledWindow<T>(string inWindowID, [Optional] Action<T> inOnWindowLoadedCallback) where T : UI_Window
	{
		return null;
	}

	private void QueueWindow(QueuedWindow inQueuedWindow)
	{
	}

	private void OpenQueuedWindow(QueuedWindow inQueuedWindow)
	{
	}

	private void OnQueuedWindowClosed(UI_Window inWindow)
	{
	}

	private bool QueuedWindowIsOpen(int inPriority)
	{
		return default(bool);
	}

	private bool QueuedWindowIsLoading(int inPriority)
	{
		return default(bool);
	}

	private void RemoveQueuedWindowFromLoading(string inWindowID)
	{
	}

	private void RefreshFocusedPanel()
	{
	}
}
