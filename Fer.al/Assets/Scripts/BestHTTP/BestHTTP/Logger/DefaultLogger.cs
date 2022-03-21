using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BestHTTP.Logger
{
	public class DefaultLogger : ILogger
	{
		private ILogOutput _output;

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

		public string FormatVerbose
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string FormatInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string FormatWarn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string FormatErr
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string FormatEx
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
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

		private string GetFormattedTime()
		{
			return null;
		}
	}
}
