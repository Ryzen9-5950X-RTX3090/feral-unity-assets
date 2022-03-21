public class DenStateUpdateRequestedMessage : Message
{
	public readonly UpdateItem[] itemsToUpdate;

	public readonly RemoveItem[] itemsToRemove;

	public DenStateUpdateRequestedMessage(UpdateItem[] itemsToUpdate, RemoveItem[] itemsToRemove)
	{
	}
}
