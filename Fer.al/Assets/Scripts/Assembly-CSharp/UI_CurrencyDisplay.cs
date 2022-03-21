using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_CurrencyDisplay : MonoBehaviour
{
	public enum CurrencyDisplayType
	{
		LIKES,
		LOCKPICKS,
		STAR_FRAGMENTS
	}

	public CurrencyDisplayType currencyDisplayType;

	[SerializeField]
	private WWTextMeshProUGUI _currencyText;

	private int _lastCurrencyValue;

	private void Start()
	{
	}

	private void OnSceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode)
	{
	}

	private void OnInventoryChanged(InventoryItemChangedEvent inMessage)
	{
	}

	private void OnDestroy()
	{
	}

	private static bool ItemIsCurrency(Item i)
	{
		return default(bool);
	}

	private void OnInventoryItemsRemoved(InventoryItemRemovedEvent inMessage)
	{
	}

	private void OnCurrencyUpdated(InventoryListResponse inMessage)
	{
	}

	private void Reset()
	{
	}

	private int GetCurrentValue()
	{
		return default(int);
	}
}
