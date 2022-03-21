using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class CoreMessageManager : CoreManagerBase<CoreMessageManager>
{
	public class RegisteredListener
	{
		public string eventID;

		public string tag;

		public MethodInfo method;

		public object target;

		private string _registeredMethodName;

		private string _registeredGameObjectName;

		private int _registeredGameObjectInstanceID;

		private string _taggedEventName;

		private static object[] _invokeArgs;

		public string RegisteredMethodName
		{
			get
			{
				return null;
			}
		}

		public string RegisteredGameObjectName
		{
			get
			{
				return null;
			}
		}

		public int RegisteredGameObjectInstanceID
		{
			get
			{
				return default(int);
			}
		}

		public string TaggedEventName
		{
			get
			{
				return null;
			}
		}

		public RegisteredListener(string inEventID, string inTag, MethodInfo inMethod, object inTarget, string inMethodName, string inGameObjectName, int inTargetInstanceID)
		{
		}

		public void Invoke(IMessage inMessage)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <AwaitMessage>d__57<T> : IAsyncStateMachine where T : IMessage
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

		public int timeoutMs;

		private TaskAwaiter<T> <>u__1;

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
	private struct <AwaitTaggedMessage>d__58<T> : IAsyncStateMachine where T : IMessage
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

		public string tag;

		public int timeoutMs;

		private <>c__DisplayClass58_0<T> <>8__1;

		private Action<T> <callback>5__2;

		private DateTime <timeoutTime>5__3;

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
	private struct <AwaitEitherMessage>d__59<T, T2> : IAsyncStateMachine where T : IMessage where T2 : IMessage
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<T> inFirstCallback;

		public Action<T2> inSecondCallback;

		public int timeoutMs;

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
	private struct <AwaitEitherTaggedMessage>d__60<T, T2> : IAsyncStateMachine where T : IMessage where T2 : IMessage
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<T> inFirstCallback;

		public string inFirstTag;

		public string inSecondTag;

		public Action<T2> inSecondCallback;

		public int timeoutMs;

		private <>c__DisplayClass60_0<T, T2> <>8__1;

		private DateTime <timeoutTime>5__2;

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
	private struct <AwaitAnyMessage>d__61 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public List<string> inEventNames;

		public List<Action<IMessage>> inCallbacks;

		public int timeoutMs;

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
	private struct <AwaitAnyTaggedMessage>d__62 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public List<string> inEventNames;

		public List<string> inTags;

		public List<Action<IMessage>> inCallbacks;

		public int timeoutMs;

		private <>c__DisplayClass62_0 <>8__1;

		private DateTime <timeoutTime>5__2;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private static MessagePool _messagePool;

	private static Dictionary<string, string> _eventIDNames;

	private static Dictionary<Type, string> _typeNames;

	private Dictionary<string, List<RegisteredListener>> _registeredListeners;

	private static Dictionary<string, List<RegisteredListener>> _staticRegisteredListeners;

	private List<RegisteredListener> _listenersToRegister;

	private List<RegisteredListener> _listenersToUnregister;

	private int _dispatchingStack;

	public static MessagePool MessagePool
	{
		get
		{
			return null;
		}
	}

	public bool IsDispatching
	{
		get
		{
			return default(bool);
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	private static string GetFullActionName(object inAction)
	{
		return null;
	}

	private static string GetActionTargetName(Action<IMessage> inAction)
	{
		return null;
	}

	private static string GetTaggedName(string inEventID, string inTag)
	{
		return null;
	}

	public static string GetEventIDName(string inEventID)
	{
		return null;
	}

	private static string GetTypeName(Type inType)
	{
		return null;
	}

	public override void Init()
	{
	}

	public void ClearListeners()
	{
	}

	private RegisteredListener GetRegisteredListener(RegisteredListener inListener)
	{
		return null;
	}

	private RegisteredListener GetRegisteredListener(string inEventID, MethodInfo inMethod, object inTarget, string inTag)
	{
		return null;
	}

	private static RegisteredListener GetStaticRegisteredListener(RegisteredListener inListener)
	{
		return null;
	}

	private static RegisteredListener GetStaticRegisteredListener(string inEventID, MethodInfo inMethod, object inTarget, string inTag)
	{
		return null;
	}

	private void AddRegisteredListener(RegisteredListener inListener)
	{
	}

	private static void AddStaticRegisteredListener(RegisteredListener inListener)
	{
	}

	private void RemoveRegisteredListener(RegisteredListener inListener)
	{
	}

	private static void RemoveStaticRegisteredListener(RegisteredListener inListener)
	{
	}

	public static void AddListener(string inEventID, Action<Message> inAction, string inTag = "")
	{
	}

	public static void AddListener<T>(Action<T> inAction, string inTag = "") where T : IMessage
	{
	}

	public static void AddListener<T>(string inEventID, Action<T> inAction, string inTag = "") where T : IMessage
	{
	}

	public static void AddStaticListener(string inEventID, Action<Message> inAction, string inTag = "")
	{
	}

	public static void AddStaticListener<T>(Action<T> inAction, string inTag = "") where T : IMessage
	{
	}

	public static void AddStaticListener<T>(string inEventID, Action<T> inAction, string inTag = "") where T : IMessage
	{
	}

	public static void RemoveListener(string inEventID, Action<Message> inAction, string inTag = "")
	{
	}

	public static void RemoveListener<T>(Action<T> inAction, string inTag = "") where T : IMessage
	{
	}

	public static void RemoveListener<T>(string inEventID, Action<T> inAction, string inTag = "") where T : IMessage
	{
	}

	public new static void SendMessage(string inEventID)
	{
	}

	public static void SendMessage<T>(T inMsg) where T : IMessage
	{
	}

	public static void SendMessage<T>(string inEventID, T inMsg) where T : IMessage
	{
	}

	public static void SendTaggedMessage<T>(T inMsg) where T : IMessage, ITaggedMessage
	{
	}

	public static void SendTaggedMessage<T>(string inEventID, T inMsg) where T : IMessage, ITaggedMessage
	{
	}

	private void HandleListenerQueues()
	{
	}

	public override void MUpdate()
	{
	}

	private void SendMessageToRegisteredListeners(IMessage inMessage, string tag = "")
	{
	}

	public static Action<T> OnMessage<T>(Action<T> inCallback) where T : IMessage
	{
		return null;
	}

	public static Action<T> OnTaggedMessage<T>(string inTag, Action<T> inCallback) where T : IMessage
	{
		return null;
	}

	public static Action<T> OnMessageWithEventID<T>(string inEventID, Action<T> inCallback) where T : IMessage
	{
		return null;
	}

	public static Action<T> OnMessageWithEventID<T>(string inEventID, string inTag, Action<T> inCallback) where T : IMessage
	{
		return null;
	}

	public static void OnEitherMessage<T, T2>(Action<T> inFirstCallback, Action<T2> inSecondCallback) where T : IMessage where T2 : IMessage
	{
	}

	public static void OnEitherTaggedMessage<T, T2>(string inFirstTag, Action<T> inFirstCallback, string inSecondTag, Action<T2> inSecondCallback) where T : IMessage where T2 : IMessage
	{
	}

	public static void OnEitherMessageWithEventID<T, T2>(string inFirstEventID, Action<T> inFirstCallback, string inSecondEventID, Action<T2> inSecondCallback) where T : IMessage where T2 : IMessage
	{
	}

	public static void OnEitherTaggedMessageWithEventID<T, T2>(string inFirstEventID, string inFirstTag, Action<T> inFirstCallback, string inSecondEventID, string inSecondTag, Action<T2> inSecondCallback) where T : IMessage where T2 : IMessage
	{
	}

	private string GetActionTargetName<T>(Action<T> inAction) where T : IMessage
	{
		return null;
	}

	private int GetActionTargetInstanceID<T>(Action<T> inAction) where T : IMessage
	{
		return default(int);
	}

	private string GetActionMethodName<T>(Action<T> inAction) where T : IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AwaitMessage>d__57<>))]
	public static Task<T> AwaitMessage<T>(int timeoutMs = 10000) where T : IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AwaitTaggedMessage>d__58<>))]
	public static Task<T> AwaitTaggedMessage<T>(string tag, int timeoutMs = 10000) where T : IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AwaitEitherMessage>d__59<, >))]
	public static Task AwaitEitherMessage<T, T2>(Action<T> inFirstCallback, Action<T2> inSecondCallback, int timeoutMs = 10000) where T : IMessage where T2 : IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AwaitEitherTaggedMessage>d__60<, >))]
	public static Task AwaitEitherTaggedMessage<T, T2>(string inFirstTag, Action<T> inFirstCallback, string inSecondTag, Action<T2> inSecondCallback, int timeoutMs = 10000) where T : IMessage where T2 : IMessage
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AwaitAnyMessage>d__61))]
	public static Task AwaitAnyMessage(List<string> inEventNames, List<Action<IMessage>> inCallbacks, int timeoutMs = 10000)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AwaitAnyTaggedMessage>d__62))]
	public static Task AwaitAnyTaggedMessage(List<string> inTags, List<string> inEventNames, List<Action<IMessage>> inCallbacks, int timeoutMs = 10000)
	{
		return null;
	}
}
