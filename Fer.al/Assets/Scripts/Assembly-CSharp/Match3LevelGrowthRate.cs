using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Match3LevelGrowthRate
{
	[SerializeField]
	[ChartInt]
	[Range(1f, 1000f)]
	[Tooltip("Rounds the score requirement to the nearest value provided. See https://www.desmos.com/calculator/nregtrj3t1 for more info")]
	private int _roundToNearest;

	[SerializeField]
	[ChartInt]
	[Range(100f, 5000f)]
	[Tooltip("Sets the first level's score requirement. See https://www.desmos.com/calculator/nregtrj3t1 for more info")]
	private int _startingLevelScore;

	[SerializeField]
	[ChartFloat]
	[Range(0.1f, 100f)]
	[Tooltip("Larger values mean larger increases between levels (especially early levels), but also that the increase tapers faster. See https://www.desmos.com/calculator/nregtrj3t1 for more info")]
	private float _growthRate;

	[SerializeField]
	[ChartInt]
	[Range(1f, 500f)]
	[Tooltip("Offsets the logarithmic curve by shifting it to the left. Larger values means less dramatic changes on earlier levels. See https://www.desmos.com/calculator/nregtrj3t1 for more info")]
	private int _offset;

	[SerializeField]
	private bool _useDebugScore;

	[SerializeField]
	[Range(100f, 50000f)]
	private int _debugScore;

	private float E
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private float Offset
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Initialize()
	{
	}

	public int GetScoreObjective(int currentLevelNumber)
	{
		return default(int);
	}
}
