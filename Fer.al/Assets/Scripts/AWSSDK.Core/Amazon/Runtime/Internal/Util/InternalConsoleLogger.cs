using System;

namespace Amazon.Runtime.Internal.Util
{
	internal class InternalConsoleLogger : InternalLogger
	{
		private enum LogLevel
		{
			Verbose = 2,
			Debug,
			Info,
			Warn,
			Error,
			Assert
		}

		public static long _sequanceId;

		public InternalConsoleLogger(Type declaringType)
		{
		}

		public override void Flush()
		{
		}

		public override void Error(Exception exception, string messageFormat, object[] args)
		{
		}

		public override void Debug(Exception exception, string messageFormat, object[] args)
		{
		}

		public override void DebugFormat(string message, object[] arguments)
		{
		}

		public override void InfoFormat(string message, object[] arguments)
		{
		}

		private void Log(LogLevel logLevel, string message, Exception ex)
		{
		}
	}
}
