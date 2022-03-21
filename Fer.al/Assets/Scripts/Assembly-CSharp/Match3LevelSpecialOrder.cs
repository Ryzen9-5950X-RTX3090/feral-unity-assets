using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Match3LevelSpecialOrder
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
	private int _regularLevelAppearancePercent;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _accessoriesAppearancePercent;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _eggsAppearancePercent;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _limitedMovesAppearancePercent;

	[ChartInt]
	[SerializeField]
	[Range(0f, 100f)]
	private int _comboAppearancePercent;

	private List<SpecialOrderType> _specialOrderTypes;

	public bool IsSpecialOrderTypesGenerated
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<SpecialOrderType> SpecialOrderTypes
	{
		get
		{
			return null;
		}
	}

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

	public float RegularLevelAppearanceWeight
	{
		get
		{
			return default(float);
		}
	}

	public float AccessoriesAppearanceWeight
	{
		get
		{
			return default(float);
		}
	}

	public float EggsAppearanceWeight
	{
		get
		{
			return default(float);
		}
	}

	public float LimitedMoveAppearanceWeight
	{
		get
		{
			return default(float);
		}
	}

	public float ComboAppearanceWeight
	{
		get
		{
			return default(float);
		}
	}

	public void Initialize()
	{
	}

	public bool IsLevelInRange(int levelNumber)
	{
		return default(bool);
	}

	public void GenerateSpecialOrderTypes()
	{
	}

	private List<SpecialOrderType> GetAvailableCombos()
	{
		return null;
	}

	private void Validate()
	{
	}
}
