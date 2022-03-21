using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Window_SystemNotifications : UI_Window, IDragHandler, IEventSystemHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <ShowNextNotification>d__24 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_SystemNotifications <>4__this;

		public bool inForceSlideUp;

		private bool <hasNextNotification>5__2;

		private bool <isShowingPreviousNotification>5__3;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Header("Config")]
	private float _notificationDisplayTime;

	[SerializeField]
	private float _dismissalDragThreshold;

	[SerializeField]
	[Header("Content")]
	private RectTransform _panelTransform;

	[SerializeField]
	private CanvasGroup _contentCanvasGroup;

	[SerializeField]
	private GameObject _iconGroup;

	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private RawImage _iconRawImage;

	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	private UI_OnlineStatus _onlineStatus;

	private List<Notification> _notificationQueue;

	private Notification _notification;

	private float _notificationTimer;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	public void BtnClicked_OpenNotification()
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	private void AddNotification(Notification inNotification)
	{
	}

	private void ShowNotification(Notification inNotification, bool inSlideIn)
	{
	}

	private void SetupImage()
	{
	}

	private void SetupUserStatus()
	{
	}

	private void SetupText()
	{
	}

	[AsyncStateMachine(typeof(<ShowNextNotification>d__24))]
	private void ShowNextNotification(bool inForceSlideUp = false)
	{
	}

	public override void MUpdate()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnNotificationWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	public override void MOnDestroy()
	{
	}
}
