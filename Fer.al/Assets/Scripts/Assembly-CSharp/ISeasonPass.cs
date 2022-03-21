using System;
using System.Collections.Generic;

public interface ISeasonPass
{
	bool HasPremium { get; }

	int AuraPoints { get; }

	string DefId { get; }

	string Uuid { get; }

	BaseDef PurchaseDef { get; }

	List<ISeasonPassTier> Tiers { get; }

	ISeasonPassTier CurrentTier { get; }

	List<ISeasonPassChallenge> Challenges { get; }

	List<ISeasonPassChallenge> AvailableChallenges { get; }

	string LocalizedName { get; }

	DateTime EndDate { get; }

	float NormalizedProgress { get; }

	void DeInit();
}
