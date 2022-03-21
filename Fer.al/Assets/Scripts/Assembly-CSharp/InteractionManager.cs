using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class InteractionManager : SingletonManagerBase<InteractionManager>
{
	private Interactable _currentInteractable;

	private List<Interactable> _currentInteractables;

	private Interactable _primaryInteractable;

	private List<FallbackInteraction> _fallbackInteractions;

	public Interactable CurrentInteractable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool CanInteract
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Interactable PrimaryInteractable
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public FallbackInteraction FallbackInteraction
	{
		get
		{
			return null;
		}
	}

	private void OnInteractableItemInRange(InteractableItemInRangeMessage inMessage)
	{
	}

	private void UpdatePrimaryInteractable()
	{
	}

	public override void MUpdate()
	{
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public void RegisterFallbackInteraction(FallbackInteraction inInteraction)
	{
	}

	public void UnregisterFallbackInteraction(FallbackInteraction inInteraction)
	{
	}

	public void RequestInteraction(Interactable.EInteractableMessage inInteractionType)
	{
	}

	private void StartInteraction()
	{
	}

	private void EndInteraction()
	{
	}

	public void DoInteraction(int inActionIndex)
	{
	}

	private void DoFallbackInteraction()
	{
	}

	private void SendInteractableInteractedMessage(Interactable inInteractable, Interactable.EInteractableMessage inInteractableMessage)
	{
	}

	internal void OnInteracted(Interactable inInteractable, Interactable.EInteractableMessage inInteractableMessage, InteractableState interactableState = InteractableState.Active, [Optional] string userUUID)
	{
	}

	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage)
	{
	}
}
