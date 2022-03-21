using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Coffee.UIExtensions;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ItemPopup : UI_Window, IItemPopupStylable
{
	[SerializeField]
	[Header("Body FX")]
	private Rectangle _bodyRectangle;

	[SerializeField]
	private UIShiny _shinyEffect;

	[SerializeField]
	[Header("Styles")]
	private List<ItemPopupStyleData> _styleData;

	[SerializeField]
	[Header("Text Content")]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private WWTextMeshProUGUI _messageTitleText;

	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	[Header("Buttons")]
	private GameObject _btnB;

	[SerializeField]
	private GameObject _btnBotRight;

	[SerializeField]
	private WWTextMeshProUGUI _btnAText;

	[SerializeField]
	private WWTextMeshProUGUI _btnBText;

	[SerializeField]
	private WWTextMeshProUGUI _btnBotRightText;

	[SerializeField]
	[Header("Item Content")]
	private RawImage _iconImage;

	[SerializeField]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	private FeralButton _btnInfo;

	private BaseDef _craftableItem;

	private Action _buttonACallback;

	private Action _buttonBCallback;

	private Action _buttonBotRightCallback;

	[EnumFlag]
	public ItemPopupStyle test;

	public Rectangle BodyRectangle
	{
		get
		{
			return null;
		}
	}

	public UIShiny ShinyEffect
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow(string inHeader = "", string inBtnAText = "", [Optional] BaseDef inCraftableItem, int inQuantity = 1, [Optional] Action inButtonACallback, string inBtnBText = "", [Optional] Action inButtonBCallback, ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public static void QueueWindow(string inHeader = "", string inBtnAText = "", [Optional] BaseDef inCraftableItem, int inQuantity = 1, [Optional] Action inButtonACallback, string inBtnBText = "", [Optional] Action inButtonBCallback, ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(string inHeader = "", string inBtnAText = "", [Optional] BaseDef inCraftableItem, int inQuantity = 1, [Optional] Action inButtonACallback, string inBtnBText = "", [Optional] Action inButtonBCallback, ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public void SetupBotRightBtn(Action inCallback, string inText)
	{
	}

	public void BtnClicked_A()
	{
	}

	public void BtnClicked_B()
	{
	}

	public void BtnClicked_BotRight()
	{
	}

	public void BtnClicked_Info()
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
}
