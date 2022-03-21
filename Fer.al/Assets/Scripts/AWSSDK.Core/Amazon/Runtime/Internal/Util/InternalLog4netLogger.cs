using System;
using System.Reflection;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal.Util
{
	internal class InternalLog4netLogger : InternalLogger
	{
		private enum LoadState
		{
			Uninitialized,
			Failed,
			Loading,
			Success
		}

		private static LoadState loadState;

		private static readonly object LOCK;

		private static Type logMangerType;

		private static ITypeInfo logMangerTypeInfo;

		private static MethodInfo getLoggerWithTypeMethod;

		private static Type logType;

		private static ITypeInfo logTypeInfo;

		private static MethodInfo logMethod;

		private static Type levelType;

		private static ITypeInfo levelTypeInfo;

		private static object debugLevelPropertyValue;

		private static object infoLevelPropertyValue;

		private static object errorLevelPropertyValue;

		private static MethodInfo isEnabledForMethod;

		private static Type systemStringFormatType;

		private static Type loggerType;

		private object internalLogger;

		private bool? isErrorEnabled;

		private bool? isDebugEnabled;

		private bool? isInfoEnabled;

		public override bool IsErrorEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsDebugEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsInfoEnabled
		{
			get
			{
				return default(bool);
			}
		}

		private static void loadStatics()
		{
		}

		public InternalLog4netLogger(Type declaringType)
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
	}
}
