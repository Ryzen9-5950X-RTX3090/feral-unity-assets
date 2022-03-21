using System;

namespace Amazon.Runtime.Internal.Util
{
	internal class UnityDebugLogger : InternalLogger
	{
		public override bool IsDebugEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsErrorEnabled
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

		public UnityDebugLogger(Type declaringType)
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

		public override void DebugFormat(string messageFormat, object[] args)
		{
		}

		public override void InfoFormat(string message, object[] arguments)
		{
		}
	}
}
