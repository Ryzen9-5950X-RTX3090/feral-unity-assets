public class WindowOpenedMessage : WindowMessage
{
	protected WindowOpenedMessage(string inTag, UI_Window inWindow)
	{
	}

	public static WindowOpenedMessage Create(string inTag, UI_Window inWindow)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
