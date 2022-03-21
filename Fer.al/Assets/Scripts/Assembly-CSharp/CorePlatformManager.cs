using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

public class CorePlatformManager : CoreManagerBase<CorePlatformManager>
{
	private static float fpsUpdateInterval;

	private static float fpsAccumulator;

	private static int fpsFrames;

	private static float fpsTimeleft;

	private static Vector2? _deviceResolution;

	private static PerformanceLevel _currentPerformance;

	private static bool? _isLowMemoryDevice;

	private bool? _frameRateControlEnabled;

	private bool _lowPowerMode;

	private bool _frameRateControlMode;

	private float _frameRateControlModeTimer;

	private float _batteryLevel;

	private Coroutine _batteryLevelCoroutine;

	private const float maxResolutionWidthScale = 1f;

	private const float maxResolutionHeightScale = 1f;

	private const float minResolutionWidthScale = 0.1f;

	private const float minResolutionHeightScale = 0.1f;

	private const float scaleWidthIncrement = 0.05f;

	private const float scaleHeightIncrement = 0.05f;

	private float _widthScale;

	private float _heightScale;

	private float _oldWidthScale;

	private float _oldHeightScale;

	private uint _frameCount;

	private const uint kNumFrameTimings = 2u;

	private double _gpuFrameTime;

	private double _cpuFrameTime;

	[DebugField("DRes Info", "Quality", true, true)]
	private static string _dynamicResolutionDebugInfo;

	private static string[] _simplePlatformNames;

	private CoreDeviceQualitySettingsEntry _currentDeviceQualitySettings;

	protected Dictionary<DeviceQualityLevel, CoreDeviceQualitySettingsEntry> _deviceQualitySettingsMap;

	public static float CurrentFPS
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static Vector2? DeviceResolution
	{
		get
		{
			return null;
		}
	}

	public string FPSCurrentString
	{
		get
		{
			return null;
		}
	}

	public static DeviceQualityLevel DeviceQuality
	{
		get
		{
			return default(DeviceQualityLevel);
		}
		set
		{
		}
	}

	public static PerformanceLevel CurrentPerformance
	{
		get
		{
			return default(PerformanceLevel);
		}
	}

	public static bool IsLowMemoryDevice
	{
		get
		{
			return default(bool);
		}
	}

	private bool FrameRateControlEnabled
	{
		get
		{
			return default(bool);
		}
	}

	[DebugField("Occlusion", "Quality", false, true)]
	public static bool ToggleOcclusion
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugField("Bloom", "Quality", false, true)]
	public static bool ToggleBloom
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugField("Shadows", "Quality", false, true)]
	public static bool ToggleShadows
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugField("AA", "Quality", false, true)]
	public static bool ToggleAA
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static string[] SimplePlatformNames
	{
		get
		{
			return null;
		}
	}

	public CoreDeviceQualitySettingsEntry CurrentDeviceQualitySettings
	{
		get
		{
			return null;
		}
	}

	protected Dictionary<DeviceQualityLevel, CoreDeviceQualitySettingsEntry> DeviceQualitySettingsMap
	{
		get
		{
			return null;
		}
	}

	public virtual bool AllowFrameRateControlMode()
	{
		return default(bool);
	}

	public void SetDeviceQuality(DeviceQualityLevel inQuality)
	{
	}

	public override void Init()
	{
	}

	private void ClearDeviceCaching()
	{
	}

	protected virtual void InitQualityLevel()
	{
	}

	private static void UnsupportedReset(MessageState inState)
	{
	}

	public bool IsPhone()
	{
		return default(bool);
	}

	public bool IsMobilePlatform()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<BatteryLevelUpdate>d__38))]
	private IEnumerator BatteryLevelUpdate()
	{
		return null;
	}

	public override void MUpdate()
	{
	}

	private void UpdateFPS()
	{
	}

	[DebugButton("DRes+", "Quality", true, false)]
	public static void IncreaseDynamicResolutionScale()
	{
	}

	[DebugButton("DRes-", "Quality", true, false)]
	public static void DecreaseDynamicResolutionScale()
	{
	}

	private void UpdateDynamicResolution()
	{
	}

	public static SimplePlatform EditorGetSimplePlatformFromBuildTarget()
	{
		return default(SimplePlatform);
	}

	public static SimplePlatform GetSimplePlatformFromRunTime()
	{
		return default(SimplePlatform);
	}

	protected void ResetDeviceQualitySettings()
	{
	}

	protected virtual void SetDeviceQualitySettingsMap()
	{
	}
}
