using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

public abstract class ServerConnection
{
	public enum ConnectionState
	{
		None,
		Disconnecting,
		Connecting,
		Connected,
		LoggingIn,
		LoggedIn,
		Switching
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Disconnect>d__38 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ServerConnection <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public int RoomId;

	public ConnectionState State
	{
		[CompilerGenerated]
		get
		{
			return default(ConnectionState);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public virtual bool IsConnected
	{
		get
		{
			return default(bool);
		}
	}

	public virtual bool IsLoggedIn
	{
		get
		{
			return default(bool);
		}
	}

	public int UserId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string Cipher
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

	public string RemoteAddress
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

	public FeralServerEnvironment Environment
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

	public string RoomDefId
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

	public abstract void Init(FeralServerEnvironment environment);

	public abstract Task<bool> Connect(string remoteAddress);

	public abstract Task DisconnectAsync();

	public abstract Task<ServerLoginResponse> Login(string uuid, string loginToken, int sessionId);

	public abstract void Logout();

	public abstract void Switching();

	public abstract void ProcessEventQueue();

	public abstract void Send(INetMessageWriter data);

	[AsyncStateMachine(typeof(<Disconnect>d__38))]
	public virtual void Disconnect()
	{
	}
}
