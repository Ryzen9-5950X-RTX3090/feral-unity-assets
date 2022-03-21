using System;
using System.Runtime.InteropServices;

namespace BestHTTP.Logger
{
	public interface ILogger
	{
		Loglevels Level { get; set; }

		ILogOutput Output { get; set; }

		void Verbose(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3);

		void Information(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3);

		void Warning(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3);

		void Error(string division, string msg, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3);

		void Exception(string division, string msg, Exception ex, [Optional] LoggingContext context1, [Optional] LoggingContext context2, [Optional] LoggingContext context3);
	}
}
