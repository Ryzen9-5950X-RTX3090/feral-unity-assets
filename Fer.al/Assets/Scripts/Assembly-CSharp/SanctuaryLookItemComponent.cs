using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

[Serializable]
public class SanctuaryLookItemComponent : InfoItemComponent<SanctuaryInfo>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SaveLookToSlot>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public SanctuaryLookItemComponent <>4__this;

		public SanctuaryLookItemComponent inTargetSlot;

		public string inSaveSlotName;

		private TaskAwaiter<SanctuaryXtHandler.SanctuaryLookSaveResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[NonSerialized]
	private SanctuaryClassDefComponent _classDefComponent;

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

	public SanctuaryClassDefComponent ClassDefComponent
	{
		get
		{
			return null;
		}
	}

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}

	public void CopyOver(SanctuaryLookItemComponent otherItem)
	{
	}

	public HouseItemComponent GetHouseItem()
	{
		return null;
	}

	public IslandItemComponent GetIslandItem()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SaveLookToSlot>d__15))]
	public UniTask SaveLookToSlot(SanctuaryLookItemComponent inTargetSlot, string inSaveSlotName)
	{
		return default(UniTask);
	}
}
