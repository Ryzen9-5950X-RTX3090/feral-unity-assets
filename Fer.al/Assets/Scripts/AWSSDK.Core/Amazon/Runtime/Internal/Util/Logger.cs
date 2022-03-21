using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Amazon.Runtime.Internal.Util
{
	public class Logger : ILogger
	{
		private static IDictionary<Type, Logger> cachedLoggers;

		private List<InternalLogger> loggers;

		private static Logger emptyLogger;

		public static Logger EmptyLogger
		{
			get
			{
				return null;
			}
		}

		private Logger()
		{
		}

		private Logger(Type type)
		{
		}

		private void ConfigsChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void ConfigureLoggers()
		{
		}

		public static Logger GetLogger(Type type)
		{
			return null;
		}

		public static void ClearLoggerCache()
		{
		}

		public void Flush()
		{
		}

		public void Error(Exception exception, string messageFormat, object[] args)
		{
		}

		public void Debug(Exception exception, string messageFormat, object[] args)
		{
		}

		public void DebugFormat(string messageFormat, object[] args)
		{
		}

		public void InfoFormat(string messageFormat, object[] args)
		{
		}
	}
}
