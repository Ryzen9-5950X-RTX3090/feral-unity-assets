using System;

namespace Amazon.Runtime.Internal.Util
{
	public interface ILogger
	{
		void InfoFormat(string messageFormat, object[] args);

		void Debug(Exception exception, string messageFormat, object[] args);

		void DebugFormat(string messageFormat, object[] args);

		void Error(Exception exception, string messageFormat, object[] args);

		void Flush();
	}
}
