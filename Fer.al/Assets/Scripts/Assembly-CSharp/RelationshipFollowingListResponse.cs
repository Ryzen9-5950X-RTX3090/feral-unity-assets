using System.Collections.Generic;
using Server;

public class RelationshipFollowingListResponse : ServerMessage
{
	public readonly List<string> FollowedUUIDs;

	public readonly List<OnlineStatus> FollowedOnlineStatuses;

	public RelationshipFollowingListResponse(XtReader data)
	{
	}
}
