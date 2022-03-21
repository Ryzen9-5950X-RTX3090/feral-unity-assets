using System;
using System.Collections.Generic;
using LitJson;

[Serializable]
public class GiftItemComponent : ItemComponent
{
	public ItemType giftItemType;

	public string giftItemDefId;

	public GiftFromType fromType;

	public int fromId;

	public int count;

	[NonSerialized]
	public bool isQueuedForRedemption;

	public Dictionary<string, string> redeemedItemIds;

	public bool IsRedeemed
	{
		get
		{
			return default(bool);
		}
	}

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}
}
