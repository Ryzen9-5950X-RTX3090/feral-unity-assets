public class InteractableItemInRangeMessage : Message
{
	private bool _isInRange;

	private Interactable _target;

	public bool IsInRange
	{
		get
		{
			return default(bool);
		}
	}

	public Interactable Target
	{
		get
		{
			return null;
		}
	}

	private InteractableItemInRangeMessage(bool inIsInRange, Interactable inTarget)
	{
	}

	public static InteractableItemInRangeMessage Create(bool inIsInRange, Interactable inTarget)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
