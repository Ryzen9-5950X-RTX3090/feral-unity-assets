using System;
using System.Runtime.CompilerServices;
using BestHTTP.Core;
using BestHTTP.Logger;

namespace BestHTTP.Connections
{
	public sealed class HTTP1Handler : IHTTPRequestHandler, IDisposable
	{
		private KeepAliveHeader _keepAlive;

		private readonly HTTPConnection conn;

		public bool HasCustomRequestProcessor
		{
			get
			{
				return default(bool);
			}
		}

		public KeepAliveHeader KeepAlive
		{
			get
			{
				return null;
			}
		}

		public bool CanProcessMultiple
		{
			get
			{
				return default(bool);
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

		public ShutdownTypes ShutdownType
		{
			[CompilerGenerated]
			get
			{
				return default(ShutdownTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HTTP1Handler(HTTPConnection conn)
		{
		}

		public void Process(HTTPRequest request)
		{
		}

		public void RunHandler()
		{
		}

		private void OnCancellationRequested(HTTPRequest obj)
		{
		}

		private bool Receive(HTTPRequest request)
		{
			return default(bool);
		}

		public void Shutdown(ShutdownTypes type)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		~HTTP1Handler()
		{
		}
	}
}
