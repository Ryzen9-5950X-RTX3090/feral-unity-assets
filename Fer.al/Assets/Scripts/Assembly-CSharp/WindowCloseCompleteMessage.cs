public class WindowCloseCompleteMessage : WindowMessage
{
	protected WindowCloseCompleteMessage(string inTag, UI_Window inWindow)
	{
	}

	public static WindowCloseCompleteMessage Create(string inTag, UI_Window inWindow)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
