using System;
using System.Collections.Generic;

[Serializable]
public class Trade
{
	public UserInfo targetUser;

	public UserInfo initiatedByUser;

	public bool isStarted;

	public List<Item> itemsToGive;

	public List<Item> itemsToReceive;

	public bool readyStatusMe;

	public bool readyStatusThem;

	public bool isConfirming;

	public bool? isAcceptedByMe;

	public bool? isAcceptedByThem;

	public string chatConversationId;
}
