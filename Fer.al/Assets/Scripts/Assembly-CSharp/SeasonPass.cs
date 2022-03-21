using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class SeasonPass : ISeasonPass
{
	[CompilerGenerated]
	private readonly List<ISeasonPassTier> <Tiers>k__BackingField;

	[CompilerGenerated]
	private readonly List<ISeasonPassChallenge> <Challenges>k__BackingField;

	[CompilerGenerated]
	private readonly List<ISeasonPassChallenge> <AvailableChallenges>k__BackingField;

	private DateTime _endDate;

	private SeasonPassDefComponent _seasonPassDef;

	private string _uuid;

	private int _currentTierIndex;

	public bool HasPremium
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

	public int AuraPoints
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
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
		[CompilerGenerated]
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
		get
		{
			return default(DateTime);
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public SeasonPass(string inDefId, string uuid, int inCurrentTier, int inAuraPoints, bool inHasPremium, DateTime inEndDate)
	{
	}

	public void SetupChallenges(SeasonSrvHandler.ListChallengesResponse.ChallengeItem[] inCurrentChallenges, SeasonSrvHandler.ListChallengesResponse.ChallengeItem[] inCompletedChallenges)
	{
	}

	public void DeInit()
	{
	}

	private void AddListeners()
	{
	}

	private void RemoveListeners()
	{
	}

	private void OnChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage)
	{
	}

	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage)
	{
	}

	private void OnTierPurchased(SeasonPassTierPurchasedMessage inMessage)
	{
	}

	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage)
	{
	}

	private void OnAuraPointsReceived(int inAuraPoints)
	{
	}
}
