using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using WW.Debug;

public class GameSettingsManager : SingletonManagerBase<GameSettingsManager>
{
	public class HelpOverlaysSettingChangedMessage : Message
	{
		public readonly bool HelpOverlaysOn;

		public HelpOverlaysSettingChangedMessage(bool inHelpOverlaysOn)
		{
		}
	}

	public enum ControlSetting
	{
		Standard = 0,
		Simplified = 5,
		FirstPerson = 10
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <UpdatePrivacySettings>d__79 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public PrivacySetting.PrivacyLevel? voiceChatPrivacy;

		public GameSettingsManager <>4__this;

		private TaskAwaiter<WWWResponse<UserProfilePrivacyResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private CachedUserVar _helpOverlaysOnUserVar;

	private bool? _helpOverlaysOn;

	[SerializeField]
	private CachedUserVar _tooltipsOnUserVar;

	private bool? _tooltipsOn;

	[SerializeField]
	private CachedUserVar _chatBubblesOnUserVar;

	private bool? _chatBubblesOn;

	[SerializeField]
	private CachedUserVar _chatIsFilteredUserVar;

	private bool? _chatIsFiltered;

	[SerializeField]
	private CachedUserVar _controlModeUserVar;

	private ControlSetting? _controlMode;

	[SerializeField]
	private CachedUserVar _invertCameraUserVar;

	private bool? _invertCamera;

	[SerializeField]
	private CachedUserVar _cameraSensitivityUserVar;

	private float? _cameraSensitivity;

	private bool? _cameraFollowSetting;

	private bool? _cameraOrbitToggleModeSetting;

	[SerializeField]
	private CachedUserVar _isMotionBlurEnabledUserVar;

	private bool? _isMotionBlurEnabled;

	[SerializeField]
	private CachedUserVar _sanctuaryPrivacyUserVar;

	private PrivacySetting.PrivacyLevel? _sanctuaryPrivacy;

	[SerializeField]
	private CachedUserVar _tradingPrivacyUserVar;

	private PrivacySetting.PrivacyLevel? _tradingPrivacy;

	[SerializeField]
	private CachedUserVar _goToPlayerPrivacyUserVar;

	private PrivacySetting.PrivacyLevel? _goToPlayerPrivacy;

	private PrivacySetting.PrivacyLevel? _lastSetVoiceChatPrivacy;

	private PrivacySetting.PrivacyLevel? _voiceChatPrivacy;

	public bool HelpOverlaysOn
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool TooltipsOn
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool ChatBubblesOn
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugField("ChatIsFiltered", "Settings", false, false)]
	public bool ChatIsFiltered
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public ControlSetting ControlMode
	{
		get
		{
			return default(ControlSetting);
		}
		set
		{
		}
	}

	public ControlSetting? OverrideControlMode
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool InvertCamera
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public float CameraSensitivity
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool CameraFollowSetting
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool CameraOrbitToggleModeSetting
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool IsMotionBlurEnabled
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public PrivacySetting.PrivacyLevel SanctuaryPrivacy
	{
		get
		{
			return default(PrivacySetting.PrivacyLevel);
		}
		set
		{
		}
	}

	public PrivacySetting.PrivacyLevel TradingPrivacy
	{
		get
		{
			return default(PrivacySetting.PrivacyLevel);
		}
		set
		{
		}
	}

	public PrivacySetting.PrivacyLevel GoToPlayerPrivacy
	{
		get
		{
			return default(PrivacySetting.PrivacyLevel);
		}
		set
		{
		}
	}

	public PrivacySetting.PrivacyLevel VoiceChatPrivacy
	{
		get
		{
			return default(PrivacySetting.PrivacyLevel);
		}
		set
		{
		}
	}

	public void ParsePrivacyData(UserProfilePrivacyResponse inResponse)
	{
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	private void OnLoginComplete(LoginCompleteMessage inMessage)
	{
	}

	public void ApplySettings()
	{
	}

	[AsyncStateMachine(typeof(<UpdatePrivacySettings>d__79))]
	public void UpdatePrivacySettings(PrivacySetting.PrivacyLevel? voiceChatPrivacy)
	{
	}
}
