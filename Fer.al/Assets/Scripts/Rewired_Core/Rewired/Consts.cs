using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Config;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class Consts
	{
		public const int systemPlayerId = 9999999;

		public const string menuRoot = "Window/Rewired";

		internal const int programVersion1 = 1;

		internal const int programVersion2 = 1;

		internal const int programVersion3 = 28;

		internal const int programVersion4 = 0;

		internal const int dataVersion = 1;

		internal const int unityMajorVersion = 2019;

		internal const string unityMajorVersionIdentifier = "U2019";

		internal const bool isTrial = false;

		internal const string copyrightYear = "2019";

		internal const string defaultNamespace = "Rewired";

		internal const LogLevelFlags defaultLogLevel = LogLevelFlags.Info | LogLevelFlags.Warning | LogLevelFlags.Error;

		internal const bool allowInputWhenEditorPaused = true;

		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = "[SplitTriggers]";

		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = "[CombinedTriggers]";

		internal const float editorGUIUpdateInterval = 0.5f;

		internal const float joystickRefreshPollCheckTimeout = 1f;

		internal const float controllerRefreshWaitTimeout = 0.5f;

		internal const int buttonsPerHat = 8;

		internal const int keyboardKeyCount = 132;

		internal const int keyboardModifierKeyCount = 8;

		internal const int unityMouseButtonCount = 7;

		internal const int unityMouseAxisCount = 3;

		internal const int unityMaxJoysticks = 16;

		internal const int unityJoystickButtonCount = 20;

		internal const int unityJoystickStartingButtonKeycodeValue = 350;

		internal const int unityJoystickAxisCount = 29;

		internal const int unityJoystickLastJoystickIdWithButtonKeyCodes = 16;

		internal const string unityJoystickPrefix = "Joy";

		internal const string unityJoystickAxisSuffix = "Axis";

		internal const string unityJoystickButtonSuffix = "Button";

		internal const int directInputMaxButtons = 128;

		internal const int directInputMaxAxes = 32;

		internal const int directInputMaxHats = 4;

		internal const int directInputMaxSliders = 2;

		internal const int directInputMaxAxisValue = 65535;

		internal const int directInputMinAxisValue = -65535;

		internal const int directInputMaxHatValue = 36000;

		internal const int directInputHatZeroValue = -1;

		internal const int directInputHatSpan = 4500;

		internal const int directInputHatSpan4Way = 9000;

		internal const int directInput_hatValue_up = 0;

		internal const int directInput_hatValue_right = 9000;

		internal const int directInput_hatValue_down = 18000;

		internal const int directInput_hatValue_left = 27000;

		internal const int directInputLastDirectionValue = 31500;

		internal const int directInputLastDirectionValue4Way = 27000;

		internal const int directInputUnknownJoystickHatCount = 2;

		internal const int directInputUnknownJoystickHatButtonStartIndex = 128;

		internal const int directInputJoystickStateByteSize = 264;

		internal const int rawInputMaxButtons = 256;

		internal const int rawInputMaxAxes = 56;

		internal const int rawInputMaxHats = 4;

		internal const int rawInputMaxSliders = 2;

		internal const int rawInputMaxAxisValue = 65535;

		internal const int rawInputMinAxisValue = -65535;

		internal const int rawInputMaxHatValue = 36000;

		internal const int rawInputHatZeroValue = -1;

		internal const int rawInputHatSpan = 4500;

		internal const int rawInputHatSpan4Way = 9000;

		internal const int rawInput_hatValue_up = 0;

		internal const int rawInput_hatValue_right = 9000;

		internal const int rawInput_hatValue_down = 18000;

		internal const int rawInput_hatValue_left = 27000;

		internal const int rawInputLastDirectionValue = 31500;

		internal const int rawInputLastDirectionValue4Way = 27000;

		internal const int rawInputUnknownJoystickHatCount = 2;

		internal const int rawInputUnknownJoystickHatButtonStartIndex = 128;

		internal const int rawInputUnifiedMouseButtonCount = 5;

		internal const int rawInputUnifiedMouseAxisCount = 3;

		internal const float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int rawInputUnifiedKeyboardButtonCount = 132;

		internal const int osxMaxSticks = 4;

		internal const int osxMaxButtons = 128;

		internal const int osxMaxAxesPerStick = 14;

		internal const int osxMaxHatsPerStick = 4;

		internal const int osxMaxAxisValue = 65536;

		internal const int osxMinAxisValue = -65536;

		internal const int osxMaxPressureSensitiveButtonValue = 65536;

		internal const int osxMinPressureSensitiveButtonValue = 0;

		internal const int osxMaxHatValue = 36000;

		internal const int osxInputHatZeroValue = -1;

		internal const int osxHatSpan = 4500;

		internal const int osxHatSpan4Way = 9000;

		internal const int osx_hatValue_up = 0;

		internal const int osx_hatValue_right = 9000;

		internal const int osx_hatValue_down = 18000;

		internal const int osx_hatValue_left = 27000;

		internal const int osxLastDirectionValue = 31500;

		internal const int osxLastDirectionValue4Way = 27000;

		internal const int osxUnknownJoystickHatCount = 16;

		internal const int osxUnknownJoystickHatButtonStartIndex = 128;

		internal const int linuxMaxButtons = 256;

		internal const int linuxMaxAxes = 56;

		internal const int linuxMaxHats = 4;

		internal const int linuxMaxSliders = 2;

		internal const int linuxMaxAxisValue = 32767;

		internal const int linuxMinAxisValue = -32768;

		internal const int linuxMaxHatValue = 36000;

		internal const int linuxHatZeroValue = -1;

		internal const int linuxHatSpan = 4500;

		internal const int linuxHatSpan4Way = 9000;

		internal const int linux_hatValue_up = 0;

		internal const int linux_hatValue_right = 9000;

		internal const int linux_hatValue_down = 18000;

		internal const int linux_hatValue_left = 27000;

		internal const int linuxLastDirectionValue = 31500;

		internal const int linuxLastDirectionValue4Way = 27000;

		internal const int linuxUnknownJoystickHatCount = 2;

		internal const int linuxUnknownJoystickHatButtonStartIndex = 128;

		internal const int linuxUnifiedMouseButtonCount = 5;

		internal const int linuxUnifiedMouseAxisCount = 3;

		internal const float linuxUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int sdl2MaxButtons = 256;

		internal const int sdl2MaxAxes = 56;

		internal const int sdl2MaxHats = 4;

		internal const int sdl2MaxSliders = 2;

		internal const int sdl2MaxAxisValue = 32768;

		internal const int sdl2MinAxisValue = -32767;

		internal const int sdl2AxisZeroValue = 0;

		internal const int sdl2MaxHatValue = 36000;

		internal const int sdl2HatZeroValue = -1;

		internal const int sdl2HatSpan = 4500;

		internal const int sdl2HatSpan4Way = 9000;

		internal const int sdl2_hatValue_up = 0;

		internal const int sdl2_hatValue_right = 9000;

		internal const int sdl2_hatValue_down = 18000;

		internal const int sdl2_hatValue_left = 27000;

		internal const int sdl2LastDirectionValue = 31500;

		internal const int sdl2LastDirectionValue4Way = 27000;

		internal const int sdl2UnknownJoystickHatCount = 2;

		internal const int sdl2UnknownJoystickHatButtonStartIndex = 128;

		internal const int sdl2UnifiedMouseButtonCount = 5;

		internal const int sdl2UnifiedMouseAxisCount = 3;

		internal const float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int windowsUWPMaxButtons = 256;

		internal const int windowsUWPMaxAxes = 56;

		internal const int windowsUWPMaxHats = 4;

		internal const int windowsUWPMaxSliders = 2;

		internal const int windowsUWPMaxAxisValue = 32767;

		internal const int windowsUWPMinAxisValue = -32768;

		internal const int windowsUWPMaxHatValue = 36000;

		internal const int windowsUWPHatZeroValue = -1;

		internal const int windowsUWPDirectionsPerHat = 8;

		internal const int windowsUWPHatSpan = 4500;

		internal const int windowsUWPHatSpan4Way = 9000;

		internal const int windowsUWPLastDirectionValue = 31500;

		internal const int windowsUWPLastDirectionValue4Way = 27000;

		internal const int windowsUWPUnknownJoystickHatCount = 2;

		internal const int windowsUWPUnknownJoystickHatButtonStartIndex = 128;

		internal const int windowsUWPUnifiedMouseButtonCount = 5;

		internal const int windowsUWPUnifiedMouseAxisCount = 3;

		internal const float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int xInputMaxVibration = 65535;

		internal const int xInputMinVibration = 0;

		internal const float xInputAllowedVibrationInterval = 0.01f;

		internal const int customPlatformMaxButtons = 256;

		internal const int customPlatformMaxAxes = 128;

		internal const int internalDriverMaxButtons = 256;

		internal const int internalDriverMaxAxes = 56;

		internal const int internalDriverMaxHats = 4;

		internal const int internalDriverMaxSliders = 2;

		internal const int internalDriverMaxAxisValue = 65535;

		internal const int internalDriverMinAxisValue = -65535;

		internal const int internalDriverMaxHatValue = 36000;

		internal const int internalDriverHatZeroValue = -1;

		internal const int internalDriverHatSpan = 4500;

		internal const int internalDriverHatSpan4Way = 9000;

		internal const int internalDriver_hatValue_up = 0;

		internal const int internalDriver_hatValue_right = 9000;

		internal const int internalDriver_hatValue_down = 18000;

		internal const int internalDriver_hatValue_left = 27000;

		internal const int internalDriverLastDirectionValue = 31500;

		internal const int internalDriverLastDirectionValue4Way = 27000;

		internal const int internalDriverUnknownJoystickHatCount = 2;

		internal const int internalDriverUnknownJoystickHatButtonStartIndex = 128;

		internal const int internalDriverUnifiedMouseButtonCount = 5;

		internal const int internalDriverUnifiedMouseAxisCount = 3;

		internal const float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int webGLMaxButtons = 256;

		internal const int webGLMaxAxes = 128;

		internal const int stadiaMaxButtons = 256;

		internal const int stadiaMaxAxes = 128;

		internal const float axisPollingDeadzone = 0.7f;

		internal const float mouseXYAxisPollingDeadzone = 100f;

		internal const float mouseOtherAxisPollingDeadzone = 2f;

		internal const float defaultButtonDeadZone = 0.5f;

		internal const float hardwareButtonDeadZone = 0.01f;

		internal const float axisDefaultSensitivity = 1f;

		internal const AxisSensitivityType axisDefaultSensitivityType = AxisSensitivityType.Multiplier;

		internal const float defaultButtonDoublePressSpeed = 0.3f;

		internal const float minDoubleButtonPressSpeed = 0.01f;

		internal const float maxDoubleButtonPressSpeed = 10f;

		internal const float defaultButtonShortPressTime = 0.25f;

		internal const float minButtonShortPressTime = 0f;

		internal const float maxButtonShortPressTime = float.MaxValue;

		internal const float defaultButtonShortPressExpiresIn = 0f;

		internal const float minButtonShortPressExpiresIn = 0f;

		internal const float maxButtonShortPressExpiresIn = float.MaxValue;

		internal const float defaultButtonLongPressTime = 1f;

		internal const float minButtonLongPressTime = 0f;

		internal const float maxButtonLongPressTime = float.MaxValue;

		internal const float defaultButtonLongPressExpiresIn = 0f;

		internal const float minButtonLongPressExpiresIn = 0f;

		internal const float maxButtonLongPressExpiresIn = float.MaxValue;

		internal const float defaultButtonRepeatDelay = 0f;

		internal const float defaultButtonRepeatRate = 30f;

		internal const float minButtonRepeatRate = 0.001f;

		internal const float mouseAxisPollingTimerLength = 1f;

		internal const float fallbackPollingTimeout = 1f;

		internal const string unknownJoystickName = "Unknown Controller";

		internal const float xInputControllerVibrationRenewalInterval = 1.5f;

		internal const float stadiaControllerVibrationRenewalInterval = 1f;

		internal const int defaultInputThreadUpdateRateFPS = 240;

		internal const int maxInputThreadUpdateRateFPS = 2000;

		internal const int osxXInputOutputReportRefreshRateFPS = 60;

		internal const int defaultOutputRefreshRateFPS = 100;

		internal const int hidOutputReportRefreshRateFPS = 100;

		internal const int hidOutputReportThreadKillTimeout = 10000;

		internal const int joystickInputReportRingBufferCapacity = 25;

		internal const string resourecesDLLPath_windowsStandalone = "Libs/Rewired_Windows";

		internal const string resourecesDLLPath_osxStandalone = "Libs/Rewired_OSX";

		internal const string resourecesDLLPath_linux = "Libs/Rewired_Linux";

		internal const float defaultInputBehaviorAxisSensitivity = 1f;

		internal const float defaultInputBehaviorAxisSimulation_gravity = 3f;

		internal const float defaultInputBehaviorAxisSimulation_sensitivity = 3f;

		internal const bool defaultInputBehaviorAxisSmoothing_snap = true;

		internal const bool defaultInputBehaviorAxisSmoothing_instantReverse = false;

		internal const bool defaultInputBehaviorAxisSimulation_enabled = true;

		internal const int allFlagsIntEnum = -1;

		internal const int lowLevelEventBuffers_buttonEventBufferSize = 16;

		internal const string schemaNameSpace = "http://guavaman.com/rewired";

		internal const string schemaBaseLocation = "http://guavaman.com/schemas/rewired/";

		internal const string schemaVersionControllerMap = "1.1";

		internal const string schemaVersionCalibrationMap = "1.3";

		internal const string schemaVersionInputBehavior = "1.4";

		internal const string schemaVersionControllerTemplateMap = "1.0";

		internal const string schemaVersionPlayerEnabledMapsHelperData = "1.0";

		internal const string schemaVersionPlayerControllerMapLayoutManagerData = "1.0";

		internal const int controllerMapDataVersion = 2;

		internal const int calibrationMapDataVersion = 4;

		internal const int inputBehaviorDataVersion = 5;

		internal const int controllerTemplateMapDataVersion = 1;

		internal const int playerMapEnablerDataVersion = 1;

		internal const int playerControllerMapLayoutManagerDataVersion = 1;

		internal const int controllerElementType_trueElements_minValue = 0;

		internal const int controllerElementType_trueElements_maxValue = 99;

		internal const float pressureSensitiveButtonDeadZone = 0.001f;

		internal const string rewiredEditorAssembly = "Rewired_Editor";

		internal const string rewiredEditorInputEditorClassFullName = "Rewired.Editor.InputEditor";

		internal const string nintendoSwitchPluginEditorRuntimeAssembly = "Rewired_NintendoSwitch_EditorRuntime";

		internal const string nintendoSwitchPluginInputManagerFullClassPath = "Rewired.Platforms.Switch.NintendoSwitchInputManager";

		internal const string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = "521b808c-0248-4526-bc10-f1d16ee76bf1";

		internal const string nintendoSwitchPluginHWJoystickMapGuid_Handheld = "1fbdd13b-0795-4173-8a95-a2a75de9d204";

		internal const string stadiaPluginEditorRuntimeAssembly = "Rewired_Stadia_EditorRuntime";

		internal const string stadiaPluginInputManagerFullClassPath = "Rewired.Platforms.Stadia.StadiaInputManager";

		internal const int updateLoopTypeCount = 3;

		internal static readonly PidVid[] questionablePidVids;

		internal static readonly int[] questionableVIDs;

		internal static Guid joystickGuid_appleMFiController;

		internal static Guid joystickGuid_standardizedGamepad;

		internal static Guid joystickGuid_SonyDualShock4;

		internal static Guid hardwareTypeGuid_universalKeyboard;

		internal static Guid hardwareTypeGuid_universalMouse;

		internal static readonly IList<string> unityMouseElementNames;

		private static readonly string[] BOOaLpAOcFOKJFZXRKWNMjsTeUUd;

		internal static readonly IList<string> unityMouseAxisPositiveNames;

		private static readonly string[] TwqGhFsJdtNBwABBMdyRSxgklWg;

		internal static readonly IList<string> unityMouseAxisNegativeNames;

		private static readonly string[] iKTWMUXyvBBUbDvoapYbTAgCQsk;

		internal static readonly IList<string> rawInputUnifiedMouseElementNames;

		private static readonly string[] yyShHiILDIOIKFEBWDgFvGUKCwD;

		internal static readonly IList<string> rawInputUnifiedMouseAxisPositiveNames;

		private static readonly string[] bkvTOItFUXRJwOOneKsslywIcoZ;

		internal static readonly IList<string> rawInputUnifiedMouseAxisNegativeNames;

		private static readonly string[] zJHgUHYyHiYRfAGmyxZiTVnjtRZ;

		internal static readonly IList<int> unityMouseElementIdentifierIds;

		private static readonly int[] IxhoRdFXZhJEOSTGdrLfSUOlEjj;

		internal static readonly IList<int> rawInputUnifiedMouseElementIdentifierIds;

		private static readonly int[] ALGaFTDgxQhFifdYbQOWyaRJPQiu;

		internal static readonly IList<string> mouseAxisUnityNames;

		private static readonly string[] bCVfPliCoIaqLJZlVDkzeqbWnuc;

		internal static readonly IList<string> mouseButtonUnityNames;

		private static readonly string[] YGwVQFpCupfRghrFHPflKATyRfLp;

		internal static readonly IList<string> keyboardKeyNames;

		private static readonly string[] LdMJwhAglrGZuBscZXYJafYVaiJ;

		internal static readonly IList<int> keyboardKeyValues;

		internal static readonly int[] _keyboardKeyValues;

		internal static readonly IList<string> modifierKeyShortNames;

		private static readonly string[] kqoaXidMNvcErsLwAfmmEujhhOap;

		internal static int nintendoSwitchPlugin_minPluginVersion
		{
			get
			{
				return default(int);
			}
		}

		internal static int stadiaPlugin_minPluginVersion
		{
			get
			{
				return default(int);
			}
		}

		static Consts()
		{
		}
	}
}
