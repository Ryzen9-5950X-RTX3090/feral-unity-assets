using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class DefaultRetryPolicy : RetryPolicy
	{
		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		private static readonly CapacityManager _capacityManagerInstance;

		private static readonly HashSet<string> _netStandardRetryErrorMessages;

		public int MaxBackoffInMilliseconds
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DefaultRetryPolicy(int maxRetries)
		{
		}

		public DefaultRetryPolicy(IClientConfig config)
		{
		}

		public override bool CanRetry(IExecutionContext executionContext)
		{
			return default(bool);
		}

		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return default(bool);
		}

		public override bool OnRetry(IExecutionContext executionContext)
		{
			return default(bool);
		}

		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return default(bool);
		}

		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default(bool);
		}

		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}

		private bool RetryForExceptionSync(Exception exception)
		{
			return default(bool);
		}

		private bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
		{
			return default(bool);
		}

		public override bool RetryLimitReached(IExecutionContext executionContext)
		{
			return default(bool);
		}

		public override void WaitBeforeRetry(IExecutionContext executionContext)
		{
		}

		public static void WaitBeforeRetry(int retries, int maxBackoffInMilliseconds)
		{
		}

		private static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
		{
			return default(int);
		}

		[Obsolete]
		protected static bool ContainErrorMessage(Exception exception)
		{
			return default(bool);
		}

		[Obsolete]
		protected static bool IsInnerException<T>(Exception exception) where T : Exception
		{
			return default(bool);
		}

		[Obsolete]
		protected static bool IsInnerException<T>(Exception exception, out T inner) where T : Exception
		{
			return default(bool);
		}
	}
}
