using UnityEngine;

namespace Backtrace.Unity.Model
{
	internal class BacktraceUnityMessage
	{
		private readonly string _formattedMessage;

		public readonly string Message;

		public readonly string StackTrace;

		public readonly LogType Type;

		public BacktraceUnityMessage(BacktraceReport report)
		{
		}

		public BacktraceUnityMessage(string message, string stacktrace, LogType type)
		{
		}

		private string GetFormattedMessage(bool backtraceFrame)
		{
			return null;
		}

		private string GetFormattedStackTrace(string stacktrace)
		{
			return null;
		}

		public bool IsUnhandledException()
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
