using TMPro;
using UnityEngine;

public class UI_PlayerStats : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _playerNameText;

	[SerializeField]
	private WWTextMeshProUGUI _currencyText;

	[SerializeField]
	private WWTextMeshProUGUI _levelNumText;

	[SerializeField]
	private UI_XPIndicator _xpIndicator;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RefreshName()
	{
	}

	private void OnLevelLoaded(Message inMessage)
	{
	}

	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage)
	{
	}
}
