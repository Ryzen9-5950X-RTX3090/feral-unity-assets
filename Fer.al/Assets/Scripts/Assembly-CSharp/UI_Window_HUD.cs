using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_HUD : UI_Window
{
	public class HUDButtonEnabler
	{
		public readonly FeralButton Button;

		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HUDButtonEnabler(FeralButton button, bool inEnabled = true)
		{
		}

		public void SetEnabled(bool inIsEnabled)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <UpdateAstralShopNewBadge>d__85 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_HUD <>4__this;

		private DateTime? <lastVisitTime>5__2;

		private TaskAwaiter<DateTime?> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BtnClicked_Sanctuary>d__99 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private TaskAwaiter<bool> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public WWTextMeshProUGUI textEmberCount;

	[SerializeField]
	private GameObject _groupButton0;

	[SerializeField]
	private WWImage _interactionIcon0;

	[SerializeField]
	private GameObject _groupButton1;

	[SerializeField]
	private WWImage _interactionIcon1;

	[SerializeField]
	private WWTextMeshProUGUI _labelLevelName;

	[SerializeField]
	private Canvas _minimapCanvas;

	[SerializeField]
	private Canvas _socialCanvas;

	[SerializeField]
	private Canvas _sanctuaryHUD;

	[SerializeField]
	private UI_TimeRemainingBadge _seasonPassNewBadge;

	[SerializeField]
	private UI_TimeRemainingBadge _astralShopNewBadge;

	[SerializeField]
	private GameObject _groupStandalone;

	[SerializeField]
	[Header("Buttons")]
	private FeralButton _customizationButton;

	[SerializeField]
	private FeralButton _inventoryButton;

	[SerializeField]
	private FeralButton _selfieCameraButton;

	[SerializeField]
	private FeralButton _sketchesButton;

	[SerializeField]
	private FeralButton _socialButton;

	[SerializeField]
	private FeralButton _notificationsButton;

	[SerializeField]
	private FeralButton _chatButton;

	[SerializeField]
	private FeralButton _voiceChatButton;

	[SerializeField]
	private FeralButton _iapShopBtn;

	[SerializeField]
	private FeralButton _worldMapBtn;

	[SerializeField]
	private FeralButton _sanctuaryBtn;

	[SerializeField]
	private FeralButton _seasonPassBtn;

	[SerializeField]
	private FeralButton _astralShopBtn;

	public HUDButtonEnabler CustomizationButtonEnabler
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

	public HUDButtonEnabler InventoryButtonEnabler
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

	public HUDButtonEnabler SelfieCameraButtonEnabler
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

	public HUDButtonEnabler SketchesButtonEnabler
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

	public HUDButtonEnabler SocialButtonEnabler
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

	public HUDButtonEnabler NotificationsButtonEnabler
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

	public HUDButtonEnabler ChatButtonEnabler
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

	public HUDButtonEnabler IAPButtonEnabler
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

	public HUDButtonEnabler WorldMapButtonEnabler
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

	public HUDButtonEnabler SanctuaryButtonEnabler
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

	public HUDButtonEnabler SeasonPassButtonEnabler
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

	public HUDButtonEnabler AstralShopButtonEnabler
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

	public HUDButtonEnabler VoiceChatButtonEnabler
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

	public override void MAwake()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateNewBadges([Optional] ContentVisitedMessage inMsg)
	{
	}

	private void UpdateSeasonPassNewBadge()
	{
	}

	[AsyncStateMachine(typeof(<UpdateAstralShopNewBadge>d__85))]
	private void UpdateAstralShopNewBadge()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public void OpenSettings()
	{
	}

	private void LateUpdate()
	{
	}

	public void BtnClicked_OpenChat()
	{
	}

	public void BtnClicked_OpenVoiceChat()
	{
	}

	public void BtnClicked_Settings()
	{
	}

	public void SetButtonActive(int inButtonId, bool inActive)
	{
	}

	public void SetButtonIcon(int inButtonId, string inImageDefId, bool inInteractButtonEnabled = true)
	{
	}

	private void OnHideHUDCommand(HideHUDCommand inCommand)
	{
	}

	public void BtnClicked_Customize()
	{
	}

	public void BtnClicked_Inventory()
	{
	}

	public void BtnClicked_ToggleEmoteWheel()
	{
	}

	public void BtnClicked_ToggleSelfieMode()
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_Sanctuary>d__99))]
	public void BtnClicked_Sanctuary()
	{
	}

	public void BtnClicked_SeasonPass()
	{
	}

	public void BtnClicked_AstraShop()
	{
	}

	public void BtnClicked_Inspirations()
	{
	}

	public void BtnClicked_Party()
	{
	}

	public void BtnClicked_Quests()
	{
	}

	public void BtnClicked_Notifications()
	{
	}

	public void BtnClicked_Group()
	{
	}

	public void BtnClicked_ToggleChat()
	{
	}

	public void BtnClicked_ToggleVoiceChat()
	{
	}

	public void BtnClicked_ToggleSocial()
	{
	}

	public void BtnClicked_HelpOverlay()
	{
	}

	public void BtnClicked_WorldMap()
	{
	}

	public void BtnClicked_IAPShop()
	{
	}

	public override void MOnDestroy()
	{
	}
}
