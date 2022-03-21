using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Services.Chat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

public class UI_ActorBubble : UI_ScreenSpaceTransform
{
	public enum ChatBubbleState
	{
		Off,
		Chat,
		ChatEllipsis
	}

	public enum NamebarState
	{
		Off,
		Standard
	}

	public enum GroupTeamJoinState
	{
		Off,
		GroupTeamJoinButton
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnChatMessage>d__53 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public RoomConversationMessage inMessage;

		public UI_ActorBubble <>4__this;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[DebugField("Show Actor Bubbles", "UI", false, true)]
	public static bool actorBubblesEnabled;

	[SerializeField]
	[Header("Chat")]
	private RectTransform _chatBubbleTransform;

	[SerializeField]
	private RectTransform _normalChatBubbleGroup;

	[SerializeField]
	private WWTextMeshProUGUI _chatBubbleText;

	[SerializeField]
	private LayoutElement _chatBubbleLayoutElement;

	[SerializeField]
	private int _charsPerLine;

	[SerializeField]
	private int _maxLines;

	[SerializeField]
	private float _ellipseDistance;

	[SerializeField]
	private RectTransform _emojiBubbleTransform;

	[SerializeField]
	private WWTextMeshProUGUI _emojiBubbleText;

	[SerializeField]
	[Header("Party")]
	private Button _groupTeamJoinButton;

	[SerializeField]
	[Header("Namebar")]
	private FeralButton _namebar;

	[SerializeField]
	private WWTextMeshProUGUI _namebarText;

	[SerializeField]
	private Color _localColor;

	[SerializeField]
	private Color _networkColor;

	[SerializeField]
	private Color _npcColor;

	[SerializeField]
	private UI_XPIndicator _xpIndicator;

	private ActorBase _targetActor;

	private string _targetId;

	private float? _chatBubbleTimer;

	private ChatBubbleState _currentChatBubbleState;

	private List<string> _currentChats;

	private StringBuilder _chatStringBuilder;

	private string _partyQuestDefId;

	private NamebarState _currentNamebarState;

	private GroupTeamJoinState _currentGroupTeamJoinState;

	public ActorBase TargetActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string TargetId
	{
		get
		{
			return null;
		}
	}

	private ChatBubbleState CurrentChatBubbleState
	{
		get
		{
			return default(ChatBubbleState);
		}
		set
		{
		}
	}

	private NamebarState CurrentNamebarState
	{
		get
		{
			return default(NamebarState);
		}
		set
		{
		}
	}

	private GroupTeamJoinState CurrentGroupTeamJoinState
	{
		get
		{
			return default(GroupTeamJoinState);
		}
		set
		{
		}
	}

	public bool IsInChatBubbleState()
	{
		return default(bool);
	}

	public void ShowChatBubbleWithText(ChatEntry inChatEntry)
	{
	}

	public void SetChatText(ChatEntry inChatEntry)
	{
	}

	public void ShowChatBubble()
	{
	}

	public void HideChatBubble()
	{
	}

	public void ShowNamebar()
	{
	}

	public void HideNamebar()
	{
	}

	public void ShowGroupTeamJoinButton([Optional] string inQuestDefId)
	{
	}

	public void ShowQuestNameText()
	{
	}

	public void HideGroupTeamJoinButton()
	{
	}

	[AsyncStateMachine(typeof(<OnChatMessage>d__53))]
	private void OnChatMessage(RoomConversationMessage inMessage)
	{
	}

	private void OnOverheadBubbleMessage(OverheadBubbleMessage inMessage)
	{
	}

	private void OnButtonGroupTeamJoin()
	{
	}

	public void BtnClicked_Namebar()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<TestRoutine>d__59))]
	private IEnumerator TestRoutine()
	{
		return null;
	}

	public override void MUpdate()
	{
	}

	protected override void UpdateVisibilityAndAlpha()
	{
	}

	protected override void OnDistanceFromCameraChanged(float inDistance)
	{
	}
}
