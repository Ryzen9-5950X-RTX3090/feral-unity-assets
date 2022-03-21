using System;
using UnityEngine;

[Serializable]
public class DynamicAssetQualityLevel
{
	[SerializeField]
	private AssetQualityLevel _targetQualityLevel;

	[SerializeField]
	private bool _forced;

	private AssetQualityLevel? _qualityLevel;

	public AssetQualityLevel QualityLevel
	{
		get
		{
			return default(AssetQualityLevel);
		}
	}

	public void Set(AssetQualityLevel inTargetQualityLevel, bool inForced)
	{
	}
}
