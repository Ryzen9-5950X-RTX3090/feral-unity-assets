using System;
using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;

public class UI_UnreadCount : MonoBehaviour
{
	public enum UnreadItemType
	{
		AllChest = 0,
		Ingredient = 5,
		Dye = 10,
		Clothing = 15,
		Charm = 20,
		Furniture = 25,
		Enigma = 30,
		AllBodyPart = 200,
		BodyPart_Body = 205,
		BodyPart_Ears = 210,
		BodyPart_Head = 215,
		BodyPart_Horn = 220,
		BodyPart_Legs = 225,
		BodyPart_Tail = 235,
		BodyPart_Wings = 240
	}

	[SerializeField]
	private bool _autoSetup;

	[SerializeField]
	[DeComment("Must only match a single item type not all of them", 3)]
	private List<UnreadItemType> _itemTypes;

	[SerializeField]
	private WWTextMeshProUGUI _unreadCountText;

	private List<Item> _unreadItems;

	private int _extraUnreadCount;

	private bool _isSetup;

	public Action OnPostSetup;

	public bool IsSetup
	{
		get
		{
			return default(bool);
		}
	}

	public void Setup(List<UnreadItemType> inItemTypes, int inExtraUnreadCount = 0)
	{
	}

	public void AddToUnreadCount()
	{
	}

	public void RemoveFromUnreadCount()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnItemUnread(ItemUnreadMessage inMessage)
	{
	}

	private void OnItemRead(ItemReadMessage inMessage)
	{
	}

	private bool ItemMatchesType(Item inItem)
	{
		return default(bool);
	}

	private bool ItemMatchesType(Item inItem, UnreadItemType inType)
	{
		return default(bool);
	}

	private bool ItemMatchesBodyPartType(Item inItem, UnreadItemType inType)
	{
		return default(bool);
	}

	private void RefreshText()
	{
	}
}
