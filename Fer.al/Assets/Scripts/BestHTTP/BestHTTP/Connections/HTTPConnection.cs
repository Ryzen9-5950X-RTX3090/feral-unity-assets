using System;
using BestHTTP.Core;

namespace BestHTTP.Connections
{
	public sealed class HTTPConnection : ConnectionBase
	{
		public TCPConnector connector;

		public IHTTPRequestHandler requestHandler;

		public override TimeSpan KeepAliveTime
		{
			get
			{
				return default(TimeSpan);
			}
			protected set
			{
			}
		}

		public override bool CanProcessMultiple
		{
			get
			{
				return default(bool);
			}
		}

		internal HTTPConnection(string serverAddress)
		{
		}

		internal override void Process(HTTPRequest request)
		{
		}

		protected override void ThreadFunc()
		{
		}

		public override void Shutdown(ShutdownTypes type)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
