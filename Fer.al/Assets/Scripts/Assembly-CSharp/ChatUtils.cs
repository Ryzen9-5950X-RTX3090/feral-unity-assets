using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;

public static class ChatUtils
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Private>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inText;

		private int <ii>5__2;

		private UniTask<UserInfo>.Awaiter <>u__1;

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
	private struct <Block>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inText;

		public bool inBlock;

		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1;

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
	private struct <Favorite>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inText;

		public bool inFavorite;

		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1;

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
	private struct <Follow>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inText;

		public bool inFollow;

		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1;

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
	private struct <Sanctuary>d__13 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inText;

		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1;

		private TaskAwaiter<bool> <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static void Action(string inChatText)
	{
	}

	private static bool ParseAction(string inChatText, string inAction, out string outText)
	{
		return default(bool);
	}

	private static void Help()
	{
	}

	[AsyncStateMachine(typeof(<Private>d__3))]
	private static void Private(string inText)
	{
	}

	private static void Party(string inText)
	{
	}

	private static void GiveMe(string inText)
	{
	}

	private static void GiveMeLikes(string inText)
	{
	}

	private static void GiveMeStars(string inText)
	{
	}

	private static void GiveMeLockpicks(string inText)
	{
	}

	private static void GiveMeAll(string inText)
	{
	}

	[AsyncStateMachine(typeof(<Block>d__10))]
	private static void Block(string inText, bool inBlock)
	{
	}

	[AsyncStateMachine(typeof(<Favorite>d__11))]
	private static void Favorite(string inText, bool inFavorite)
	{
	}

	[AsyncStateMachine(typeof(<Follow>d__12))]
	private static void Follow(string inText, bool inFollow)
	{
	}

	[AsyncStateMachine(typeof(<Sanctuary>d__13))]
	private static void Sanctuary(string inText)
	{
	}

	private static void Goto(string inText)
	{
	}
}
