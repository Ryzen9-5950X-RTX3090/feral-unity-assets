using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public abstract class RetryPolicy
	{
		private static HashSet<string> clockSkewErrorCodes;

		private const string clockSkewMessageFormat = "Identified clock skew: local time = {0}, local time with correction = {1}, current clock skew correction = {2}, server time = {3}, service endpoint = {4}.";

		private const string clockSkewUpdatedFormat = "Setting clock skew correction: new clock skew correction = {0}, service endpoint = {1}.";

		private const string clockSkewMessageParen = "(";

		private const string clockSkewMessagePlusSeparator = " + ";

		private const string clockSkewMessageMinusSeparator = " - ";

		private static TimeSpan clockSkewMaxThreshold;

		public int MaxRetries
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ILogger Logger
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

		public virtual ICollection<string> ThrottlingErrorCodes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ICollection<string> TimeoutErrorCodesToRetryOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ICollection<string> ErrorCodesToRetryOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ICollection<HttpStatusCode> HttpStatusCodesToRetryOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected RetryCapacity RetryCapacity
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

		public bool Retry(IExecutionContext executionContext, Exception exception)
		{
			return default(bool);
		}

		public abstract bool CanRetry(IExecutionContext executionContext);

		public abstract bool RetryForException(IExecutionContext executionContext, Exception exception);

		public abstract bool RetryLimitReached(IExecutionContext executionContext);

		public abstract void WaitBeforeRetry(IExecutionContext executionContext);

		public virtual void NotifySuccess(IExecutionContext executionContext)
		{
		}

		public virtual bool OnRetry(IExecutionContext executionContext)
		{
			return default(bool);
		}

		public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return default(bool);
		}

		public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default(bool);
		}

		public virtual void ObtainSendToken(IExecutionContext executionContext, Exception exception)
		{
		}

		public virtual bool IsThrottlingError(Exception exception)
		{
			return default(bool);
		}

		public virtual bool IsTransientError(IExecutionContext executionContext, Exception exception)
		{
			return default(bool);
		}

		public virtual bool IsServiceTimeoutError(Exception exception)
		{
			return default(bool);
		}

		private bool IsClockskew(IExecutionContext executionContext, Exception exception)
		{
			return default(bool);
		}

		private static bool TryParseDateHeader(AmazonServiceException ase, out DateTime serverTime)
		{
			return default(bool);
		}

		private static bool TryParseExceptionMessage(AmazonServiceException ase, out DateTime serverTime)
		{
			return default(bool);
		}

		private static IWebResponseData GetWebData(AmazonServiceException ase)
		{
			return null;
		}

		protected static bool ContainErrorMessage(Exception exception, HashSet<string> errorMessages)
		{
			return default(bool);
		}
	}
}
