public class PurchasedItemInfo : InventoryItemInfo
{
	public int cost;

	public CurrencyType currency
	{
		get
		{
			return default(CurrencyType);
		}
	}
}
