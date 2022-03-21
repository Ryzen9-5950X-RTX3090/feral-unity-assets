using System.Runtime.CompilerServices;
using Server;

[RoutedMessage(XtCmd.ShopList, QueueMessageMode.Never)]
public class ShopListResponse : ServerMessage
{
	public int ShopDefId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string[] ShopItemIds
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

	public ShopListResponse(INetMessageReader data)
	{
	}
}
