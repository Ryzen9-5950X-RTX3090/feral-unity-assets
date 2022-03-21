using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

public class UI_Window_Chat : UI_Window
{
	[Serializable]
	public class FixedPositionInfo
	{
		public string saveKey;

		public int anchorCornerIndex;

		public float defaultWidth;

		public bool allowWidthResize;

		public float defaultHeight;

		public bool allowHeightResize;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OpenConversation>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public string inUUID;

		private UniTask<ChatConversationData>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static bool isChatting;

	[SerializeField]
	private Graphic _opacityTarget;

	[SerializeField]
	private Transform _body;

	[SerializeField]
	private Transform _closeTarget;

	[SerializeField]
	private UI_ChatPanel_Room _publicChatPanel;

	[SerializeField]
	private UI_ChatPanel_Private _privateChatPanel;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	[SerializeField]
	private TMP_InputField _inputField;

	[SerializeField]
	private FeralButton _settingsToggle;

	[SerializeField]
	private List<UI_ChatPositionDragger> _positionDraggers;

	[SerializeField]
	private UI_ChatPanel_Conversations _conversationsPanel;

	[SerializeField]
	private FixedPositionInfo _selfieModeFixedPositionInfo;

	private bool _isFirstSetup;

	private bool _hasPlayedCloseAnimation;

	private FixedPositionInfo _currentFixedPositionInfo;

	[DebugButton("Open", "UI/Windows/Chat", true, false)]
	public static void OpenWindow([Optional] ChatConversationData inConversation)
	{
	}

	public static void QueueWindow([Optional] ChatConversationData inConversation)
	{
	}

	[DebugButton("Close", "UI/Windows/Chat", false, false)]
	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<OpenConversation>d__3))]
	public static UniTask OpenConversation(string inUUID)
	{
		return default(UniTask);
	}

	private void Setup([Optional] ChatConversationData inConversation)
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MOnEnable()
	{
	}

	private void SetMaxChatLength()
	{
	}

	public override void MOnDisable()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnOpenComplete()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnApplicationQuit()
	{
	}

	protected override void PlayOpenAnimation()
	{
	}

	protected override void PlayCloseAnimation()
	{
	}

	private void DeselectWindow()
	{
	}

	public void SelectInputField()
	{
	}

	[IteratorStateMachine(typeof(<MoveToEndOfLine>d__33))]
	private IEnumerator MoveToEndOfLine()
	{
		return null;
	}

	public void OnInputFieldSelected()
	{
	}

	public void OnInputFieldDeSelected()
	{
	}

	public void SetInputFieldActive()
	{
	}

	public void RecalculateLayouts()
	{
	}

	public void OpenConversation(ChatConversationData inConversation)
	{
	}

	private void OnTabSelected(int inTabIndex)
	{
	}

	private void OnSelect(string inChatText)
	{
	}

	private void OnDeSelect(string inChatText)
	{
	}

	private void OnSubmit(string inChatText)
	{
	}

	private void OnHideHUDCommand(HideHUDCommand inCommand)
	{
	}

	private void OnHUDWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnSelfieModeOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnSelfieModeClosed(WindowClosedMessage inMessage)
	{
	}

	private void ClampWindowPosition()
	{
	}

	private void SaveWindowSize()
	{
	}

	private void LoadWindowSize(bool inApply, out Vector3 size, out Vector3 pos)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void SetSelfieMode()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void SetNormalMode()
	{
	}

	public void SetOpacity(int inPercentage)
	{
	}

	public void SetTextSize(int inTextSize)
	{
	}

	public void SetFixedPositionInfo(FixedPositionInfo inInfo)
	{
	}
}
