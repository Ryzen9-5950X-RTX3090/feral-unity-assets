using System;
using System.Runtime.CompilerServices;
using BestHTTP.Logger;
using BestHTTP.WebSocket.Extensions;
using BestHTTP.WebSocket.Frames;

namespace BestHTTP.WebSocket
{
	public sealed class WebSocket
	{
		public OnWebSocketOpenDelegate OnOpen;

		public OnWebSocketMessageDelegate OnMessage;

		public OnWebSocketBinaryDelegate OnBinary;

		public OnWebSocketClosedDelegate OnClosed;

		public OnWebSocketErrorDelegate OnError;

		public OnWebSocketIncompleteFrameDelegate OnIncompleteFrame;

		private bool requestSent;

		private WebSocketResponse webSocket;

		public WebSocketStates State
		{
			[CompilerGenerated]
			get
			{
				return default(WebSocketStates);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsOpen
		{
			get
			{
				return default(bool);
			}
		}

		public int BufferedAmount
		{
			get
			{
				return default(int);
			}
		}

		public bool StartPingThread
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int PingFrequency
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan CloseAfterNoMessage
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

		public IExtension[] Extensions
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

		public int Latency
		{
			get
			{
				return default(int);
			}
		}

		public DateTime LastMessageReceived
		{
			get
			{
				return default(DateTime);
			}
		}

		public LoggingContext Context
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

		public WebSocket(Uri uri)
		{
		}

		public WebSocket(Uri uri, string origin, string protocol, IExtension[] extensions)
		{
		}

		private void OnInternalRequestCallback(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void OnInternalRequestUpgraded(HTTPRequest req, HTTPResponse resp)
		{
		}

		public void Open()
		{
		}

		public void Send(string message)
		{
		}

		public void Send(byte[] buffer)
		{
		}

		public void Send(byte[] buffer, ulong offset, ulong count)
		{
		}

		public void Send(WebSocketFrame frame)
		{
		}

		public void Close()
		{
		}

		public void Close(ushort code, string message)
		{
		}

		public static byte[] EncodeCloseData(ushort code, string message)
		{
			return null;
		}

		private string GetSecKey(object[] from)
		{
			return null;
		}
	}
}
