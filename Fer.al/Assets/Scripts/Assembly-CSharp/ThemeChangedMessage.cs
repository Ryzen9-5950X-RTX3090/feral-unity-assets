using System.Runtime.CompilerServices;

public class ThemeChangedMessage : Message
{
	public UI_Theme CurrentTheme
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

	public ThemeChangedMessage(UI_Theme inCurrentTheme)
	{
	}
}
