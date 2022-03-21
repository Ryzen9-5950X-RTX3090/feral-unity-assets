using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.SignalR
{
	public sealed class NegotiationData
	{
		public Action<NegotiationData> OnReceived;

		public Action<NegotiationData, string> OnError;

		private HTTPRequest NegotiationRequest;

		private IConnection Connection;

		public string Url
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

		public string WebSocketServerUrl
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

		public string ConnectionToken
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

		public string ConnectionId
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

		public TimeSpan? KeepAliveTimeout
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

		public TimeSpan DisconnectTimeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TimeSpan ConnectionTimeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool TryWebSockets
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

		public string ProtocolVersion
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

		public TimeSpan TransportConnectTimeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TimeSpan LongPollDelay
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NegotiationData(Connection connection)
		{
		}

		public void Start()
		{
		}

		public void Abort()
		{
		}

		private void OnNegotiationRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void RaiseOnError(string err)
		{
		}

		private NegotiationData Parse(string str)
		{
			return null;
		}

		private static object Get(Dictionary<string, object> from, string key)
		{
			return null;
		}

		private static string GetString(Dictionary<string, object> from, string key)
		{
			return null;
		}

		private static List<string> GetStringList(Dictionary<string, object> from, string key)
		{
			return null;
		}

		private static int GetInt(Dictionary<string, object> from, string key)
		{
			return default(int);
		}

		private static double GetDouble(Dictionary<string, object> from, string key)
		{
			return default(double);
		}
	}
}
