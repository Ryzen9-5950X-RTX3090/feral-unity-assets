using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;
using VivoxUnity;

public class UI_VoiceChatMember : ManagedBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <CheckBlocked>d__18 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_VoiceChatMember <>4__this;

		private UniTask<bool>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private GameObject[] _muteIcons;

	[SerializeField]
	private WWButton _btnMuteRef;

	[SerializeField]
	private GameObject _talkingRef;

	[SerializeField]
	private WWTextMeshProUGUI _labelPlayerName;

	[SerializeField]
	private GameObject _localMute;

	[SerializeField]
	[Header("Unmuted ColorBlock")]
	private ColorBlock _unMutedColorBlock;

	[SerializeField]
	[Header("Muted ColorBlock")]
	private ColorBlock _mutedColorBlock;

	private ObscuredBool _blocked;

	private ObscuredBool _followed;

	public ObscuredString displayName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IParticipant participant
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Setup(IParticipant inParticipant)
	{
	}

	[AsyncStateMachine(typeof(<CheckBlocked>d__18))]
	private void CheckBlocked()
	{
	}

	private void CheckFollowed()
	{
	}

	private void OnSpeechDetectedEvent(ObscuredString username, ChannelId channel, ObscuredBool speechDetected)
	{
	}

	public void BtnClicked_MuteMember()
	{
	}

	private void OnMute(ObscuredString inUserName)
	{
	}

	private void UpdateMuteColor(bool inMuted)
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}
}
