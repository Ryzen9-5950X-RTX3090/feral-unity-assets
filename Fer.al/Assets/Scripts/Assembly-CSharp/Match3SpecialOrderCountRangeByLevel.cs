using System;
using UnityEngine;

[Serializable]
public class Match3SpecialOrderCountRangeByLevel
{
	[ChartInt]
	[SerializeField]
	private int _fromLevelNumber;

	[ChartInt]
	[SerializeField]
	private int _toLevelNumber;

	[ChartBool]
	[SerializeField]
	private bool _isToLevelInfinite;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _minimumAccessoryCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _maximumAccessoryCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _minimumEggRowCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _maximumEggRowCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _minimumLimitedMovesOnlyCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _maximumLimitedMovesOnlyCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _minimumLimitedMovesComboCount;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _maximumLimitedMovesComboCount;

	public int FromLevelNumber
	{
		get
		{
			return default(int);
		}
	}

	public int? ToLevelNumber
	{
		get
		{
			return null;
		}
	}

	public bool IsToLevelInfinite
	{
		get
		{
			return default(bool);
		}
	}

	public int MinimumAccessoryCount
	{
		get
		{
			return default(int);
		}
	}

	public int MaximumAccessoryCount
	{
		get
		{
			return default(int);
		}
	}

	public int MinimumEggRowCount
	{
		get
		{
			return default(int);
		}
	}

	public int MaximumEggRowCount
	{
		get
		{
			return default(int);
		}
	}

	public int MinimumLimitedMovesOnlyCount
	{
		get
		{
			return default(int);
		}
	}

	public int MaximumLimitedMovesOnlyCount
	{
		get
		{
			return default(int);
		}
	}

	public int MinimumLimitedMovesComboCount
	{
		get
		{
			return default(int);
		}
	}

	public int MaximumLimitedMovesComboCount
	{
		get
		{
			return default(int);
		}
	}

	public void Initialize()
	{
	}

	public bool IsLevelInRange(int levelNumber)
	{
		return default(bool);
	}

	public int GetCountBySpecialOrderType(SpecialOrderType specialOrderType, bool isCombo)
	{
		return default(int);
	}

	private int GetRandomWeightedCount(string specialOrderTypeName, float minimumCount, float maximumCount, int countMultiplier, bool reverseWeightDirection)
	{
		return default(int);
	}

	private void Validate()
	{
	}
}
