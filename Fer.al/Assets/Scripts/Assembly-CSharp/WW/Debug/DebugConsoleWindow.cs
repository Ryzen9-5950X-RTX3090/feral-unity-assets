using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WW.Debug
{
	public class DebugConsoleWindow : MonoBehaviour
	{
		public static DebugConsoleWindow instance;

		[SerializeField]
		private float minimumHeight;

		[SerializeField]
		private bool startInPopupMode;

		[SerializeField]
		[Header("Internal References")]
		private RectTransform logWindowTR;

		[SerializeField]
		private CanvasGroup _debugWindowCanvasGroup;

		[SerializeField]
		private CanvasGroup _consoleCanvasGroup;

		[SerializeField]
		private CanvasGroup _commandLineCanvasGroup;

		[SerializeField]
		private CanvasGroup _buttonPanelCanvasGrup;

		[SerializeField]
		private CanvasGroup _customPanelCanvasGroup;

		[SerializeField]
		private DebugLogPopup _debugLogPopup;

		private const string LAST_PANEL_KEY = "Debug_LastPanel";

		private const string LAST_PANEL_CONSOLE = "console";

		private const string LAST_PANEL_CMDLINE = "commandline";

		private const string LAST_PANEL_BUTTON = "button";

		private const string LAST_PANEL_CUSTOM = "custom";

		public Action OnShown;

		public Action OnHidden;

		private RectTransform _canvasTR;

		private bool _sidePanelOpen;

		private bool _isInPopupMode;

		private bool _screenDimensionsChanged;

		public CanvasGroup CommandLineCanvasGroup
		{
			get
			{
				return null;
			}
		}

		public DebugLogPopup DebugLogPopup
		{
			get
			{
				return null;
			}
		}

		public bool IsInPopupMode
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		private void LateUpdate()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void ToggleSidePanel()
		{
		}

		public void ConsoleTabButtonPressed()
		{
		}

		public void CommandLineTabButtonPressed()
		{
		}

		public void ButtonPanelTabButtonPressed()
		{
		}

		public void CustomTabButtonPressed()
		{
		}

		private void EnableTab(CanvasGroup inCanvasGroup, bool inIsEnabled)
		{
		}

		public void HideButtonPressed()
		{
		}

		public void Resize(BaseEventData dat)
		{
		}
	}
}
