using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BestHTTP.Examples.Helpers;
using BestHTTP.SignalRCore;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples
{
	public class AsyncTestHubSample : SampleBase
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <OnDestroy>d__9 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			public AsyncTestHubSample <>4__this;

			private TaskAwaiter<HubConnection> <>u__1;

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
		private struct <OnConnectButton>d__10 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			public AsyncTestHubSample <>4__this;

			private TaskAwaiter<HubConnection> <>u__1;

			private TaskAwaiter<object> <>u__2;

			private TaskAwaiter<string> <>u__3;

			private TaskAwaiter<int> <>u__4;

			private TaskAwaiter<int?> <>u__5;

			private TaskAwaiter<Person> <>u__6;

			private TaskAwaiter<int[]> <>u__7;

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
		private struct <OnCloseButton>d__11 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			public AsyncTestHubSample <>4__this;

			private TaskAwaiter<HubConnection> <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[SerializeField]
		private string _path;

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _contentRoot;

		[SerializeField]
		private TextListItem _listItemPrefab;

		[SerializeField]
		private int _maxListItemEntries;

		[SerializeField]
		private Button _connectButton;

		[SerializeField]
		private Button _closeButton;

		private HubConnection hub;

		protected override void Start()
		{
		}

		[AsyncStateMachine(typeof(<OnDestroy>d__9))]
		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(<OnConnectButton>d__10))]
		public void OnConnectButton()
		{
		}

		[AsyncStateMachine(typeof(<OnCloseButton>d__11))]
		public void OnCloseButton()
		{
		}

		private void Hub_OnError(HubConnection hub, string error)
		{
		}

		private void SetButtons(bool connect, bool close)
		{
		}

		private TextListItem AddText(string text)
		{
			return null;
		}
	}
}
