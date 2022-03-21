using System.Runtime.CompilerServices;
using Server;

public class MinigameCurrencyResponseMessage : ServerMessage
{
	public int Currency
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

	public MinigameCurrencyResponseMessage(XtReader data)
	{
	}
}
