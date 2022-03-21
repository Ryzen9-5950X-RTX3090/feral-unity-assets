using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UI_CustomizationLock : MonoBehaviour
{
	public UI_ButtonColorSet overideColorSet;

	[Header("Side Tab")]
	public GameObject lockIcon;

	[Header("Nav Link")]
	public Sprite lockIconInProject;

	private UI_ButtonColorSet _originalColorSet;

	private FeralButton _button;

	private WWImage _lockImage;

	private Action _showSelectedPageAction;

	private static UI_CustomizationLock _customizationLock;

	internal bool IsLocked
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage)
	{
	}

	internal void Setup(FeralButton inButton)
	{
	}

	internal void Setup(UI_GoToCustomizationPage inGoToCustomizationPage)
	{
	}

	private void SetupLockedButton(FeralButton inButton)
	{
	}

	internal void ShowSeasonPassPurchase(UI_CustomizationLock inCustomizationLock, Action inShowSelectedPageAction)
	{
	}

	internal void ResetColorSet(FeralButton inButton)
	{
	}
}
