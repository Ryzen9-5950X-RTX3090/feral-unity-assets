using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Rewired.Data
{
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		private class ControllerAssignmentSaveInfo
		{
			public class PlayerInfo
			{
				public int id;

				public bool hasKeyboard;

				public bool hasMouse;

				public JoystickInfo[] joysticks;

				public int joystickCount
				{
					get
					{
						return default(int);
					}
				}

				public int IndexOfJoystick(int joystickId)
				{
					return default(int);
				}

				public bool ContainsJoystick(int joystickId)
				{
					return default(bool);
				}
			}

			public class JoystickInfo
			{
				public Guid instanceGuid;

				public string hardwareIdentifier;

				public int id;
			}

			public PlayerInfo[] players;

			public int playerCount
			{
				get
				{
					return default(int);
				}
			}

			public ControllerAssignmentSaveInfo()
			{
			}

			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			public int IndexOfPlayer(int playerId)
			{
				return default(int);
			}

			public bool ContainsPlayer(int playerId)
			{
				return default(bool);
			}
		}

		private class JoystickAssignmentHistoryInfo
		{
			public readonly Joystick joystick;

			public readonly int oldJoystickId;

			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}
		}

		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		private const string logPrefix = "Rewired: ";

		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		private const int controllerMapPPKeyVersion_original = 0;

		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		private const int controllerMapPPKeyVersion = 2;

		[SerializeField]
		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		private bool isEnabled;

		[SerializeField]
		[Tooltip("Should saved data be loaded on start?")]
		private bool loadDataOnStart;

		[SerializeField]
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		private bool loadJoystickAssignments;

		[SerializeField]
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		private bool loadKeyboardAssignments;

		[SerializeField]
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		private bool loadMouseAssignments;

		[SerializeField]
		[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
		private string playerPrefsKeyPrefix;

		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching;

		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending;

		[NonSerialized]
		private bool wasJoystickEverDetected;

		[NonSerialized]
		private List<int> __allActionIds;

		[NonSerialized]
		private string __allActionIdsString;

		public bool IsEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LoadDataOnStart
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LoadJoystickAssignments
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LoadKeyboardAssignments
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LoadMouseAssignments
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string PlayerPrefsKeyPrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string playerPrefsKey_controllerAssignments
		{
			get
			{
				return null;
			}
		}

		private bool loadControllerAssignments
		{
			get
			{
				return default(bool);
			}
		}

		private List<int> allActionIds
		{
			get
			{
				return null;
			}
		}

		private string allActionIdsString
		{
			get
			{
				return null;
			}
		}

		public override void Save()
		{
		}

		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		public override void SavePlayerData(int playerId)
		{
		}

		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		public override void Load()
		{
		}

		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		public override void LoadPlayerData(int playerId)
		{
		}

		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		protected override void OnInitialize()
		{
		}

		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private int LoadAll()
		{
			return default(int);
		}

		private int LoadPlayerDataNow(int playerId)
		{
			return default(int);
		}

		private int LoadPlayerDataNow(Player player)
		{
			return default(int);
		}

		private int LoadAllJoystickCalibrationData()
		{
			return default(int);
		}

		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return default(int);
		}

		private int LoadJoystickCalibrationData(int joystickId)
		{
			return default(int);
		}

		private int LoadJoystickData(int joystickId)
		{
			return default(int);
		}

		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private int LoadInputBehaviors(int playerId)
		{
			return default(int);
		}

		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return default(int);
		}

		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			return default(int);
		}

		private bool LoadControllerAssignmentsNow()
		{
			return default(bool);
		}

		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<LoadJoystickAssignmentsDeferred>d__80))]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		private void SaveAll()
		{
		}

		private void SavePlayerDataNow(int playerId)
		{
		}

		private void SavePlayerDataNow(Player player)
		{
		}

		private void SaveAllJoystickCalibrationData()
		{
		}

		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		private void SaveJoystickData(int joystickId)
		{
		}

		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
		}

		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
		}

		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
		}

		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
		}

		private bool SaveControllerAssignments()
		{
			return default(bool);
		}

		private bool ControllerAssignmentSaveDataExists()
		{
			return default(bool);
		}

		private string GetBasePlayerPrefsKey(Player player)
		{
			return null;
		}

		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return null;
		}

		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		private string GetInputBehaviorXml(Player player, int id)
		{
			return null;
		}

		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			return default(bool);
		}

		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			return default(int);
		}

		private void RefreshLayoutManager(int playerId)
		{
		}

		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}
	}
}
