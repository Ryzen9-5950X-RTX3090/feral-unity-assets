public class WindowHiddenMessage : WindowMessage
{
	protected WindowHiddenMessage(string inTag, UI_Window inWindow)
	{
	}

	public static WindowHiddenMessage Create(string inTag, UI_Window inWindow)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
