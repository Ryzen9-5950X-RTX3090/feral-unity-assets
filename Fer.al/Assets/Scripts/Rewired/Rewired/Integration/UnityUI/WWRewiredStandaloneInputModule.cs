using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu("Event/WW Rewired Standalone Input Module")]
	public class WWRewiredStandaloneInputModule : PointerInputModule
	{
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		private int[] playerIds;

		private bool recompiling;

		private bool isTouchSupported;

		[SerializeField]
		[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
		private bool useAllRewiredGamePlayers;

		[SerializeField]
		[Tooltip("Allow the Rewired System Player to control the UI.")]
		private bool useRewiredSystemPlayer;

		[SerializeField]
		[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
		private int[] rewiredPlayerIds;

		[SerializeField]
		[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
		private bool usePlayingPlayersOnly;

		[SerializeField]
		[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
		private bool moveOneElementPerAxisPress;

		private float m_PrevActionTime;

		private MoveDirection m_LastMoveDirection;

		private int m_ConsecutiveMoveCount;

		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		private bool m_HasFocus;

		[SerializeField]
		private string m_HorizontalAxis;

		[SerializeField]
		[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
		private string m_VerticalAxis;

		[SerializeField]
		[Tooltip("Name of the action used to submit.")]
		private string m_SubmitButton;

		[SerializeField]
		[Tooltip("Name of the action used to cancel.")]
		private string m_CancelButton;

		[SerializeField]
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction. (Min)")]
		private float m_InputActionsPerSecond_min;

		[SerializeField]
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction. (Max)")]
		private float m_InputActionsPerSecond_max;

		[SerializeField]
		[Tooltip("input actions per second will increase as actions are repeated")]
		private float m_InputActionsPerSecondPerAction;

		[SerializeField]
		[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
		private float m_RepeatDelay;

		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements.")]
		private bool m_allowMouseInput;

		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
		private bool m_allowMouseInputIfTouchSupported;

		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[Tooltip("Forces the module to always be active.")]
		private bool m_ForceModuleActive;

		public bool UseAllRewiredGamePlayers
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UseRewiredSystemPlayer
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int[] RewiredPlayerIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UsePlayingPlayersOnly
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool MoveOneElementPerAxisPress
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool allowMouseInput
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool allowMouseInputIfTouchSupported
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private bool isMouseSupported
		{
			get
			{
				return default(bool);
			}
		}

		[Obsolete]
		public bool allowActivationOnMobileDevice
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool forceModuleActive
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float inputActionsPerSecondMin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float inputActionsPerSecondMax
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float inputActionsPerSecondPerAction
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float repeatDelay
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public string horizontalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string verticalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string submitButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string cancelButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected WWRewiredStandaloneInputModule()
		{
		}

		protected override void Awake()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		public override void ActivateModule()
		{
		}

		public override void DeactivateModule()
		{
		}

		public override void Process()
		{
		}

		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		protected bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		protected bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		private bool CheckButtonOrKeyMovement(float time)
		{
			return default(bool);
		}

		protected void ProcessMouseEvent()
		{
		}

		protected void ProcessMouseEvent(int id)
		{
		}

		protected bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		protected void ProcessMousePress(MouseButtonEventData data)
		{
		}

		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		private void InitializeRewired()
		{
		}

		private void SetupRewiredVars()
		{
		}

		private void CheckEditorRecompile()
		{
		}

		private void OnEditorRecompile()
		{
		}

		private void ClearRewiredVars()
		{
		}
	}
}
