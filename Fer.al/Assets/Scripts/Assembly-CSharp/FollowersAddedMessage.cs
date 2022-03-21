using System.Collections.Generic;

public class FollowersAddedMessage : Message
{
	public readonly List<RelationshipManager.Follower> addedFollowers;

	public FollowersAddedMessage(List<RelationshipManager.Follower> inAddedFollowers)
	{
	}
}
