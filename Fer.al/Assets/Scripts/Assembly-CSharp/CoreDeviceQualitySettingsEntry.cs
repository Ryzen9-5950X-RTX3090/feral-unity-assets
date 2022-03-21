using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CoreDeviceQualitySettingsEntry
{
	public int _targetFrameRate;

	public bool _useLowPowerMode;

	public bool _useFrameRateControl;

	public ThreadPriority _unityBackgroundLoadingPriority;

	public bool _useConstantCollection;

	public int _animationUpdatePerFrame;

	public bool _usePostProcessingColorGrading;

	public bool _usePostProcessingOcclusion;

	public bool _usePostProcessingBloom;

	public bool _usePostProcessingMotionBlur;

	public bool _useShadows;

	public bool _useAA;

	private List<string> _qualityLevelNames;

	public string _unityQualityLevel;

	public Dictionary<AssetQualityLevel, AssetQualityLevel> _assetQualityMapping;

	public AudioQualityLevel _audioQuality;

	public int _maxResolution;

	public int TargetFrameRate
	{
		get
		{
			return default(int);
		}
	}

	public int TargetVSyncCount
	{
		get
		{
			return default(int);
		}
	}

	public bool UseLowPowerMode
	{
		get
		{
			return default(bool);
		}
	}

	public bool UseFrameRateControl
	{
		get
		{
			return default(bool);
		}
	}

	public ThreadPriority UnityBackgroundLoadingPriority
	{
		get
		{
			return default(ThreadPriority);
		}
	}

	public bool UseConstantCollection
	{
		get
		{
			return default(bool);
		}
	}

	public int AnimationUpdatePerFrame
	{
		get
		{
			return default(int);
		}
	}

	public bool UsePostProcessingColorGrading
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool UsePostProcessingOcclusion
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool UsePostProcessingBloom
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool UsePostProcessingMotionBlur
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool UseShadows
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool UseAA
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int UnityQualityLevel
	{
		get
		{
			return default(int);
		}
	}

	public AudioQualityLevel AudioQualityLevel
	{
		get
		{
			return default(AudioQualityLevel);
		}
	}

	public string AudioQualityPostfix
	{
		get
		{
			return null;
		}
	}

	public int MaxResolution
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public AssetQualityLevel GetAdjustedAssetQualityLevel(AssetQualityLevel inQualityLevel)
	{
		return default(AssetQualityLevel);
	}
}
