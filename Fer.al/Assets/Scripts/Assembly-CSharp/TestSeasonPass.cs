using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class TestSeasonPass : ISeasonPass
{
	[CompilerGenerated]
	private readonly bool <HasPremium>k__BackingField;

	[CompilerGenerated]
	private readonly List<ISeasonPassTier> <Tiers>k__BackingField;

	[CompilerGenerated]
	private readonly List<ISeasonPassChallenge> <Challenges>k__BackingField;

	[CompilerGenerated]
	private readonly DateTime <EndDate>k__BackingField;

	[CompilerGenerated]
	private readonly int <TotalRequiredAuraPoints>k__BackingField;

	public bool HasPremium
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	public int AuraPoints
	{
		get
		{
			return default(int);
		}
	}

	public string DefId
	{
		get
		{
			return null;
		}
	}

	public string Uuid
	{
		get
		{
			return null;
		}
	}

	public BaseDef PurchaseDef
	{
		get
		{
			return null;
		}
	}

	public List<ISeasonPassTier> Tiers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public ISeasonPassTier CurrentTier
	{
		get
		{
			return null;
		}
	}

	public List<ISeasonPassChallenge> Challenges
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public List<ISeasonPassChallenge> AvailableChallenges
	{
		get
		{
			return null;
		}
	}

	public string LocalizedName
	{
		get
		{
			return null;
		}
	}

	public DateTime EndDate
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	public int TotalRequiredAuraPoints
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public int Progress
	{
		get
		{
			return default(int);
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public void DeInit()
	{
	}
}
