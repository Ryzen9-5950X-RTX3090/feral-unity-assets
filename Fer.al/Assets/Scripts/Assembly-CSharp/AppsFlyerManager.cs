using System.Runtime.CompilerServices;

public class AppsFlyerManager : ManagedBehaviour
{
	public static bool appsFlyerEnabled;

	public static AppsFlyerManager instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public static void SendRegistrationEvent(string inUUID)
	{
	}

	public static void SetCurrencyCode(string currencyCode)
	{
	}

	public static void SendPurchaseEvent(string productId, string currencyCode, string localizedPrice)
	{
	}
}
