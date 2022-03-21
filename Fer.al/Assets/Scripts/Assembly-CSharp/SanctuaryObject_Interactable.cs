using UnityEngine;

public class SanctuaryObject_Interactable : Interactable
{
	private SanctuaryObjectBase _sanctuaryObjectBase;

	private Animator _animatorComponent;

	[SerializeField]
	[Tooltip("Sanctuary Interactable - Set animator controller on animator on Start - This will automatically play")]
	private RuntimeAnimatorController _runtimeAnimatorController;

	protected SanctuaryObjectBase sanctuaryObjectBase
	{
		get
		{
			return null;
		}
	}

	protected Animator animatorComponent
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public override void MOnEnable()
	{
	}

	public void SetState(ESanctuaryStateInteract inState)
	{
	}

	private void SetValidInteract()
	{
	}

	private void SetAnimatorController()
	{
	}

	public override void RequestInteraction(EInteractableMessage inInteractableMessage)
	{
	}
}
