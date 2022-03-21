using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Backtrace.Unity.Model
{
	internal class BacktraceStackTrace
	{
		public readonly List<BacktraceStackFrame> StackFrames;

		private readonly Exception _exception;

		public BacktraceStackTrace(Exception exception)
		{
		}

		private void Initialize()
		{
		}

		private void SetStacktraceInformation(StackFrame[] frames, bool generatedByException = false)
		{
		}
	}
}
