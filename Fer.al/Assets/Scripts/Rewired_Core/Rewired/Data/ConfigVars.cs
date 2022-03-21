using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Platforms;
using Rewired.Utils.Attributes;

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation]
	public sealed class ConfigVars
	{
		[Serializable]
		public class PlatformVars
		{
			public bool disableKeyboard;

			public bool ignoreInputWhenAppNotInFocus;
		}

		[Serializable]
		public class PlatformVars_WindowsStandalone : PlatformVars
		{
			public bool useNativeKeyboard;

			public int joystickRefreshRate;
		}

		[Serializable]
		public class PlatformVars_WindowsUWP : PlatformVars
		{
			public bool useGamepadAPI;

			public bool useHIDAPI;
		}

		[Serializable]
		public sealed class EditorVars
		{
			public bool exportConsts_useParentClass;

			public string exportConsts_parentClassName;

			public bool exportConsts_useNamespace;

			public string exportConsts_namespace;

			public bool exportConsts_actions;

			public string exportConsts_actionsClassName;

			public bool exportConsts_actionsIncludeActionCategory;

			public bool exportConsts_actionsCreateClassesForActionCategories;

			public bool exportConsts_mapCategories;

			public string exportConsts_mapCategoriesClassName;

			public bool exportConsts_layouts;

			public string exportConsts_layoutsClassName;

			public bool exportConsts_players;

			public string exportConsts_playersClassName;

			public bool exportConsts_inputBehaviors;

			public string exportConsts_inputBehaviorsClassName;

			public bool exportConsts_customControllers;

			public string exportConsts_customControllersClassName;

			public string exportConsts_customControllersAxesClassName;

			public string exportConsts_customControllersButtonsClassName;

			public bool exportConsts_layoutManagerRuleSets;

			public string exportConsts_layoutManagerRuleSetsClassName;

			public bool exportConsts_mapEnablerRuleSets;

			public string exportConsts_mapEnablerRuleSetsClassName;

			public bool exportConsts_allCapsConstantNames;
		}

		private class rpTrAwsXAJRPMDqARIyyMgKlojJ
		{
			public Func<PlatformVars> bjvrYZcAaacSMKpeNuSKsmlSdeK;

			public string BxhlzowUFEhJSiHyyFQttiYrjxH;

			public rpTrAwsXAJRPMDqARIyyMgKlojJ(Func<PlatformVars> getDelegate, string dataPath)
			{
			}
		}

		private class wuYFmVhjyhdZUrKTNYBnEqPefCs
		{
			public Func<Platform, object> bjvrYZcAaacSMKpeNuSKsmlSdeK;

			public Action<Platform, object> vGMIYREICcYrjibzOuyHxSPUVBY;

			public wuYFmVhjyhdZUrKTNYBnEqPefCs(Func<Platform, object> getDelegate, Action<Platform, object> setDelegate)
			{
			}
		}

		[CustomObfuscation]
		internal enum AllPlatformVar
		{
			[CustomObfuscation]
			DisableKeyboard,
			[CustomObfuscation]
			IgnoreInputWhenAppNotInFocus
		}

		public UpdateLoopSetting updateLoop;

		public bool alwaysUseUnityInput;

		public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource;

		public OSXStandalonePrimaryInputSource osx_primaryInputSource;

		public LinuxStandalonePrimaryInputSource linux_primaryInputSource;

		public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource;

		public XboxOnePrimaryInputSource xboxOne_primaryInputSource;

		public PS4PrimaryInputSource ps4_primaryInputSource;

		public WebGLPrimaryInputSource webGL_primaryInputSource;

		public StadiaPrimaryInputSource stadia_primaryInputSource;

		public bool useXInput;

		public bool useNativeMouse;

		public bool useEnhancedDeviceSupport;

		public bool windowsStandalone_useSteamRawInputControllerWorkaround;

		public bool osxStandalone_useEnhancedDeviceSupport;

		public bool android_supportUnknownGamepads;

		public bool ps4_assignJoysticksByPS4JoyId;

		public bool useSteamControllerSupport;

		public bool logToScreen;

		public bool runInEditMode;

		public bool allowInputInEditorSceneView;

		public PlatformVars_WindowsStandalone platformVars_windowsStandalone;

		public PlatformVars platformVars_linuxStandalone;

		public PlatformVars platformVars_osxStandalone;

		public PlatformVars platformVars_windows8Store;

		public PlatformVars_WindowsUWP platformVars_windowsUWP;

		public PlatformVars platformVars_iOS;

		public PlatformVars platformVars_tvOS;

		public PlatformVars platformVars_android;

		public PlatformVars platformVars_ps3;

		public PlatformVars platformVars_ps4;

		public PlatformVars platformVars_psVita;

		public PlatformVars platformVars_xbox360;

		public PlatformVars platformVars_xboxOne;

		public PlatformVars platformVars_wii;

		public PlatformVars platformVars_wiiu;

		public PlatformVars platformVars_switch;

		public PlatformVars platformVars_webGL;

		public PlatformVars platformVars_stadia;

		[NonSerialized]
		private PlatformVars platformVars_unknown;

		public int maxJoysticksPerPlayer;

		public bool autoAssignJoysticks;

		public bool assignJoysticksToPlayingPlayersOnly;

		public bool distributeJoysticksEvenly;

		public bool reassignJoystickToPreviousOwnerOnReconnect;

		public DeadZone2DType defaultJoystickAxis2DDeadZoneType;

		public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType;

		public AxisSensitivityType defaultAxisSensitivityType;

		public bool force4WayHats;

		public ThrottleCalibrationMode throttleCalibrationMode;

		public bool activateActionButtonsOnNegativeValue;

		public bool deferControllerConnectedEventsOnStart;

		public LogLevelFlags logLevel;

		public EditorVars editorSettings;

		private Dictionary<int, rpTrAwsXAJRPMDqARIyyMgKlojJ> __platformVarsDict;

		private Dictionary<int, wuYFmVhjyhdZUrKTNYBnEqPefCs> __getSetPlatformVariableDict;

		private Dictionary<int, rpTrAwsXAJRPMDqARIyyMgKlojJ> platformVarsDict
		{
			get
			{
				return null;
			}
		}

		private Dictionary<int, wuYFmVhjyhdZUrKTNYBnEqPefCs> getSetPlatformVariableDict
		{
			get
			{
				return null;
			}
		}

		[Preserve]
		public ConfigVars()
		{
		}

		internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			return default(bool);
		}

		internal bool DoesPlatformUseSDL2(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			return default(bool);
		}

		internal string GetDebugConfigSettings()
		{
			return null;
		}

		[CustomObfuscation]
		internal string GetPlatformVarsRelPath(Platform platform)
		{
			return null;
		}

		[CustomObfuscation]
		internal PlatformVars GetPlatformVars(Platform platform)
		{
			return null;
		}

		[CustomObfuscation]
		internal T Editor_GetAllSerializedPlatformVar<T>(AllPlatformVar var)
		{
			return (T)null;
		}

		[CustomObfuscation]
		internal void Editor_SetAllSerializedPlatformVar(AllPlatformVar var, object value)
		{
		}

		internal bool GetPlatformVar_disableKeyboard()
		{
			return default(bool);
		}

		internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus()
		{
			return default(bool);
		}

		internal bool GetPlatformVar_useEnhancedDeviceSupport()
		{
			return default(bool);
		}

		internal bool GetPlatformVar_useNativeMouse()
		{
			return default(bool);
		}

		internal bool GetPlatformVar_useNativeKeyboard()
		{
			return default(bool);
		}

		internal int GetPlatformVar_joystickRefreshRate()
		{
			return default(int);
		}

		internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value)
		{
			return default(bool);
		}

		internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value)
		{
			return default(bool);
		}

		internal bool SetPlatformVar_useNativeMouse(bool value)
		{
			return default(bool);
		}

		internal bool SetPlatformVar_useNativeKeyboard(bool value)
		{
			return default(bool);
		}

		internal bool SetPlatformVar_joystickRefreshRate(int value)
		{
			return default(bool);
		}

		private PlatformVars GetPlatformVars()
		{
			return null;
		}

		private T GetOrCreatePlatformVars<T>(ref T var) where T : PlatformVars, new()
		{
			return null;
		}

		private MultiBoolValue GetAllSerializedPlatformVar_multiBool(AllPlatformVar var)
		{
			return default(MultiBoolValue);
		}

		internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform)
		{
			return default(bool);
		}
	}
}
