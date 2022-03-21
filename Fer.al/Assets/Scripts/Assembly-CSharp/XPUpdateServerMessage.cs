using System.Collections.Generic;
using Server;

[RoutedMessage(XtCmd.XPUpdate, QueueMessageMode.Never)]
public class XPUpdateServerMessage : ServerMessage
{
	public class CompletedLevel
	{
		public readonly int level;

		public readonly int requiredXP;

		public readonly Reward reward;

		public CompletedLevel(int level, int requiredXP, Reward reward)
		{
		}

		public CompletedLevel(INetMessageReader data)
		{
		}
	}

	public class Reward
	{
		public readonly int rewardItemDefId;

		public readonly int rewardQuantity;

		public readonly string rewardItemId;

		public Reward(int rewardItemDefId, int rewardQuantity, string rewardItemId)
		{
		}

		public static Reward createFromData(INetMessageReader data)
		{
			return null;
		}
	}

	public class CurrentLevel
	{
		public readonly int level;

		public readonly int xp;

		public readonly int requiredXP;

		public CurrentLevel(int currentLevel, int currentXP, int currentRequiredXP)
		{
		}

		public static CurrentLevel createFromData(INetMessageReader data)
		{
			return null;
		}
	}

	public class PreviousLevel : CurrentLevel
	{
		public PreviousLevel(int previousLevel, int previousXP, int previousRequiredXP)
		{
		}

		public new static PreviousLevel createFromData(INetMessageReader data)
		{
			return null;
		}
	}

	public readonly string userUUID;

	public readonly int totalXP;

	public readonly int gainedXP;

	public readonly CurrentLevel currentLevel;

	public readonly PreviousLevel previousLevel;

	public readonly List<CompletedLevel> completedLevels;

	public XPUpdateServerMessage(INetMessageReader data)
	{
	}
}
