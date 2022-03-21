using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;

public class UI_Window_MultiItemPopup : UI_Window, IItemPopupStylable
{
	[SerializeField]
	private Rectangle _bodyRectangle;

	[SerializeField]
	private UIShiny _shinyEffect;

	[SerializeField]
	private WWTextMeshProUGUI _titleText;

	[SerializeField]
	private Transform _itemParent;

	[SerializeField]
	private UI_MultiItemPopupListItem _itemPrefab;

	[SerializeField]
	private RectTransform _body;

	[SerializeField]
	private int _largeBodyItemCount;

	[SerializeField]
	private float _smallBodyHeight;

	[SerializeField]
	private float _largeBodyHeight;

	[SerializeField]
	private GameObject _btnBotRight;

	[SerializeField]
	private WWTextMeshProUGUI _btnBotRightText;

	private Action _buttonBotRightCallback;

	[SerializeField]
	[Header("Styles")]
	private List<ItemPopupStyleData> _styleData;

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

	public static void OpenWindow(BundlePackDefComponent inBundlePack, ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public static void OpenWindow(List<ValueTuple<BaseDef, int>> inItems, string inTitle = "", ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public static void QueueWindow(BundlePackDefComponent inBundlePack, ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public static void QueueWindow(List<ValueTuple<BaseDef, int>> inItems, string inTitle = "", ItemPopupStyle inStyle = ItemPopupStyle.Normal)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(List<ValueTuple<BaseDef, int>> inItems, string inTitle, ItemPopupStyle inStyle)
	{
	}

	public void SetupBotRightBtn(Action inCallback, string inText)
	{
	}

	public void BtnClicked_BotRight()
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
