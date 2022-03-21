using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UniRx.Async;
using UnityEngine;

public class UI_Stage_Avatar : UI_Stage
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetCurrentLook>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<CreatureCustomizationTarget> <>t__builder;

		public UI_Stage_Avatar <>4__this;

		public bool inAnimate;

		public AvatarLookItemComponent inLook;

		private <>c__DisplayClass21_0 <>8__1;

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
	private struct <Setup>d__24 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ActorInfo inActorInfo;

		public UI_Stage_Avatar <>4__this;

		private TaskAwaiter<CreatureCustomizationTarget> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static UI_Stage_Avatar instance;

	[SerializeField]
	private GameObject _backupCamera;

	[SerializeField]
	private Transform _avatarParent;

	[SerializeField]
	private StageCameraSetting _cameraSetting_Detached;

	[SerializeField]
	private StageCameraSetting _cameraSetting_Default;

	[SerializeField]
	private StageCameraSetting _cameraSetting_Head;

	[SerializeField]
	private StageCameraSetting _cameraSetting_Tail;

	private CreatureCustomizationTarget _currentLook;

	public Action<CreatureCustomizationTarget> OnCurrentLookChanged;

	private UI_Stage_Avatar _previousInstance;

	public override Transform SpinTarget
	{
		get
		{
			return null;
		}
	}

	public override StageCameraSetting ActiveCameraSetting
	{
		get
		{
			return null;
		}
	}

	public CreatureCustomizationTarget CurrentLook
	{
		get
		{
			return null;
		}
	}

	public void ViewHead()
	{
	}

	public void ViewTail()
	{
	}

	public void ViewGeneral()
	{
	}

	public void ViewDetached()
	{
	}

	public override void RemoveScene(string inLevelDefId)
	{
	}

	[AsyncStateMachine(typeof(<SetCurrentLook>d__21))]
	public Task<CreatureCustomizationTarget> SetCurrentLook(AvatarLookItemComponent inLook, bool inAnimate = true)
	{
		return null;
	}

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__24))]
	public void Setup([Optional] ActorInfo inActorInfo)
	{
	}

	private void RefreshLookAtTargets(ActorBase inTargetActor)
	{
	}

	protected override void OnDestroy()
	{
	}
}
