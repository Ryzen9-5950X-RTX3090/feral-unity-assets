using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired
{
	public static class ReInput
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ConfigHelper : CodeHelper
		{
			private static ConfigHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

			internal static ConfigHelper Instance
			{
				get
				{
					return null;
				}
			}

			public bool useXInput
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public UpdateLoopSetting updateLoop
			{
				get
				{
					return default(UpdateLoopSetting);
				}
				set
				{
				}
			}

			public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource
			{
				get
				{
					return default(WindowsStandalonePrimaryInputSource);
				}
				set
				{
				}
			}

			public OSXStandalonePrimaryInputSource osxStandalonePrimaryInputSource
			{
				get
				{
					return default(OSXStandalonePrimaryInputSource);
				}
				set
				{
				}
			}

			public LinuxStandalonePrimaryInputSource linuxStandalonePrimaryInputSource
			{
				get
				{
					return default(LinuxStandalonePrimaryInputSource);
				}
				set
				{
				}
			}

			public WindowsUWPPrimaryInputSource windowsUWPPrimaryInputSource
			{
				get
				{
					return default(WindowsUWPPrimaryInputSource);
				}
				set
				{
				}
			}

			public bool windowsUWPSupportHIDDevices
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public XboxOnePrimaryInputSource xboxOnePrimaryInputSource
			{
				get
				{
					return default(XboxOnePrimaryInputSource);
				}
				set
				{
				}
			}

			public PS4PrimaryInputSource ps4PrimaryInputSource
			{
				get
				{
					return default(PS4PrimaryInputSource);
				}
				set
				{
				}
			}

			public WebGLPrimaryInputSource webGLPrimaryInputSource
			{
				get
				{
					return default(WebGLPrimaryInputSource);
				}
				set
				{
				}
			}

			public bool alwaysUseUnityInput
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool disableNativeInput
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool nativeMouseSupport
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool nativeKeyboardSupport
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool enhancedDeviceSupport
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int joystickRefreshRate
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public bool ignoreInputWhenAppNotInFocus
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool android_supportUnknownGamepads
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public DeadZone2DType defaultJoystickAxis2DDeadZoneType
			{
				get
				{
					return default(DeadZone2DType);
				}
				set
				{
				}
			}

			public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType
			{
				get
				{
					return default(AxisSensitivity2DType);
				}
				set
				{
				}
			}

			public AxisSensitivityType defaultAxisSensitivityType
			{
				get
				{
					return default(AxisSensitivityType);
				}
				set
				{
				}
			}

			public bool force4WayHats
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool activateActionButtonsOnNegativeValue
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public ThrottleCalibrationMode throttleCalibrationMode
			{
				get
				{
					return default(ThrottleCalibrationMode);
				}
				set
				{
				}
			}

			public bool deferControllerConnectedEventsOnStart
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool autoAssignJoysticks
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int maxJoysticksPerPlayer
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public bool distributeJoysticksEvenly
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool assignJoysticksToPlayingPlayersOnly
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool reassignJoystickToPreviousOwnerOnReconnect
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public LogLevelFlags logLevel
			{
				get
				{
					return default(LogLevelFlags);
				}
				set
				{
				}
			}

			private ConfigHelper()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ControllerHelper : CodeHelper
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public sealed class PollingHelper : CodeHelper
			{
				private static PollingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

				internal static PollingHelper Instance
				{
					get
					{
						return null;
					}
				}

				private PollingHelper()
				{
				}

				public ControllerPollingInfo PollAllControllersForFirstElement()
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersForFirstElementDown()
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersForFirstButton()
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersForFirstButtonDown()
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersForFirstAxis()
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstElementDown(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElements()
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElementsDown()
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtons()
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtonsDown()
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllAxes()
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				private ControllerPollingInfo dxGBopFwPGpRnntJodvmMTzYCpiY()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo fWKPjGiTOuPWukeRyCkdtHrmENvE()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo ZofbmNrsDVSejYtKcoCeGNYmbpn()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo PUcjNuzteixdxqKUVlKFhYGZmsf()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo UKRVFPSTSpcGXWGJXZBATXbYkwq()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo bGKlLbFWmbtGAiOmNKKPUtnwcAZ(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo rqyemvFZhjSSrBYMaOhYnmPCKqem(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo NQtBLmIPQGvDNomIxxmiVjxcQNAA(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo NadfyxFpnsKvEQGCdsAnNZMYaax(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo oKWdenitALAFVrRNgIdhEPKFJvb(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo DIwYDhteIrUYYQHskNqJZhFugHo()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo ciKfGFbLFusTsJrpdJggIwKAROUA()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo nPZxtrrDJyGWOPAciHrsnAGWWPi()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo qBQnfvsldcNuFORfufcManPBmLhk()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo gzutiYORsAguHeeehFjLCLdsDfQh()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo QjcCJttJgHDOZjHbrELXHpwfUGLO()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo sNEfSVWAjRTlpjNlZKETBtDzecp()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo oSFtmtOlVnmtllndgZhgzjXrcPbB()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo BqyFLNGhnxjMKKYomIkiUEqnhvbC()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo pxpCQJFztfslpkhJUtGDeDKsfMI()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo VttanxeBuoolFYVesRmMRlbaZaiL()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo sxpqmzYXwllNCeZVMFVbptxNUkx()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo ukARGcUNoOKRPjiqVKBcGVMeLqZ(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo SsyPctSmRbgMoZvfEsIGiNBNfBS(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo HTLpMztZmHhBNnBWhwmKUZaJjJx(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo EVefEGecgrsLVWECEuaCKzyFaYa(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo meAjTtJCVRtvGxDotlYZDOPybkb(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> AItrmiLLNLETHbDmllsTwttPIQaC()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> jrGRHFKGLMVcvwxfLWDvEVEfMLi()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> BtGYtVGEqwSHtYaXzzQUrewGJtn()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> uMQCThPkzuvLVNhlZAgYnTPKtmq()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> CfecEujJWgnIEBaHKLlKSQqNiSk()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> ZWimbzFMwCSuhYFEcXFEeWFifWR(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> RehcirISqbiBTGUaoHnpFtPenXv(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> zWDCSWjzhmjQvPyFnbCXiBHCOwJJ(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> MtBriKVVFZdgebmAQffCEKEFdXl(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> OSicUzHcokWNlWyDVoxJoXjEYvE(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> omzYIcEzjUxwVujJpCnfGdFwAbX()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> MklBDqRYzLrUUBNdRhVSLsUiLKI()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> LhmHRTYQoeUAxXbxFBjrIwBLUWUp()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> ZPuArbyTCfKafkfAWuhezckKgqj()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> gsMyLZGcNmItjsvMlQRZdhKNgYvC()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> OyLGmfjCcioJWJtAePmnOTazcwS()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> KyIBIZHBRRlfClOWAZETcMKeKqb()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> ptBfGdJhSVIOGLSnobCWSRZzxBii()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> XKeRkgCoTdFtbODgFSXZqtgWlrZ()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> MJIamdcXeYbqxTTEaHBvVhjKibf()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> yoOWDMRSkMEUZtHTwrKxqttgCFo()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> maRRnmjmoNDrDjpkFIWHkPqGUslH()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> wYgrvTepDlcraADeICRgBBKzeBpu(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> BqEGmaeHIeNTnicYHhRMjMtLkMLC(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> YklCVTfTmFGyKDdTjkJgSXyKecKX(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> OevlbRZKmWsizWsTsKtDOUmFvIt(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> TrQFuxrthJtxLaAuKTMNREkLqsA(int P_0)
				{
					return null;
				}
			}

			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class ConflictCheckingHelper : CodeHelper
			{
				private static ConflictCheckingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

				internal static ConflictCheckingHelper Instance
				{
					get
					{
						return null;
					}
				}

				private ConflictCheckingHelper()
				{
				}

				public bool DoesAnyElementAssignmentConflict()
				{
					return default(bool);
				}

				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps)
				{
					return default(bool);
				}

				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(bool);
				}

				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(bool);
				}

				private bool DxUxCsinfAWFYpubKnmfntdUduK(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return default(bool);
				}

				private bool DxUxCsinfAWFYpubKnmfntdUduK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(bool);
				}

				private bool wXcueicCklSRvlxEnukgGZLyfpI(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return default(bool);
				}

				private bool wXcueicCklSRvlxEnukgGZLyfpI(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(bool);
				}

				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return default(bool);
				}

				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(bool);
				}

				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return default(bool);
				}

				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(bool);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return null;
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(int);
				}

				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return default(int);
				}

				private int zUesUqgzAjTqcPAFWJspqFdOSAK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				private int AAzbhFdYOVScAsWiElenoaQTPBi(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return default(int);
				}

				private int AAzbhFdYOVScAsWiElenoaQTPBi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return default(int);
				}

				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return default(int);
				}

				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					return default(int);
				}

				private int NelggbthumjxGTexgIAOZhYwWoK(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return default(int);
				}

				private int NelggbthumjxGTexgIAOZhYwWoK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				private int SkffTQYiVFTbnzlfYOUqAgXirDr(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return default(int);
				}

				private int SkffTQYiVFTbnzlfYOUqAgXirDr(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					return default(int);
				}

				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}

				private int qzXyzfORVDqhzRVipLqpqtoChSh(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					return default(int);
				}

				private int qzXyzfORVDqhzRVipLqpqtoChSh(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					return default(int);
				}
			}

			private static ControllerHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

			public readonly PollingHelper polling;

			public readonly ConflictCheckingHelper conflictChecking;

			internal static ControllerHelper Instance
			{
				get
				{
					return null;
				}
			}

			public int controllerCount
			{
				get
				{
					return default(int);
				}
			}

			public IList<Controller> Controllers
			{
				get
				{
					return null;
				}
			}

			public Mouse Mouse
			{
				get
				{
					return null;
				}
			}

			public Keyboard Keyboard
			{
				get
				{
					return null;
				}
			}

			[Obsolete]
			public bool keyboardEnabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int joystickCount
			{
				get
				{
					return default(int);
				}
			}

			public IList<Joystick> Joysticks
			{
				get
				{
					return null;
				}
			}

			public int customControllerCount
			{
				get
				{
					return default(int);
				}
			}

			public IList<CustomController> CustomControllers
			{
				get
				{
					return null;
				}
			}

			private ControllerHelper()
			{
			}

			public T GetController<T>(int controllerId) where T : Controller
			{
				return null;
			}

			public int GetControllerCount(ControllerType controllerType)
			{
				return default(int);
			}

			public Controller GetController(ControllerType controllerType, int controllerId)
			{
				return null;
			}

			public Controller GetController(ControllerIdentifier controllerIdentifier)
			{
				return null;
			}

			public Controller[] GetControllers(ControllerType controllerType)
			{
				return null;
			}

			public string[] GetControllerNames(ControllerType controllerType)
			{
				return null;
			}

			public bool IsControllerAssigned(ControllerType controllerType, Controller controller)
			{
				return default(bool);
			}

			public bool IsControllerAssigned(ControllerType controllerType, int controllerId)
			{
				return default(bool);
			}

			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId)
			{
				return default(bool);
			}

			public void RemoveControllerFromAllPlayers(Controller controller, bool includeSystemPlayer = true)
			{
			}

			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true)
			{
			}

			public Joystick GetJoystick(int joystickId)
			{
				return null;
			}

			public Joystick[] GetJoysticks()
			{
				return null;
			}

			public string[] GetJoystickNames()
			{
				return null;
			}

			public bool IsJoystickAssigned(Joystick joystick)
			{
				return default(bool);
			}

			public bool IsJoystickAssigned(int joystickId)
			{
				return default(bool);
			}

			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId)
			{
				return default(bool);
			}

			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true)
			{
			}

			public void RemoveJoystickFromAllPlayers(int joystickId, bool includeSystemPlayer = true)
			{
			}

			public int GetUnityJoystickIdFromAnyButtonPress()
			{
				return default(int);
			}

			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly)
			{
				return default(int);
			}

			public void SetUnityJoystickId(int joystickId, int unityJoystickId)
			{
			}

			public bool SetUnityJoystickIdFromAnyButtonPress(int joystickId)
			{
				return default(bool);
			}

			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly)
			{
				return default(bool);
			}

			public CustomController GetCustomController(int customControllerId)
			{
				return null;
			}

			public CustomController[] GetCustomControllers()
			{
				return null;
			}

			public string[] GetCustomControllerNames()
			{
				return null;
			}

			public bool IsCustomControllerAssigned(CustomController customController)
			{
				return default(bool);
			}

			public bool IsCustomControllerAssigned(int customControllerId)
			{
				return default(bool);
			}

			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId)
			{
				return default(bool);
			}

			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true)
			{
			}

			public void RemoveCustomControllerFromAllPlayers(int customControllerId, bool includeSystemPlayer = true)
			{
			}

			public CustomController CreateCustomController(int sourceControllerId)
			{
				return null;
			}

			public CustomController CreateCustomController(int sourceControllerId, string tag)
			{
				return null;
			}

			public bool DestroyCustomController(CustomController customController)
			{
				return default(bool);
			}

			public CustomController GetFirstCustomControllerWithSourceId(int sourceId)
			{
				return null;
			}

			public CustomController GetFirstCustomControllerWithTag(string tag)
			{
				return null;
			}

			public IEnumerable<CustomController> CustomControllersWithSourceId(int sourceId)
			{
				return null;
			}

			public IEnumerable<CustomController> CustomControllersWithTag(string tag)
			{
				return null;
			}

			public IList<TInterface> GetControllerTemplates<TInterface>() where TInterface : IControllerTemplate
			{
				return null;
			}

			public Controller GetLastActiveController()
			{
				return null;
			}

			public Controller GetLastActiveController(ControllerType controllerType)
			{
				return null;
			}

			public T GetLastActiveController<T>() where T : Controller
			{
				return null;
			}

			public ControllerType GetLastActiveControllerType()
			{
				return default(ControllerType);
			}

			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback)
			{
			}

			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
			}

			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback)
			{
			}

			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
			}

			public void ClearLastActiveControllerChangedDelegates()
			{
			}

			public bool GetAnyButton()
			{
				return default(bool);
			}

			public bool GetAnyButton(ControllerType controllerType)
			{
				return default(bool);
			}

			public bool GetAnyButtonDown()
			{
				return default(bool);
			}

			public bool GetAnyButtonDown(ControllerType controllerType)
			{
				return default(bool);
			}

			public bool GetAnyButtonUp()
			{
				return default(bool);
			}

			public bool GetAnyButtonUp(ControllerType controllerType)
			{
				return default(bool);
			}

			public bool GetAnyButtonChanged()
			{
				return default(bool);
			}

			public bool GetAnyButtonChanged(ControllerType controllerType)
			{
				return default(bool);
			}

			public bool GetAnyButtonPrev()
			{
				return default(bool);
			}

			public bool GetAnyButtonPrev(ControllerType controllerType)
			{
				return default(bool);
			}

			public bool AutoAssignJoystick(Joystick joystick)
			{
				return default(bool);
			}

			public void AutoAssignJoysticks()
			{
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class MappingHelper : CodeHelper
		{
			private static MappingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

			internal static MappingHelper Instance
			{
				get
				{
					return null;
				}
			}

			public IList<InputMapCategory> MapCategories
			{
				get
				{
					return null;
				}
			}

			public IEnumerable<InputMapCategory> UserAssignableMapCategories
			{
				get
				{
					return null;
				}
			}

			public IList<InputCategory> ActionCategories
			{
				get
				{
					return null;
				}
			}

			public IEnumerable<InputCategory> UserAssignableActionCategories
			{
				get
				{
					return null;
				}
			}

			public IList<InputLayout> JoystickLayouts
			{
				get
				{
					return null;
				}
			}

			public IList<InputLayout> KeyboardLayouts
			{
				get
				{
					return null;
				}
			}

			public IList<InputLayout> MouseLayouts
			{
				get
				{
					return null;
				}
			}

			public IList<InputLayout> CustomControllerLayouts
			{
				get
				{
					return null;
				}
			}

			public IList<InputAction> Actions
			{
				get
				{
					return null;
				}
			}

			public IEnumerable<InputAction> UserAssignableActions
			{
				get
				{
					return null;
				}
			}

			private MappingHelper()
			{
			}

			public InputMapCategory GetMapCategory(int mapCategoryId)
			{
				return null;
			}

			public InputMapCategory GetMapCategory(string name)
			{
				return null;
			}

			public int GetMapCategoryId(string name)
			{
				return default(int);
			}

			public IEnumerable<InputMapCategory> MapCategoriesWithTag(string tag)
			{
				return null;
			}

			public IEnumerable<InputMapCategory> UserAssignableMapCategoriesWithTag(string tag)
			{
				return null;
			}

			public bool IsMapCategoryUserAssignable(int mapCategoryId)
			{
				return default(bool);
			}

			public InputCategory GetActionCategory(int mapCategoryId)
			{
				return null;
			}

			public InputCategory GetActionCategory(string name)
			{
				return null;
			}

			public int GetActionCategoryId(string name)
			{
				return default(int);
			}

			public IEnumerable<InputCategory> ActionCategoriesWithTag(string tag)
			{
				return null;
			}

			public IEnumerable<InputCategory> UserAssignableActionCategoriesWithTag(string tag)
			{
				return null;
			}

			public bool IsActionCategoryUserAssignable(int mapCategoryId)
			{
				return default(bool);
			}

			public InputLayout GetLayout(ControllerType controllerType, int layoutId)
			{
				return null;
			}

			public InputLayout GetLayout(ControllerType controllerType, string name)
			{
				return null;
			}

			public int GetLayoutId(ControllerType controllerType, string name)
			{
				return default(int);
			}

			public InputLayout GetJoystickLayout(int layoutId)
			{
				return null;
			}

			public InputLayout GetJoystickLayout(string name)
			{
				return null;
			}

			public int GetJoystickLayoutId(string name)
			{
				return default(int);
			}

			public InputLayout GetKeyboardLayout(int layoutId)
			{
				return null;
			}

			public InputLayout GetKeyboardLayout(string name)
			{
				return null;
			}

			public int GetKeyboardLayoutId(string name)
			{
				return default(int);
			}

			public InputLayout GetMouseLayout(int layoutId)
			{
				return null;
			}

			public InputLayout GetMouseLayout(string name)
			{
				return null;
			}

			public int GetMouseLayoutId(string name)
			{
				return default(int);
			}

			public InputLayout GetCustomControllerLayout(int layoutId)
			{
				return null;
			}

			public InputLayout GetCustomControllerLayout(string name)
			{
				return null;
			}

			public int GetCustomControllerLayoutId(string name)
			{
				return default(int);
			}

			public IList<InputLayout> MapLayouts(ControllerType controllerType)
			{
				return null;
			}

			public InputAction GetAction(int actionId)
			{
				return null;
			}

			public InputAction GetAction(string name)
			{
				return null;
			}

			public int GetActionId(string name)
			{
				return default(int);
			}

			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName)
			{
				return null;
			}

			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName, bool sort)
			{
				return null;
			}

			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId)
			{
				return null;
			}

			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId, bool sort)
			{
				return null;
			}

			public IEnumerable<InputAction> ActionsInCategoriesWithTag(string tag)
			{
				return null;
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId)
			{
				return null;
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId, bool sort)
			{
				return null;
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName)
			{
				return null;
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName, bool sort)
			{
				return null;
			}

			public IList<InputBehavior> GetInputBehaviors(int playerId)
			{
				return null;
			}

			public IList<InputBehavior> GetSystemPlayerInputBehaviors()
			{
				return null;
			}

			public InputBehavior GetInputBehavior(int playerId, int behaviorId)
			{
				return null;
			}

			public InputBehavior GetInputBehavior(int playerId, string behaviorName)
			{
				return null;
			}

			public InputBehavior GetSystemPlayerInputBehavior(int behaviorId)
			{
				return null;
			}

			public InputBehavior GetSystemPlayerInputBehavior(string behaviorName)
			{
				return null;
			}

			public int GetInputBehaviorId(string behaviorName)
			{
				return default(int);
			}

			internal InputBehavior VMSAYpiOGgFZnhPmOgWcUFTKLzU(int P_0)
			{
				return null;
			}

			internal InputBehavior VMSAYpiOGgFZnhPmOgWcUFTKLzU(string P_0)
			{
				return null;
			}

			public ControllerMap GetControllerMap(int id)
			{
				return null;
			}

			public ActionElementMap GetActionElementMap(int id)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstance(Controller controller, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(Joystick joystick, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId)
			{
				return null;
			}

			public KeyboardMap GetKeyboardMapInstance(string mapCategoryName, string layoutName)
			{
				return null;
			}

			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId)
			{
				return null;
			}

			public MouseMap GetMouseMapInstance(string mapCategoryName, string layoutName)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName)
			{
				return null;
			}

			[Obsolete]
			public ControllerElementIdentifier GetFirstJoystickTemplateElementIdentifier(Joystick joystick, int joystickElementIdentifierId)
			{
				return null;
			}

			private ControllerElementIdentifier vjwEhCZEZHlszoNSLRdwLzibmvc(Guid P_0, int P_1)
			{
				return null;
			}

			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, string mapCategoryName, string layoutName)
			{
				return null;
			}

			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id)
			{
				return null;
			}

			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(string name)
			{
				return null;
			}

			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id)
			{
				return null;
			}

			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(string name)
			{
				return null;
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class PlayerHelper : CodeHelper
		{
			private static PlayerHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

			internal static PlayerHelper Instance
			{
				get
				{
					return null;
				}
			}

			public int playerCount
			{
				get
				{
					return default(int);
				}
			}

			public int allPlayerCount
			{
				get
				{
					return default(int);
				}
			}

			public IList<Player> Players
			{
				get
				{
					return null;
				}
			}

			public IList<Player> AllPlayers
			{
				get
				{
					return null;
				}
			}

			public Player SystemPlayer
			{
				get
				{
					return null;
				}
			}

			private PlayerHelper()
			{
			}

			public IList<Player> GetPlayers(bool includeSystemPlayer = false)
			{
				return null;
			}

			public Player GetPlayer(int playerId)
			{
				return null;
			}

			public Player GetPlayer(string name)
			{
				return null;
			}

			public Player GetSystemPlayer()
			{
				return null;
			}

			public int GetPlayerId(string playerName)
			{
				return default(int);
			}

			public string[] GetPlayerNames(bool includeSystemPlayer = false)
			{
				return null;
			}

			public string[] GetPlayerDescriptiveNames(bool includeSystemPlayer = false)
			{
				return null;
			}

			public int[] GetPlayerIds(bool includeSystemPlayer = false)
			{
				return null;
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class TimeHelper : CodeHelper
		{
			private static TimeHelper wyGHCdkUHFjOjLlAQjAUDxGKybH;

			internal static TimeHelper Instance
			{
				get
				{
					return null;
				}
			}

			public float unscaledDeltaTime
			{
				get
				{
					return default(float);
				}
			}

			public float unscaledTime
			{
				get
				{
					return default(float);
				}
			}

			public uint currentFrame
			{
				get
				{
					return default(uint);
				}
			}

			private TimeHelper()
			{
			}
		}

		private class MPmBDkxdnNggWgQnkGyTossZItbb
		{
			private class NIMpESYenqcobEuRNuJIVWgBWKG
			{
				public readonly UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk;

				private float iAvcJHXqbXGaZCjAQGWtPtloWXJ;

				private float sizJIDsizjlWdnyZAPJDftNRnEY;

				private float ZAmYVwvwouIZAGAQVYIoEQUhPhN;

				private float ocKWBHJTwlBpUApjjfEVBkOXzGu;

				private uint sSfduAgFrdpJfGpZpatYjOZzLinV;

				private uint bSGBvpLPSOoGlRIKIDPbQVGHshS;

				private float KtDAqaSmMRlfYHXKDsduAtBuAdl;

				private float hqvabEHfItRYQIWkHBAgxLvFmJP;

				public float mvVqIzXhXGYlUhKStsZFaHkcgtP
				{
					get
					{
						return default(float);
					}
				}

				public float EVVDxzguWHQDvWvgDUhVHBmQPkLi
				{
					get
					{
						return default(float);
					}
				}

				public float FfCgIRKtWTmYBEcpkONhoXkhUlk
				{
					get
					{
						return default(float);
					}
				}

				public uint eupkLNYHupbKxOgCHbqidLtXZAwi
				{
					get
					{
						return default(uint);
					}
				}

				public uint CHOCNYDOKokOAieAfEYuhwIXqJOv
				{
					get
					{
						return default(uint);
					}
				}

				public float ljlgJtHKJJMJBJdDcshinawGVsGK
				{
					get
					{
						return default(float);
					}
				}

				public float BDYwGXKPNXUpWCSHttDxCVFljrv
				{
					get
					{
						return default(float);
					}
				}

				public NIMpESYenqcobEuRNuJIVWgBWKG(UpdateLoopType updateLoop)
				{
				}

				public void MrPMknIMZzaXDjcXZFUzCeTcWDAs()
				{
				}
			}

			private static class GFEsypbXOzjblWUKhucUcNKZvaR
			{
				public static StopwatchBase OMmnejZDVQLniULQgbPlHRIjfE
				{
					get
					{
						return null;
					}
				}

				public static StopwatchBase AQMpZVIIXTyemnHtIDPtxhINdLN()
				{
					return null;
				}

				public static StopwatchBase wyCjNuqsWjGtSUFEElHBnTNnQLS()
				{
					return null;
				}
			}

			private StopwatchBase GcGMIVuBupFgRPpaUfXCcWsCyhK;

			private float NyfpdpWceDuDtKKcqIcqrFZaZDk;

			private NIMpESYenqcobEuRNuJIVWgBWKG hclpymcDtGBEMxZtqcadqiSrnKW;

			private ADictionary<int, NIMpESYenqcobEuRNuJIVWgBWKG> EPsaxebuJgDuzXDToniUIUhlSrCu;

			private uint tGJKVwrcRdmchlBMOqvPldsSKLg;

			public float mvVqIzXhXGYlUhKStsZFaHkcgtP
			{
				get
				{
					return default(float);
				}
			}

			public float EVVDxzguWHQDvWvgDUhVHBmQPkLi
			{
				get
				{
					return default(float);
				}
			}

			public float FfCgIRKtWTmYBEcpkONhoXkhUlk
			{
				get
				{
					return default(float);
				}
			}

			public float ljlgJtHKJJMJBJdDcshinawGVsGK
			{
				get
				{
					return default(float);
				}
			}

			public float BDYwGXKPNXUpWCSHttDxCVFljrv
			{
				get
				{
					return default(float);
				}
			}

			public float XgHDcEjUvQpuRrECxetxmajRXulN
			{
				get
				{
					return default(float);
				}
			}

			public uint eupkLNYHupbKxOgCHbqidLtXZAwi
			{
				get
				{
					return default(uint);
				}
			}

			public uint CHOCNYDOKokOAieAfEYuhwIXqJOv
			{
				get
				{
					return default(uint);
				}
			}

			public uint gjDADGoAsnfIVCcCovIDYiFadpH
			{
				get
				{
					return default(uint);
				}
			}

			public void KBPXdDXgvchYOmaFpDETYNhRqLD()
			{
			}

			public void SmPrdLxmfnoOLIRlFAKVSpooigo()
			{
			}

			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType P_0)
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class UnityTouch : CodeHelper
		{
			private static UnityTouch wyGHCdkUHFjOjLlAQjAUDxGKybH;

			internal static UnityTouch Instance
			{
				get
				{
					return null;
				}
			}

			public int touchCount
			{
				get
				{
					return default(int);
				}
			}

			public Touch[] touches
			{
				get
				{
					return null;
				}
			}

			public bool simulateMouseWithTouches
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool multiTouchEnabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			private UnityTouch()
			{
			}

			public Touch GetTouch(int index)
			{
				return default(Touch);
			}
		}

		internal class ptveCNmVZXCKQBRQPTFtDMcYzpD
		{
			public readonly ValueWatcher<bool> nktPOWSPXbiSRsHEeOsPxClsfxfE;

			public readonly ValueWatcher<bool> tiHWDDxEFtzUpkEkyEBAHEDsPFDC;

			public readonly ValueWatcher<bool> IFrejARSLImRLdwfdDPLhIdmQuy;

			public readonly ValueWatcher<int> AlTSMUepmkgBJHJOfQTSTbRucSqf;

			public readonly ValueWatcher<float> FfCgIRKtWTmYBEcpkONhoXkhUlk;

			public readonly ValueWatcher<string> fSLTdUoIfrkiHYrkbcmyCkpbUSx;

			public readonly ValueWatcher<bool> PwbdpHSvkrTxwLXydCkIUcGWEdKa;

			private int oNPggxRFfiaamrjlYkrLxncjhQm;

			private readonly ValueWatcher[] rfxSyrIDszvdfUkQJgnQfICmGaOH;

			[CompilerGenerated]
			private static Func<bool> mhIoohQKHLtRvnOkGOyhEaVZzEI;

			[CompilerGenerated]
			private static Func<bool> xLsnLVMSdomUJlraUjoaaJurhHn;

			[CompilerGenerated]
			private static Func<int> LqpbqWhYLnPlrmeWYhUGvnoFNkYM;

			[CompilerGenerated]
			private static Func<float> KSctgEtbfpMomXNHtoTyKVtwYdL;

			[CompilerGenerated]
			private static Func<bool> nnpRHVINhHOVQHcgAExuBWHPHnOo;

			[CompilerGenerated]
			private static Func<string> zxFEUXSbZKUDkCYPKPrDQPuLYa;

			public int FQTGxzXqRPJAshSJnXqTZxHMxHI
			{
				get
				{
					return default(int);
				}
			}

			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs()
			{
			}

			public void NoDuTeAvSQJdmCqMOdLbwQahaKY()
			{
			}

			[CompilerGenerated]
			private static bool PoAQZUDaExIpnInliWEtfKfdTHa()
			{
				return default(bool);
			}

			[CompilerGenerated]
			private static bool JmTKlkertXqrKlYerpRBRaythRj()
			{
				return default(bool);
			}

			[CompilerGenerated]
			private static int KEgqyXXRmHNFhEKlnChuTefKlow()
			{
				return default(int);
			}

			[CompilerGenerated]
			private static float HzfFxSBABnlOZCrpvMtPGvPHUzfW()
			{
				return default(float);
			}

			[CompilerGenerated]
			private static bool psSvwMhRMUVndaclooBCVmmUEhN()
			{
				return default(bool);
			}

			[CompilerGenerated]
			private static string vgAUbxLblEVuBCHukgGuKwPkixt()
			{
				return null;
			}
		}

		[CustomObfuscation]
		internal const int programVersion1 = 1;

		[CustomObfuscation]
		internal const int programVersion2 = 1;

		[CustomObfuscation]
		internal const int programVersion3 = 28;

		[CustomObfuscation]
		internal const int programVersion4 = 0;

		[CustomObfuscation]
		internal const int dataVersion = 1;

		[CustomObfuscation]
		internal const bool isTrial = false;

		[CustomObfuscation]
		internal const string majorBranch = "U2019";

		private static InputManager_Base oFYnOYsjzEbwrRoTPnKvJqNcwRl;

		private static PlatformInputManager fQQNIagNVuOKadSDWHeEIZdVPZxe;

		internal static QkhKmYTysnOGbFdkisIvKlGHgmRI fETtoFyFnmAdbitoXqJrwqEczvg;

		internal static GOCsEdcRqIdaMQpgFWoBujLBrvX aWRGaPqZiDDZWmxLZIpMObKfuUE;

		internal static gIVsJAuBATHUFwUPFjPhfTSOtxbQ GUzLpgyjvoltNWCZmJDrRsDyjAG;

		private static ControllerDataFiles YjIJJmKufbDIGVXkGMfwsJMhhkr;

		private static UserData BETvUcESIyhlYfnSPWFCYQeCTOO;

		private static bool ZjOOLblNcYQwrXXNEEJgJyiCsWf;

		private static ConfigVars xiOZvoVvSktrTBfiDHJhhmspqpMf;

		private static UpdateLoopType gIfBHpchbnBJamaqwWFVaTvvjvQ;

		private static bool RLrEBJjXsxqUJVnnkrWRlPfOAK;

		private static Platform NyYLSoquiyWEcVsijMhDGCnVjYo;

		private static WebplayerPlatform joqpgIglPlFLIGGPWHJKGdlmQLSg;

		private static EditorPlatform TxfhmBGIgnWLQaApsgqLFjQQowUY;

		private static bool HoPBazBdCFoxRQELOgsIoujIMID;

		private static TimerAbs oWwTDCQnoHqCIakMkjfIXaPGgdDE;

		private static MPmBDkxdnNggWgQnkGyTossZItbb zAiVCOmThlMmXITYmQRmgSFUmNp;

		private static string VJvzpGdUzVSnnNLHZIBkuyHsZio;

		private static bool GaFZXIGeMeniNUvPjlsNAiVdspo;

		private static bool tTXfJUNRfcGJLEweaAqwOlqtNOX;

		private static bool HZFbWJedKsFMWOygHDsmIQfogFG;

		private static int hWaROJysncyQiXvEwTudAHBAspi;

		[CustomObfuscation]
		internal static int _id;

		private static int DcqKmvVPzsDewdOtjYUEaVXAlzm;

		private static int txeQkhdpWzDwcJYhxCtafxAgcCO;

		private static bool iiCZuHeamndoJorNHKiAVviAFfP;

		private static readonly UnityTouch BRsIJTtBuPdvOPkpXDMoAPkjuTkP;

		private static readonly PlayerHelper fcPFHbHffmDaVNpKmIJTMwlrTlB;

		private static readonly ControllerHelper xAnIGGFCVuaxQBJLyeaCMWdqUdy;

		private static readonly MappingHelper VwETmklDnvfGIxyMivgyqdqdJxd;

		private static readonly TimeHelper PbUKpkQaXlCzQkAnyLnJlJiBDRb;

		private static readonly ConfigHelper MzGrNpOxDkvyJULNGcfxFvkMXDB;

		private static tZlePwusXDDMirYvopCuiueCHfi LqtSWzHAdIrgwAdFEjBXUMiIRrv;

		private static UserDataStore klUAyuIqCekDmJtSXlPbraapIhU;

		private static IControllerAssigner rZZfDIzCqZTEQeasbOTqjWkyQpZ;

		private static ptveCNmVZXCKQBRQPTFtDMcYzpD teWYrjpJazyCntdpVwPCjYfYjiq;

		private static SafeAction<ControllerStatusChangedEventArgs> HDrtKCbCFrjwxeoEjMiyBCNexbip;

		private static SafeAction<ControllerStatusChangedEventArgs> kQdAPeerTUySLlCrgGIhzrbJqGCe;

		private static SafeAction<ControllerStatusChangedEventArgs> mkqyXGQnpEBucURdzydWuteuGcA;

		private static SafeAction sclXQebFoGCjsmKAZuPBkpCAZrA;

		private static SafeAction ipgLxqCrzyKhmsZZXuYQFCAOVEc;

		private static SafeAction enciIUBKVgMlZQweYuYwpYrunFt;

		private static SafeAction sHHenKlyyPsuebJgsfVkzOJZTAK;

		private static SafeAction ErpntPYkRdQazvZUyDLWpxZsGrW;

		[CustomObfuscation]
		private static Action<bool> _ApplicationFocusChangedEvent;

		private static Action nJoMWqNHwQzUezCyFhYciOyUksE;

		private static Action<UpdateLoopType> sNfnBdIEnoHZPLRDjjDwVpBJvXD;

		private static Action<UpdateLoopType> yApuGXhRIpWwQKSuJARpwpcijjw;

		private static Action<UpdateLoopType> sltQjSiHzZeIHyvBpuWLkMyybTU;

		private static Action AgHesbFZbWmTJpRyeqsHwPsxbbii;

		private static Action<bool> DNAwTwwxWrYcCbSjWlkqLSaRZWm;

		private static Action<bool> gqCPDWFouFlgLWbdLAIlGLdGKh;

		private static Action<bool> dWwdNogeEWyFtbXaXWnhRQjrFLx;

		private static Action<FullScreenMode> lMwzbqBNwstFuQqAthkZMjxCboX;

		private static Action LmuMGoNOPLtQsWIfOQaHBjrbfIi;

		private static Action<bool> cZQvepBqAIVsWmbiGvJJoWfrjeX;

		[CustomObfuscation]
		internal static float unscaledDeltaTime;

		[CustomObfuscation]
		internal static float unscaledTime;

		[CustomObfuscation]
		internal static float unscaledTimePrev;

		[CustomObfuscation]
		internal static uint currentFrame;

		[CustomObfuscation]
		internal static uint previousFrame;

		[CustomObfuscation]
		internal static uint absFrame;

		[CompilerGenerated]
		private static Action<Exception> GmIYhGBcpMMCirEvOkwMHZBRaFg;

		[CompilerGenerated]
		private static Action<Exception> nYlBBJwwcVkZtIQVFuIuqjeIcsK;

		[CompilerGenerated]
		private static Action<Exception> CWjBcSiUYzmlMwepxVNqomArHSvB;

		[CompilerGenerated]
		private static Action<Exception> gTLlTiQHUPsbMkAVANpjXDMPLlI;

		[CompilerGenerated]
		private static Action<Exception> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ;

		[CompilerGenerated]
		private static Action<Exception> MTpUSWdtwFfJQssYigamHIUInVb;

		[CompilerGenerated]
		private static Action<Exception> oGJrVKpLnrEZvcckdTDrxcRcoPE;

		[CompilerGenerated]
		private static Action<Exception> USlXdSBXnlfvXVVTMURFbvmMbBc;

		[CompilerGenerated]
		private static Action<Exception> LMEVXjUqLtOuqZTxhWxWORZbBET;

		[CompilerGenerated]
		private static Func<bool> mFkzNHGAqcCSXMLnBgAxEdkqCHul;

		private static tZlePwusXDDMirYvopCuiueCHfi unityInputBuffer
		{
			get
			{
				return null;
			}
		}

		public static PlayerHelper players
		{
			get
			{
				return null;
			}
		}

		public static ControllerHelper controllers
		{
			get
			{
				return null;
			}
		}

		public static MappingHelper mapping
		{
			get
			{
				return null;
			}
		}

		public static UnityTouch touch
		{
			get
			{
				return null;
			}
		}

		public static TimeHelper time
		{
			get
			{
				return null;
			}
		}

		public static IUserDataStore userDataStore
		{
			get
			{
				return null;
			}
		}

		public static ConfigHelper configuration
		{
			get
			{
				return null;
			}
		}

		public static string programVersion
		{
			get
			{
				return null;
			}
		}

		public static bool usingUnityInput
		{
			get
			{
				return default(bool);
			}
		}

		public static bool unityJoystickIdentificationRequired
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isReady
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static int id
		{
			get
			{
				return default(int);
			}
		}

		[CustomObfuscation]
		internal static bool initialized
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static UpdateLoopType currentUpdateLoop
		{
			get
			{
				return default(UpdateLoopType);
			}
		}

		[CustomObfuscation]
		internal static ConfigVars configVars
		{
			get
			{
				return null;
			}
		}

		[CustomObfuscation]
		internal static UserData UserData
		{
			get
			{
				return null;
			}
		}

		[CustomObfuscation]
		internal static Platform currentPlatform
		{
			get
			{
				return default(Platform);
			}
		}

		[CustomObfuscation]
		internal static WebplayerPlatform webplayerPlatform
		{
			get
			{
				return default(WebplayerPlatform);
			}
		}

		[CustomObfuscation]
		internal static EditorPlatform editorPlatform
		{
			get
			{
				return default(EditorPlatform);
			}
		}

		[CustomObfuscation]
		internal static bool checkNeverPressed
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool isEditor
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static Guid defaultHardwareJoystickMapGuid
		{
			get
			{
				return default(Guid);
			}
		}

		[CustomObfuscation]
		internal static bool isRunningInEditMode
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool isEditorPaused
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static float unityUnscaledDeltaTime
		{
			get
			{
				return default(float);
			}
		}

		[CustomObfuscation]
		internal static float unityUnscaledDeltaTimePrev
		{
			get
			{
				return default(float);
			}
		}

		[CustomObfuscation]
		internal static float realTime
		{
			get
			{
				return default(float);
			}
		}

		[CustomObfuscation]
		internal static int currentUnityFrame
		{
			get
			{
				return default(int);
			}
		}

		private static bool isEditorGameViewFocused
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool isAllowedEditorWindowFocused
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool isUnityEditorFocused
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform
		{
			get
			{
				return default(bool);
			}
		}

		private static bool inputAllowed
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool applicationIsFocused
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool applicationIsFullScreen
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool applicationRunInBackground
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static bool timeScaleIsPaused
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal static InputManager_Base rewiredInputManager
		{
			get
			{
				return null;
			}
		}

		[CustomObfuscation]
		internal static PlatformInputManager primaryInputManager
		{
			get
			{
				return null;
			}
		}

		[CustomObfuscation]
		internal static IControllerAssigner controllerAssigner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CustomObfuscation]
		internal static RewiredVersion rewiredVersion
		{
			get
			{
				return default(RewiredVersion);
			}
		}

		[CustomObfuscation]
		internal static int timeScalePauseChangedCount
		{
			get
			{
				return default(int);
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action InputSourceUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action EditorRecompileEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action PreShutDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action ShutDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action InitializedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> ApplicationFocusChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action EarlyUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<UpdateLoopType> UpdateStartedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<UpdateLoopType> UpdateEndedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action LateUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> ApplicationIsFullScreenChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> ApplicationRunInBackgroundChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> TimeScalePauseChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<FullScreenMode> ApplicationFullScreenModeChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action SceneLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> EditorPauseChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		static ReInput()
		{
		}

		public static void Reset()
		{
		}

		[CustomObfuscation]
		internal static bool IsInputAllowed(ControllerType controllerType)
		{
			return default(bool);
		}

		internal static void ItdhavHGXcUkAhyjaCFbIXENJheh(InputManager_Base P_0, Func<ConfigVars, object> P_1, ConfigVars P_2, ControllerDataFiles P_3, UserData P_4)
		{
		}

		internal static void JHzUZUsFQTvSmWjmIewXSnYsiSq()
		{
		}

		internal static void czYodqxgdcIwdElMkyegUEfPyfS(UpdateLoopType P_0)
		{
		}

		private static void WtfzmRcJkpzskEdOCFPheCSULzaC(UpdateLoopType P_0)
		{
		}

		private static void aLjDyaCCxjAPHdAQcpOppSlVkLmE()
		{
		}

		internal static void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType P_0)
		{
		}

		internal static void YXPwgQXmKLEoGBmBdjMvbzFLpnmw()
		{
		}

		[CustomObfuscation]
		internal static void EditorUpdate()
		{
		}

		internal static void cozuwinUKQpqyFkBMspLZBpsgZx()
		{
		}

		internal static void CihfeCOLgmPrJRnRPoaeejEWizEf()
		{
		}

		internal static void ARSkBchNZoCnEalDDuBpuIFdqwp(bool P_0)
		{
		}

		internal static void ClVLoPPfUviCWYBLLDoDisJmYPc()
		{
		}

		[CustomObfuscation]
		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController)
		{
			return null;
		}

		internal static HardwareJoystickMap GcBIiOdyTQzggNpeAanbphqNHTo(Guid P_0)
		{
			return null;
		}

		internal static HardwareJoystickTemplateMap CgDjzNHGwPDmghWwPZmlMDMkyXF(Guid P_0)
		{
			return null;
		}

		internal static IHardwareControllerTemplateMap vJYIYfBwdUOpGFkPnpFNkRYssPG(Guid P_0)
		{
			return null;
		}

		internal static IList<HardwareJoystickTemplateMap> wjdeIRdNjPOyAgaohSPOaXpVswuY(Guid P_0)
		{
			return null;
		}

		[CustomObfuscation]
		internal static int GetNewJoystickId()
		{
			return default(int);
		}

		[CustomObfuscation]
		internal static void HandleCallbackException(string source, Exception exception)
		{
		}

		[CustomObfuscation]
		internal static void HandleExternException(string source, Exception exception)
		{
		}

		[CustomObfuscation]
		internal static void HandleExternalInterfaceException(string source, Exception exception)
		{
		}

		internal static void ZJiVzFiamhXWJiEaoqsHhYSmrpk()
		{
		}

		[CustomObfuscation]
		internal static void CheckRewiredVersionCompatibility()
		{
		}

		internal static float gOwEjOBAnElHMdCPMXqWzFbEyII()
		{
			return default(float);
		}

		[CustomObfuscation]
		internal static bool CheckInitialized()
		{
			return default(bool);
		}

		[CustomObfuscation]
		internal static bool CheckInitialized(int reInputId)
		{
			return default(bool);
		}

		private static void ACxMnYVUvcAyDDIzgwIKJklrBJr()
		{
		}

		private static void xbNIgpPTtLbPHTlmmHCRmhjXJri()
		{
		}

		private static void jaWlNYsvYwfyhnyIPFoJHebdAdah([Optional] string P_0)
		{
		}

		private static void GgEJvrkhnkpoSrnymeVJMKKKgDy()
		{
		}

		private static void ctaxpqhtkFbLIhJlHhEeUanHRkf()
		{
		}

		private static void ZjLUjUuRFWofLJwnZpIlgLMrRXo(BridgedController P_0)
		{
		}

		private static void idUTwhlvoGWmxtXkHdgaCohAfqt(ControllerDisconnectedEventArgs P_0)
		{
		}

		private static void eQTXJZPHXrmQIErbgNHRGjesfXpg(ControllerStatusChangedEventArgs P_0)
		{
		}

		private static void BvHwccPfrHUFcpcPIygMLRubGwt(ControllerStatusChangedEventArgs P_0)
		{
		}

		private static void IyiZLQpuMCDajwliXvGjQjSEwTv(ControllerStatusChangedEventArgs P_0)
		{
		}

		private static void wpXzZTjUfZJCSxmuaZcKtEujgiW(UpdateControllerInfoEventArgs P_0)
		{
		}

		private static void YXaERQllkGCuyBHgnojbfAfAhwpJ(bool P_0)
		{
		}

		private static void DPWTEFhSmOrDBmHhxCEvvIttcpy(bool P_0)
		{
		}

		private static void RhaFTWKlzuDUhQOZTFjOktfeFrz(int P_0)
		{
		}

		private static void VeJROhQFjuOiuGnhGoIiTxAozOL(bool P_0)
		{
		}

		private static void vQSGogEDYoNdYcdUKBuyEXfgcaJm(bool P_0)
		{
		}

		private static void yBMPtlETbMyFNpxEJpKyiwylIHq()
		{
		}

		private static void xcSbHFyvsKOdbzkSRAioGmIwKzs()
		{
		}

		private static void JZZDkvIKTiCvpsFsmhxPPMgCkMRC(bool P_0)
		{
		}

		private static void toDAwKEZKpnEZPCkeFNrIPAvDLcC(Func<ConfigVars, object> P_0)
		{
		}

		private static void BWjrCznwcgjVJTeRHmTNILudaZn()
		{
		}

		private static void AJdGwTsaQxxBMwQQMglszXwCgc()
		{
		}

		[CompilerGenerated]
		private static void SHhkYQoZOcOvJaWepRTLupkJhxaf(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void zyjcYRapgfnlEbfnXogwbFUcPyiy(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void WMjiGVYNTwahDyfALkkAnsuilfh(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void lnjopNOBhuaRKiVQFMcqAgQPFJN(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void HBDhQkuzifPZriThEpKvTAUIOJs(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void WfJqObvMclFMRCKCczMhnQXSand(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void IKjuwUUlRDnScUiUdfOaCwquUts(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void OoUyvPYFKXXtxclqQWxQnwNfNRS(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void ADiipXCZmdRaXOJTswlCTxGhonwD(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static bool ysDyOMuGptHqmlSZXAOdikDwkxRC()
		{
			return default(bool);
		}
	}
}
