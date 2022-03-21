using System.Collections.Generic;
using System.Diagnostics;
using Rewired.Config;
using Rewired.Internal;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal static class Logger
	{
		private const int screenLogLength = 50;

		private static List<string> __screenLog;

		private static GUIText _guiText;

		private static bool _logToScreen;

		private static List<string> screenLog
		{
			get
			{
				return null;
			}
		}

		private static LogLevelFlags logLevel
		{
			get
			{
				return default(LogLevelFlags);
			}
		}

		public static bool logToScreen
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static void LogEditor(object msg)
		{
		}

		public static void LogEditor(object msg, bool requiredThreadSafety)
		{
		}

		public static void LogWarningEditor(object msg)
		{
		}

		public static void LogWarningEditor(object msg, bool requiredThreadSafety)
		{
		}

		public static void LogErrorEditor(object msg)
		{
		}

		public static void LogErrorEditor(object msg, bool requiredThreadSafety)
		{
		}

		public static void Log(object msg)
		{
		}

		public static void Log(object msg, bool requiredThreadSafety)
		{
		}

		public static void LogWarning(object msg)
		{
		}

		public static void LogWarning(object msg, bool requiredThreadSafety)
		{
		}

		public static void LogError(object msg)
		{
		}

		public static void LogError(object msg, bool requiredThreadSafety)
		{
		}

		private static void LogNow(object msg, bool requireThreadSafety)
		{
		}

		private static void LogWarningNow(object msg, bool requireThreadSafety)
		{
		}

		private static void LogErrorNow(object msg, bool requireThreadSafety)
		{
		}

		private static bool IsLoggingAllowed(LogLevel logLevel)
		{
			return default(bool);
		}

		private static void LogToScreen(object msg)
		{
		}

		[Conditional("LOG_INIT")]
		public static void LogInit(object o)
		{
		}

		[Conditional("LOG_INIT")]
		public static void LogInitError(object o)
		{
		}

		[Conditional("LOG_INIT")]
		public static void LogInitWarning(object o)
		{
		}

		[Conditional("LOG_VC")]
		public static void Log_VCTest(object o)
		{
		}

		[Conditional("LOG_UPDATE")]
		public static void LogUpdate(object o)
		{
		}
	}
}
