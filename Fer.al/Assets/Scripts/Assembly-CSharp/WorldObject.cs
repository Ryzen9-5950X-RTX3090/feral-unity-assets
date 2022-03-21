using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UniRx.Async;

[ManagedBehaviourManager("WorldObjectManager")]
public class WorldObject : ManagedBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <WaitForUserInfo>d__20 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string OwnerId;

		public WorldObject <>4__this;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	internal string Id;

	protected int? _initialRoomIDAtInstantiation;

	private bool _subscribed;

	private bool _deleted;

	public UserInfo User
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool HasBeenActive
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

	public bool InInitialRoomID
	{
		get
		{
			return default(bool);
		}
	}

	public override void MStart()
	{
	}

	public virtual void OnObjectInfo(WorldObjectInfoMessage inInfoMessage)
	{
	}

	public virtual void Unsubscribe()
	{
	}

	protected bool DestroyIfNotInInitialRoomID()
	{
		return default(bool);
	}

	public override void UpdateInternal()
	{
	}

	public override void MOnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<WaitForUserInfo>d__20))]
	public void WaitForUserInfo(string OwnerId)
	{
	}

	public virtual void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation)
	{
	}

	public virtual void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation, [Optional] string inUniqueMapId, [Optional] string userToGoToId)
	{
	}

	public void Teleport(ObscuredVector3 inPosition, ObscuredVector3 inDestination, float inSpeed = 5f)
	{
	}

	protected virtual void OnMoveMessage(WorldObjectMoveMessage inMessage)
	{
	}

	protected virtual void OnActionMessage(WorldObjectActionMessage inMessage)
	{
	}

	protected virtual void OnDeleteMessage(WorldObjectDeleteMessage inMessage)
	{
	}

	private void Delete()
	{
	}

	protected virtual void OnBroadcastMessage(WorldObjectBroadcastMessage inMessage)
	{
	}
}
