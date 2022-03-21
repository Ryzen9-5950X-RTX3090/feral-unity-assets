using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_GameplayNotificationItem : MonoBehaviour
{
	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private RawImage _iconRawImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _countText;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private FeralAudioInfo _audioInfo;

	private Notification _notification;

	private bool _isFirstSetup;

	public Notification Notification
	{
		get
		{
			return null;
		}
	}

	public void Setup(Notification inNotification, UI_Window_GameplayNotifications inWindow)
	{
	}

	public void RefreshText(bool inAnimate)
	{
	}

	public void Show()
	{
	}

	public void Hide(Action inOnHideComplete)
	{
	}
}
