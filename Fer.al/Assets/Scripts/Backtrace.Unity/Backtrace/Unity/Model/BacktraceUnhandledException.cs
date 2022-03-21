using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Backtrace.Unity.Model
{
	public class BacktraceUnhandledException : Exception
	{
		private bool _header;

		private string _message;

		private readonly string _stacktrace;

		public readonly List<BacktraceStackFrame> StackFrames;

		public override string Message
		{
			get
			{
				return null;
			}
		}

		public string Classifier
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

		public override string StackTrace
		{
			get
			{
				return null;
			}
		}

		public BacktraceUnhandledException(string message, string stacktrace)
		{
		}

		private void ConvertStackFrames()
		{
		}

		private BacktraceStackFrame SetJITStackTraceInformation(string frameString)
		{
			return null;
		}

		private BacktraceStackFrame SetNativeStackTraceInformation(string frameString)
		{
			return null;
		}

		private BacktraceStackFrame SetAndroidStackTraceInformation(string frameString)
		{
			return null;
		}

		private BacktraceStackFrame SetDefaultStackTraceInformation(string frameString)
		{
			return null;
		}

		private void TrySetClassifier()
		{
		}
	}
}
