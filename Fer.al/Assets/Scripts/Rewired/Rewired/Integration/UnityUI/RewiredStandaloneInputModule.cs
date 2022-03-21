using System;
using System.Collections.Generic;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu("Event/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		[Serializable]
		public class PlayerSetting
		{
			public int playerId;

			public List<Rewired.Components.PlayerMouse> playerMice;

			public PlayerSetting()
			{
			}

			private PlayerSetting(PlayerSetting other)
			{
			}

			public PlayerSetting Clone()
			{
				return null;
			}
		}

		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		[SerializeField]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
		private InputManager_Base rewiredInputManager;

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
		[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
		private List<Rewired.Components.PlayerMouse> playerMice;

		[SerializeField]
		[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
		private bool moveOneElementPerAxisPress;

		[SerializeField]
		[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
		private bool setActionsById;

		[SerializeField]
		[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
		private int horizontalActionId;

		[SerializeField]
		[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
		private int verticalActionId;

		[SerializeField]
		[Tooltip("Id of the Action used to submit.")]
		private int submitActionId;

		[SerializeField]
		[Tooltip("Id of the Action used to cancel.")]
		private int cancelActionId;

		[SerializeField]
		[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
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
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
		private float m_InputActionsPerSecond;

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
		[Tooltip("Allows touch input to be used to select elements.")]
		private bool m_allowTouchInput;

		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[Tooltip("Forces the module to always be active.")]
		private bool m_ForceModuleActive;

		[NonSerialized]
		private int[] playerIds;

		private bool recompiling;

		[NonSerialized]
		private bool isTouchSupported;

		[NonSerialized]
		private float m_PrevActionTime;

		[NonSerialized]
		private Vector2 m_LastMoveVector;

		[NonSerialized]
		private int m_ConsecutiveMoveCount;

		[NonSerialized]
		private bool m_HasFocus;

		public InputManager_Base RewiredInputManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public List<Rewired.Components.PlayerMouse> PlayerMice
		{
			get
			{
				return null;
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

		public bool allowTouchInput
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool SetActionsById
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int HorizontalActionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int VerticalActionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int SubmitActionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int CancelActionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected override bool isMouseSupported
		{
			get
			{
				return default(bool);
			}
		}

		private bool isTouchAllowed
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

		public float inputActionsPerSecond
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

		private RewiredStandaloneInputModule()
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

		private bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		private bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		private void CheckButtonOrKeyMovement(float time, out bool downHorizontal, out bool downVertical)
		{
		}

		private void ProcessMouseEvents()
		{
		}

		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
		}

		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		private void ProcessMousePress(MouseButtonEventData data)
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		protected override void OnDestroy()
		{
		}

		protected override bool IsDefaultPlayer(int playerId)
		{
			return default(bool);
		}

		private void InitializeRewired()
		{
		}

		private void SetupRewiredVars()
		{
		}

		private void SetUpRewiredPlayerMice()
		{
		}

		private void SetUpRewiredActions()
		{
		}

		private bool GetButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		private float GetAxis(Player player, int actionId)
		{
			return default(float);
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

		private bool DidAnyMouseMove()
		{
			return default(bool);
		}

		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			return default(bool);
		}

		private void OnRewiredInitialized()
		{
		}

		private void OnRewiredShutDown()
		{
		}
	}
}
