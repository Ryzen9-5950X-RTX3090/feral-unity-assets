using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class AdaptiveRetryPolicy : StandardRetryPolicy
	{
		protected TokenBucket TokenBucket
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

		public AdaptiveRetryPolicy(int maxRetries)
		{
		}

		public AdaptiveRetryPolicy(IClientConfig config)
		{
		}

		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default(bool);
		}

		public override void ObtainSendToken(IExecutionContext executionContext, Exception exception)
		{
		}

		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}
	}
}
