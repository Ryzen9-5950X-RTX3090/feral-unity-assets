public class SanctuaryStateChangeMessage : Message
{
	public readonly SanctuaryController.EState state;

	public SanctuaryStateChangeMessage(SanctuaryController.EState inState)
	{
	}
}
