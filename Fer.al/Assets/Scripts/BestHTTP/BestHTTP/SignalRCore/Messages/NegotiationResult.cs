using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.SignalRCore.Messages
{
	public sealed class NegotiationResult
	{
		public int NegotiateVersion
		{
			[CompilerGenerated]
			get
			{
				return default(int);
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

		public List<SupportedTransport> SupportedTransports
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

		public Uri Url
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

		public string AccessToken
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

		public HTTPResponse NegotiationResponse
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		internal static NegotiationResult Parse(HTTPResponse resp, out string error, HubConnection hub)
		{
			return null;
		}

		private static bool IsAbsolute(string url)
		{
			return default(bool);
		}
	}
}
