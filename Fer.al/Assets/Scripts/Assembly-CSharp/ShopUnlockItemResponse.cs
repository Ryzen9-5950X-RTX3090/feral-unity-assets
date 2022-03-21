using System.Runtime.CompilerServices;
using Server;

[RoutedMessage(XtCmd.ShopUnlockItem, QueueMessageMode.Never)]
public class ShopUnlockItemResponse : ServerMessage, ISuccessMessage
{
	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string ShopId
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

	public string[] ItemsUnlocked
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

	public ShopUnlockItemResponse(INetMessageReader data)
	{
	}

	[MessageRoute(XtCmd.ShopUnlockItem, QueueMessageMode.Never)]
	public static void HandleShopUnlockItemResponse(ShopUnlockItemResponse response)
	{
	}
}
