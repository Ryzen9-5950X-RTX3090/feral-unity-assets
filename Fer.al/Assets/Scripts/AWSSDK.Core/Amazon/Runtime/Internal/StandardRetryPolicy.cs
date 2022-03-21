using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class StandardRetryPolicy : RetryPolicy
	{
		private static Random _randomJitter;

		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		protected static CapacityManager CapacityManagerInstance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

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

		public StandardRetryPolicy(int maxRetries)
		{
		}

		public StandardRetryPolicy(IClientConfig config)
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

		protected bool RetryForExceptionSync(Exception exception)
		{
			return default(bool);
		}

		protected bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
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

		protected static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
		{
			return default(int);
		}
	}
}
