using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.Logger
{
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public sealed class ThreadedLogger : ILogger, IDisposable
	{
		private ILogOutput _output;

		private StringBuilder sb;

		public TimeSpan ExitThreadAfterInactivity;

		private ConcurrentQueue<LogJob> jobs;

		private AutoResetEvent newJobEvent;

		private int threadCreated;

		private bool isDisposed;

		public Loglevels Level
		{
			[CompilerGenerated]
			get
			{
				return default(Loglevels);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ILogOutput Output
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Verbose(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3)
		{
		}

		public void Information(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3)
		{
		}

		public void Warning(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3)
		{
		}

		public void Error(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3)
		{
		}

		public void Exception(string division, string msg, Exception ex, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3)
		{
		}

		private void AddJob(Loglevels level, string div, string msg, Exception ex, LoggingContext context1, LoggingContext context2, LoggingContext context3)
		{
		}

		private void ThreadFunc()
		{
		}

		public void Dispose()
		{
		}
	}
}
