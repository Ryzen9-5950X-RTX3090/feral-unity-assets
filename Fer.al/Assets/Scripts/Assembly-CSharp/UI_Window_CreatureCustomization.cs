using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_CreatureCustomization : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnClose>d__58 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_CreatureCustomization <>4__this;

		private <>c__DisplayClass58_0 <>8__1;

		public bool inAnimate;

		private UniTask.Awaiter <>u__1;

		private TaskAwaiter<TutorialCompleteResponse> <>u__2;

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
	private struct <OnShow>d__60 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_CreatureCustomization <>4__this;

		private TaskAwaiter<CreatureCustomizationTarget> <>u__1;

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
	private struct <SaveChanges>d__68 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_CreatureCustomization <>4__this;

		public bool inForceSave;

		private UniTask.Awaiter <>u__1;

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
	private struct <OnCurrentLookChanged>d__74 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_CreatureCustomization <>4__this;

		public CreatureCustomizationTarget inInfo;

		private TaskAwaiter<AvatarLookSwitchResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private CanvasGroup _mainCanvasGroup;

	[SerializeField]
	private UI_TabGroup _sidebarTabGroup;

	[SerializeField]
	private UI_CustomizationPageNavigationController _navigationController;

	[SerializeField]
	private List<UI_CustomizationPageInfo> _rootPageInfos;

	private bool _ignoreNextTabClick;

	[SerializeField]
	private UI_AvatarPositioner _avatarPositioner;

	[SerializeField]
	private FeralButton _clothingTabButton;

	[SerializeField]
	private FeralButton _looksTabBtn;

	[SerializeField]
	private FeralButton _saveLookButton;

	[SerializeField]
	private FeralButton _switchAvatarTabButton;

	[SerializeField]
	private FeralButton _clothingShopButton;

	[SerializeField]
	private TMP_InputField _nameInputField;

	[SerializeField]
	private TextMeshProUGUI _classNameText;

	[SerializeField]
	private List<GameObject> _designerOnlyObjects;

	[SerializeField]
	private List<GameObject> _userOnlyObjects;

	[SerializeField]
	[DeComment("Designer Mode Only", 3)]
	private GameObject _clothingColorControl;

	private UI_Stage_Avatar _avatarStage;

	private bool _stageInitializationReceived;

	private ActorInfo _lastSavedActorInfo;

	private string _lastSavedName;

	private float _timeLastSaved;

	private float _autoSaveInterval;

	private ActorInfo _infoToDisplay;

	private bool _isDesignerMode;

	private string _designerDefID;

	private int _currentDecalCount;

	private int _maxDecals;

	public Action<ActorInfoClothingItem> OnDesignerEditClothingTargetChanged;

	private ActorInfoClothingItem _designerEditClothingTarget;

	public Action<int> OnDecalCountChanged;

	public UI_AvatarPositioner AvatarPositioner
	{
		get
		{
			return null;
		}
	}

	public ActorInfo InfoToDisplay
	{
		get
		{
			return null;
		}
	}

	public bool IsDesignerMode
	{
		get
		{
			return default(bool);
		}
	}

	public string DesignerDefID
	{
		get
		{
			return null;
		}
	}

	public int CurrentDecalCount
	{
		get
		{
			return default(int);
		}
		private set
		{
		}
	}

	public int MaxDecals
	{
		get
		{
			return default(int);
		}
	}

	public bool MaxDecalsExceeded
	{
		get
		{
			return default(bool);
		}
	}

	public bool MaxDecalsMet
	{
		get
		{
			return default(bool);
		}
	}

	public ActorInfoClothingItem DesignerEditClothingTarget
	{
		get
		{
			return null;
		}
		set
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

	public void Setup()
	{
	}

	public void SetupForDesigner(BaseDef inDef)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnOpenComplete()
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	[AsyncStateMachine(typeof(<OnClose>d__58))]
	protected override void OnClose(bool inAnimate)
	{
	}

	protected override void OnHide()
	{
	}

	[AsyncStateMachine(typeof(<OnShow>d__60))]
	protected override void OnShow()
	{
	}

	public override void OnReceiveFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	[IteratorStateMachine(typeof(<TakeScreenshot>d__65))]
	public IEnumerator TakeScreenshot()
	{
		return null;
	}

	public void BtnToggle_EditName(bool inIsHighlighted)
	{
	}

	public void BtnClicked_SaveLook()
	{
	}

	[AsyncStateMachine(typeof(<SaveChanges>d__68))]
	public void SaveChanges(bool inForceSave = false)
	{
	}

	public void RefreshLastSavedLook()
	{
	}

	public void RefreshDecalCount()
	{
	}

	public bool HasChanges()
	{
		return default(bool);
	}

	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage)
	{
	}

	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnCurrentLookChanged>d__74))]
	private void OnCurrentLookChanged(CreatureCustomizationTarget inInfo)
	{
	}

	private void OnSectionSelected(int inTabIndex)
	{
	}

	private void OnPageNavigation(UI_CustomizationPageInfo inPageInfo)
	{
	}

	public void OnNameValueChanged(string inName)
	{
	}

	private void TryCloseWindow()
	{
	}
}
