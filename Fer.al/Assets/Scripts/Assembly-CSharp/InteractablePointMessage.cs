public class InteractablePointMessage : Message
{
	public readonly Avatar_Local localAvatar;

	public readonly Interactable interactablePoint;

	public readonly bool doInteract;

	public InteractablePointMessage(Interactable inInteractablePoint, Avatar_Local inLocalAvatar, bool inDoInteract)
	{
	}
}
