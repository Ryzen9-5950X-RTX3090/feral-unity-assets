using LitJson;

public class IAPItem
{
	public string uuid;

	public string platformProductId;

	public string title;

	public string shortDescription;

	public string longDescription;

	public string imageURL;

	public string priceText;

	public bool isConsumable;

	public bool hasBeenPurchased;

	public string defId;

	private BaseDef _def;

	public IAPItemReward[] rewards;

	public BaseDef Def
	{
		get
		{
			return null;
		}
	}

	public bool IsBundlePack
	{
		get
		{
			return default(bool);
		}
	}

	public IAPItem(JsonData jsonData)
	{
	}
}
