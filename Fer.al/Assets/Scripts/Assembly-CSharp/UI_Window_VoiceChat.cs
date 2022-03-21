using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VivoxUnity;
using WW.Debug;

public class UI_Window_VoiceChat : UI_Window
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

	[SerializeField]
	private Transform _body;

	[SerializeField]
	private Transform _closeTarget;

	[SerializeField]
	private UI_VoiceChatMember _voiceChatMemberPrefab;

	[SerializeField]
	private Transform _voiceChatMemberParent;

	private List<string> _voiceChatMemberIds;

	private List<UI_VoiceChatMember> _voiceChatMembers;

	[SerializeField]
	private WWTextMeshProUGUI _labelVoiceChatEnableDisable;

	private bool _updateList;

	[SerializeField]
	private WWButton _btnCreateVoiceChatGroup;

	[SerializeField]
	private WWButton _btnLeaveVoiceChatGroup;

	[SerializeField]
	private WWButton _btnAddToChatGroup;

	[SerializeField]
	private GameObject _groupLonely;

	[SerializeField]
	private WWTextMeshProUGUI _labelPlayersInGroup;

	[SerializeField]
	private List<UI_ChatPositionDragger> _positionDraggers;

	private FixedPositionInfo _currentFixedPositionInfo;

	private bool _hasPlayedCloseAnimation;

	private readonly ObscuredString _saveAppendage;

	[DebugButton("Open", "UI/Windows/VoiceChat", true, false)]
	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	[DebugButton("Close", "UI/Windows/VoiceChat", false, false)]
	public static void CloseWindow()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDestroy()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void PlayOpenAnimation()
	{
	}

	protected override void OnOpenComplete()
	{
	}

	protected override void PlayCloseAnimation()
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

	public void SetFixedPositionInfo(FixedPositionInfo inInfo)
	{
	}

	private void OnHideHUDCommand(HideHUDCommand inCommand)
	{
	}

	private void OnParticipantAdded(ObscuredString username, ChannelId channel, IParticipant participant)
	{
	}

	private void OnParticipantRemove(ObscuredString username, ChannelId channel, IParticipant participant)
	{
	}

	public void BtnClicked_CreateVoiceChatGroup()
	{
	}

	public void BtnClicked_LeaveVoiceChatGroup()
	{
	}

	public void BtnClicked_AddToChatGroup()
	{
	}

	public override void MUpdate()
	{
	}

	private void UpdateVoiceChatList()
	{
	}

	private void RemoveMember(string inId)
	{
	}

	private void UpdatePlayerCountInGroup()
	{
	}
}
