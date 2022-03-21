using System;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_NotificationLog : UI_LazyListItem<Notification>
{
	[SerializeField]
	private Rectangle _bgRectangle;

	[SerializeField]
	[Header("Message")]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	[Header("Online Status")]
	private UI_OnlineStatus _onlineStatus;

	[SerializeField]
	[Header("Image")]
	private GameObject _groupImage;

	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private RawImage _iconRawImage;

	[SerializeField]
	[Header("TimeStamp")]
	private WWTextMeshProUGUI _timeStampText;

	[SerializeField]
	private Color _readColor;

	[SerializeField]
	private Color _unreadColor;

	private UI_LazyItemList_NotificationLog _list;

	public override void Setup(Action<UI_LazyListItem<Notification>> inOnClicked, Action<UI_LazyListItem<Notification>> inOnSelected, Notification inData, UI_LazyItemList<Notification> inItemList)
	{
	}

	public override void Refresh()
	{
	}

	private void Setup()
	{
	}

	private void SetupUser()
	{
	}

	private void SetupImage()
	{
	}

	private void SetupText()
	{
	}

	private void SetupTimeStamp()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
