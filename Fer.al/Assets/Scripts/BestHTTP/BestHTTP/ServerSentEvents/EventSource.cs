using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.Core;
using BestHTTP.Extensions;

namespace BestHTTP.ServerSentEvents
{
	public class EventSource : IProtocol, IDisposable, IHeartbeat
	{
		private States _state;

		private Dictionary<string, OnEventDelegate> EventTable;

		private byte RetryCount;

		private DateTime RetryCalled;

		private byte[] LineBuffer;

		private int LineBufferPos;

		private Message CurrentMessage;

		private ConcurrentQueue<Message> CompletedMessages;

		public Uri Uri
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public States State
		{
			get
			{
				return default(States);
			}
			private set
			{
			}
		}

		public TimeSpan ReconnectionTime
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string LastEventId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HostConnectionKey ConnectionKey
		{
			[CompilerGenerated]
			get
			{
				return default(HostConnectionKey);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsClosed
		{
			get
			{
				return default(bool);
			}
		}

		public HTTPRequest InternalRequest
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event OnGeneralEventDelegate OnOpen
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnMessageDelegate OnMessage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnErrorDelegate OnError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnRetryDelegate OnRetry
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnCommentDelegate OnComment
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnGeneralEventDelegate OnClosed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnStateChangedDelegate OnStateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public EventSource(Uri uri, int readBufferSizeOverride = 0)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void On(string eventName, OnEventDelegate action)
		{
		}

		public void Off(string eventName)
		{
		}

		private void CallOnError(string error, string msg)
		{
		}

		private bool CallOnRetry()
		{
			return default(bool);
		}

		private void SetClosed(string msg)
		{
		}

		private void Retry()
		{
		}

		private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private bool OnData(HTTPRequest request, HTTPResponse response, byte[] dataFragment, int dataFragmentLength)
		{
			return default(bool);
		}

		public bool FeedData(byte[] buffer, int count)
		{
			return default(bool);
		}

		private bool ParseLine(byte[] buffer, int count)
		{
			return default(bool);
		}

		private void OnMessageReceived(Message message)
		{
		}

		public void HandleEvents()
		{
		}

		public void CancellationRequested()
		{
		}

		public void Dispose()
		{
		}

		void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
		{
		}
	}
}
