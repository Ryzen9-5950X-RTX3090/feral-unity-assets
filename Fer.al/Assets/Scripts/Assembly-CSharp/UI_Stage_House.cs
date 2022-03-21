using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class UI_Stage_House : UI_Stage
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__25 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public Item inItem;

		public UI_Stage_House <>4__this;

		private TaskAwaiter <>u__1;

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
	private struct <SetupWithDef>d__26 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Stage_House <>4__this;

		public BaseDef inDef;

		private TaskAwaiter <>u__1;

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
	private struct <SetItem>d__28 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_Stage_House <>4__this;

		public Item inItem;

		private TaskAwaiter <>u__1;

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
	private struct <SetItemWithDef>d__29 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public BaseDef inDef;

		public UI_Stage_House <>4__this;

		private TaskAwaiter <>u__1;

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
	private struct <SpawnItem>d__31 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_Stage_House <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static UI_Stage_House instance;

	[SerializeField]
	private StageCameraSetting _cameraSetting_Default;

	[SerializeField]
	private Transform _spinTarget;

	[SerializeField]
	private Transform _itemParent;

	[SerializeField]
	private float _houseScale;

	public Action<SanctuaryLookItemComponent> OnCurrentHouseChanged;

	private Item _item;

	private SanctuaryLookItemComponent _sanctuaryLook;

	private List<GameObject> _spawnedItemObjects;

	private Renderer _spawnedItemRenderer;

	public override StageCameraSetting ActiveCameraSetting
	{
		get
		{
			return null;
		}
	}

	public override Transform SpinTarget
	{
		get
		{
			return null;
		}
	}

	public Item Item
	{
		get
		{
			return null;
		}
	}

	public HouseItemComponent HouseItemComponent
	{
		get
		{
			return null;
		}
	}

	public SanctuaryLookItemComponent SanctuaryLook
	{
		get
		{
			return null;
		}
	}

	public Renderer SpawnedItemRenderer
	{
		get
		{
			return null;
		}
	}

	protected override void Start()
	{
	}

	protected virtual void SendLoadedMessage()
	{
	}

	protected override void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__25))]
	public void Setup([Optional] Item inItem)
	{
	}

	[AsyncStateMachine(typeof(<SetupWithDef>d__26))]
	public void SetupWithDef(BaseDef inDef)
	{
	}

	protected virtual void SendInitializedMessage()
	{
	}

	[AsyncStateMachine(typeof(<SetItem>d__28))]
	public Task SetItem(Item inItem)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SetItemWithDef>d__29))]
	public Task SetItemWithDef(BaseDef inDef)
	{
		return null;
	}

	public override void RemoveScene(string inLevelDefId)
	{
	}

	[AsyncStateMachine(typeof(<SpawnItem>d__31))]
	private Task SpawnItem()
	{
		return null;
	}
}
