using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_TradeItemQuantity : UI_Window
{
	[SerializeField]
	[Header("General")]
	private RawImage _iconImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[Header("Member")]
	private GameObject _memberGroup;

	[SerializeField]
	[Header("Rarity")]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Stackable")]
	private GameObject _ownedCountBadge;

	[SerializeField]
	private WWTextMeshProUGUI _ownedCount;

	[SerializeField]
	[Header("Controls")]
	private TMP_InputField _inputField;

	private Item _item;

	private int _itemQuantity;

	private int _chosenQuantity;

	private Action<int> OnResult;

	private int ChosenQuantity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static void OpenWindow(Item inItem, [Optional] Action<int> inOnResult)
	{
	}

	public static void QueueWindow(Item inItem, [Optional] Action<int> inOnResult)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(Item inItem, Action<int> inOnResult)
	{
	}

	public void BtnClicked_OK()
	{
	}

	public void BtnClicked_Increase()
	{
	}

	public void BtnClicked_Decrease()
	{
	}

	public void InputEnded_ChosenQuantity(string inValue)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	private void RefreshQuantity()
	{
	}
}
