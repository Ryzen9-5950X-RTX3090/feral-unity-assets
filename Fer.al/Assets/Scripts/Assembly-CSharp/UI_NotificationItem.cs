using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_NotificationItem : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	private Notification _notification;

	private Action<RectTransform> _onSelectedAction;

	private Selectable _selectable;

	public string Message
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Notification Notification
	{
		get
		{
			return null;
		}
	}

	public Selectable Selectable
	{
		get
		{
			return null;
		}
	}

	public void Setup(Notification inNotification, Action<RectTransform> inSelectedAction)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}
}
