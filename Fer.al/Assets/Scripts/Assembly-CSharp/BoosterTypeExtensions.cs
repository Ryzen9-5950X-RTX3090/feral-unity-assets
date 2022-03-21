using System.Collections.Generic;

public static class BoosterTypeExtensions
{
	private static readonly IDictionary<BoosterUsageType, BoosterType[]> _boosterTypeLookup;

	private static readonly IDictionary<BoosterType, BoosterUsageType> _boosterTypeCategoryLookup;

	static BoosterTypeExtensions()
	{
	}

	public static BoosterType[] GetBoosterTypes(this BoosterUsageType boosterUsageType)
	{
		return null;
	}

	public static BoosterUsageType GetBoosterUsageType(this BoosterType boosterType)
	{
		return default(BoosterUsageType);
	}
}
