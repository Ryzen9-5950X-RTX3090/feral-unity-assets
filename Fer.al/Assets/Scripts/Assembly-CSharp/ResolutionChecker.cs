using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class ResolutionChecker
{
	private static int? _minWidth;

	private static int? _minHeight;

	private static int _antiAliasing;

	private static List<Vector2Int> _debugResolutions;

	private static Resolution _resolution;

	private static IDictionary<Resolution, string> _resolutionsNameLookup;

	private static List<Resolution> _orderedResolutions;

	private static int MinWidth
	{
		get
		{
			return default(int);
		}
	}

	private static int MinHeight
	{
		get
		{
			return default(int);
		}
	}

	private static int _fullscreen
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool IsFullscreen
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static int AntiAliasing
	{
		get
		{
			return default(int);
		}
	}

	public static DeviceQualityLevel QualityLevel
	{
		get
		{
			return default(DeviceQualityLevel);
		}
	}

	private static List<Vector2Int> debugResolutions
	{
		get
		{
			return null;
		}
	}

	public static Resolution Resolution
	{
		get
		{
			return default(Resolution);
		}
	}

	public static IDictionary<Resolution, string> ResolutionsNameLookup
	{
		get
		{
			return null;
		}
	}

	public static List<Resolution> OrderedResolutions
	{
		get
		{
			return null;
		}
	}

	public static bool CanSetResolution
	{
		get
		{
			return default(bool);
		}
	}

	public static void Init()
	{
	}

	public static string ScreenModeText(bool inIsFullscreen)
	{
		return null;
	}

	public static string ResolutionText(Resolution inResolution)
	{
		return null;
	}

	public static string AntiAliasingText(int inAntiAliasing)
	{
		return null;
	}

	public static void ConfirmAndApplyResolutionSettings(Resolution inResolution, bool inIsFullscreen, DeviceQualityLevel inQualityLevel)
	{
	}

	public static void ApplyResolutionSettings(Resolution inResolution, bool inIsFullscreen, DeviceQualityLevel? inQualityLevel)
	{
	}

	private static void OnDisplaysUpdated()
	{
	}

	private static void LoadSettings()
	{
	}

	private static void RefreshResolutions()
	{
	}

	private static void ChangeResolutionIfUnsupported()
	{
	}
}
