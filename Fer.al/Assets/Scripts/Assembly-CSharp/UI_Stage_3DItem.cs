using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DG.DeInspektor.Attributes;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

public class UI_Stage_3DItem : UI_Stage
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__32 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Stage_3DItem <>4__this;

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
	private struct <SetupWithDef>d__33 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Stage_3DItem <>4__this;

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
	private struct <SetItem>d__35 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_Stage_3DItem <>4__this;

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
	private struct <SetItemWithDef>d__36 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public BaseDef inDef;

		public UI_Stage_3DItem <>4__this;

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
	private struct <SpawnItem>d__39 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_Stage_3DItem <>4__this;

		private TaskAwaiter <>u__1;

		private UniTask.Awaiter <>u__2;

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
	private struct <SpawnAvatar>d__40 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_Stage_3DItem <>4__this;

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
	private struct <DespawnAvatar>d__41 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_Stage_3DItem <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static UI_Stage_3DItem instance;

	[SerializeField]
	private StageCameraSetting _cameraSetting_Default;

	[SerializeField]
	private Transform _spinTarget;

	[SerializeField]
	private Transform _itemParent;

	[SerializeField]
	private float _targetSpriteSize;

	[SerializeField]
	private SpriteRenderer _iconSprite;

	[SerializeField]
	private float _targetObjectDiameterMin;

	[SerializeField]
	private float _targetObjectDiameterMax;

	[SerializeField]
	private bool _anchorObjectToFloor;

	private Item _item;

	private GameObject _spawnedItem;

	private bool _isSpawningItem;

	private List<Renderer> _spawnedItemRenderers;

	private ColorableItemComponent _colorableItemComponent;

	private bool _isSpawningAvatar;

	private ActorBase _spawnedActor;

	private Item _previewedItem;

	private List<ActorInfoClothingItem> _itemsRemovedForPreview;

	private CancellationTokenSource _avatarCancellationSource;

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

	public List<Renderer> SpawnedItemRenderers
	{
		get
		{
			return null;
		}
	}

	public bool IsShowingAvatar
	{
		get
		{
			return default(bool);
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

	[AsyncStateMachine(typeof(<Setup>d__32))]
	public void Setup(Item inItem)
	{
	}

	[AsyncStateMachine(typeof(<SetupWithDef>d__33))]
	public void SetupWithDef(BaseDef inDef)
	{
	}

	protected virtual void SendInitializedMessage()
	{
	}

	[AsyncStateMachine(typeof(<SetItem>d__35))]
	public Task SetItem(Item inItem)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SetItemWithDef>d__36))]
	public Task SetItemWithDef(BaseDef inDef)
	{
		return null;
	}

	public override void RemoveScene(string inLevelDefId)
	{
	}

	public void SetColors(List<HSVColor> inTargetColors)
	{
	}

	[AsyncStateMachine(typeof(<SpawnItem>d__39))]
	private Task SpawnItem()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SpawnAvatar>d__40))]
	[DeMethodButton(null, 0, new object[] { })]
	public UniTask SpawnAvatar()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(<DespawnAvatar>d__41))]
	[DeMethodButton(null, 0, new object[] { })]
	public UniTask DespawnAvatar()
	{
		return default(UniTask);
	}

	protected override void Update()
	{
	}

	private void AddPreviewClothingItem()
	{
	}

	private void RemovePreviewClothingItem()
	{
	}
}
