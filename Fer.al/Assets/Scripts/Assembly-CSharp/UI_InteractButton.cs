using UnityEngine;
using UnityEngine.UI;

public class UI_InteractButton : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Sprite _unknownInteractionSprite;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void DownloadAndAssign(string inImageDefId)
	{
	}

	private void OnPrimaryInteractableUpdated(PrimaryInteractableUpdatedMessage inMessage)
	{
	}

	private void OnFallbackInteractableUpdated(FallbackInteractionChangedMessage inMessage)
	{
	}

	private void HideButton()
	{
	}

	private void Refresh(Interactable inPrimaryInteractable, FallbackInteraction inFallbackInteraction)
	{
	}
}
