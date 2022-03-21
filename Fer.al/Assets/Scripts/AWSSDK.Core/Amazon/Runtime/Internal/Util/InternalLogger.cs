using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	internal abstract class InternalLogger
	{
		public Type DeclaringType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual bool IsErrorEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsDebugEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsInfoEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public InternalLogger(Type declaringType)
		{
		}

		public abstract void Flush();

		public abstract void Error(Exception exception, string messageFormat, object[] args);

		public abstract void Debug(Exception exception, string messageFormat, object[] args);

		public abstract void DebugFormat(string message, object[] arguments);

		public abstract void InfoFormat(string message, object[] arguments);
	}
}
