using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

[Serializable]
public class AvatarLookItemComponent : InfoItemComponent<ActorInfo>
{
	public enum Gender
	{
		Male,
		Female,
		Neutral
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SaveAndApply>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public AvatarLookItemComponent <>4__this;

		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1;

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
	private struct <SaveLookToSlot>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public AvatarLookItemComponent <>4__this;

		public AvatarLookItemComponent inTargetSlot;

		public string inSaveSlotName;

		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public Gender gender;

	public bool IsPrimaryLook
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsEmpty
	{
		get
		{
			return default(bool);
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[AsyncStateMachine(typeof(<SaveAndApply>d__9))]
	public UniTask SaveAndApply()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(<SaveLookToSlot>d__10))]
	public UniTask SaveLookToSlot(AvatarLookItemComponent inTargetSlot, string inSaveSlotName)
	{
		return default(UniTask);
	}
}
