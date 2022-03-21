using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UniRx.Async
{
	public static class DiagnosticsExtensions
	{
		private static bool displayFilenames;

		private static readonly Regex typeBeautifyRegex;

		private static readonly Dictionary<Type, string> builtInTypeNames;

		public static string ToStringWithCleanupAsyncStackTrace(this Exception exception)
		{
			return null;
		}

		public static string CleanupAsyncStackTrace(this StackTrace stackTrace)
		{
			return null;
		}

		private static bool IsAsync(MethodBase methodInfo)
		{
			return default(bool);
		}

		private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType)
		{
			return default(bool);
		}

		private static string BeautifyType(Type t, bool shortName)
		{
			return null;
		}

		private static bool IgnoreLine(MethodBase methodInfo)
		{
			return default(bool);
		}

		private static string SimplifyPath(string path)
		{
			return null;
		}
	}
}
