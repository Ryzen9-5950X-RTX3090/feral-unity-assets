using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public abstract class RefreshingAWSCredentials : AWSCredentials, IDisposable
	{
		public class CredentialsRefreshState
		{
			public ImmutableCredentials Credentials
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

			public DateTime Expiration
			{
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public CredentialsRefreshState()
			{
			}

			public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration)
			{
			}

			internal bool IsExpiredWithin(TimeSpan preemptExpiryTime)
			{
				return default(bool);
			}
		}

		private Logger _logger;

		protected CredentialsRefreshState currentState;

		private TimeSpan _preemptExpiryTime;

		private bool _disposed;

		private readonly Semaphore _updateGeneratedCredentialsSemaphore;

		public TimeSpan PreemptExpiryTime
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		protected bool ShouldUpdate
		{
			get
			{
				return default(bool);
			}
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		private static void UpdateToGeneratedCredentials(CredentialsRefreshState state, TimeSpan preemptExpiryTime)
		{
		}

		private static bool ShouldUpdateState(CredentialsRefreshState state, TimeSpan preemptExpiryTime)
		{
			return default(bool);
		}

		protected virtual CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual void ClearCredentials()
		{
		}

		public void Dispose()
		{
		}
	}
}
