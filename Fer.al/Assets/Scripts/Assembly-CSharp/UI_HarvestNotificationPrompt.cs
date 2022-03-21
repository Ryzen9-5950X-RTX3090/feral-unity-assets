using TMPro;
using UnityEngine;

public class UI_HarvestNotificationPrompt : MonoBehaviour
{
	[SerializeField]
	private Transform _scaleGroup;

	[SerializeField]
	private WWTextMeshProUGUI _numberText;

	private Vector3 _targetWorldPosition;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnInteractableHarvested(InteractableHarvestedMessage inMessage)
	{
	}

	private void Show(Vector3 inTargetWorldPosition, int inQuantity)
	{
	}

	private void DoStretchSquash(float inTotalScale, float inYScale)
	{
	}
}
