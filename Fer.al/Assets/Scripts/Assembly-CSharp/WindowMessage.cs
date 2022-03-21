using System.Runtime.CompilerServices;

public abstract class WindowMessage : TaggedMessage
{
	public UI_Window Window
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

	protected WindowMessage(string inTag, UI_Window inWindow)
	{
	}

	protected void SetParams(string inTag, UI_Window inWindow)
	{
	}

	protected void ClearParams()
	{
	}
}
