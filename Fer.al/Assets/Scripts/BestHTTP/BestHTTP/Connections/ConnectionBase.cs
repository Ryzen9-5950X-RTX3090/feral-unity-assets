using System;
using System.Runtime.CompilerServices;
using BestHTTP.Logger;

namespace BestHTTP.Connections
{
	public abstract class ConnectionBase : IDisposable
	{
		internal LoggingContext Context;

		private bool IsThreaded;

		public string ServerAddress
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

		public HTTPConnectionStates State
		{
			[CompilerGenerated]
			get
			{
				return default(HTTPConnectionStates);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public HTTPRequest CurrentRequest
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

		public virtual TimeSpan KeepAliveTime
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual bool CanProcessMultiple
		{
			get
			{
				return default(bool);
			}
		}

		public DateTime StartTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Uri LastProcessedUri
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

		public DateTime LastProcessTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			protected set
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
			protected set
			{
			}
		}

		public ConnectionBase(string serverAddress)
		{
		}

		public ConnectionBase(string serverAddress, bool threaded)
		{
		}

		internal virtual void Process(HTTPRequest request)
		{
		}

		protected virtual void ThreadFunc()
		{
		}

		public virtual void Shutdown(ShutdownTypes type)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~ConnectionBase()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
