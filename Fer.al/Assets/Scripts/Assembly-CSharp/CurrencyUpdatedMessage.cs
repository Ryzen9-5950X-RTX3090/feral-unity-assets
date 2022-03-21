public class CurrencyUpdatedMessage : Message
{
	public readonly int oldValue;

	public readonly int currentValue;

	public CurrencyUpdatedMessage(int inOldValue, int inCurrentValue)
	{
	}
}
