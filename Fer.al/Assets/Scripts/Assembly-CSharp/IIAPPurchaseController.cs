public interface IIAPPurchaseController
{
	void Setup(IAPItem[] inItems);

	void PurchaseItem(IAPItem inItem);
}
