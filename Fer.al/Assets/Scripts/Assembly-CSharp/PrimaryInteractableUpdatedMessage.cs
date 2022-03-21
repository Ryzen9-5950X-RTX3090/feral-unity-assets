public class PrimaryInteractableUpdatedMessage : Message
{
	public readonly Interactable PrevInteractable;

	public readonly Interactable CurrentInteractable;

	public PrimaryInteractableUpdatedMessage(Interactable inPrevInteractable, Interactable inCurrentInteractable)
	{
	}
}
