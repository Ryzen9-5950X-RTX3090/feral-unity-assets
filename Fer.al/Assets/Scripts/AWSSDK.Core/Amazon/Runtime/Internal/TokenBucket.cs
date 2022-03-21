using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class TokenBucket
	{
		private const int MaxAttempts = 15;

		private readonly object _bucketLock;

		private readonly double _minFillRate;

		private readonly double _minCapacity;

		private readonly double _beta;

		private readonly double _scaleConstant;

		private readonly double _smooth;

		private static readonly DateTime _epoch;

		protected double? FillRate
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

		protected double? MaxCapacity
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

		protected double CurrentCapacity
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected double? LastTimestamp
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

		protected double MeasuredTxRate
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected double LastTxRateBucket
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected long RequestCount
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected double LastMaxRate
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected double LastThrottleTime
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected double TimeWindow
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool Enabled
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

		public TokenBucket()
		{
		}

		public TokenBucket(double minFillRate, double minCapacity, double beta, double scaleConstant, double smooth)
		{
		}

		public bool TryAcquireToken(double amount, bool failFast)
		{
			return default(bool);
		}

		private bool? SetupAcquireToken(double amount)
		{
			return null;
		}

		private int ObtainCapacity(double amount)
		{
			return default(int);
		}

		public void UpdateClientSendingRate(bool isThrottlingError)
		{
		}

		protected virtual void TokenBucketRefill()
		{
		}

		protected virtual void TokenBucketUpdateRate(double newRps)
		{
		}

		protected virtual void UpdateMeasuredRate()
		{
		}

		protected virtual void CalculateTimeWindow()
		{
		}

		protected virtual double CUBICSuccess(double timestamp)
		{
			return default(double);
		}

		protected virtual double CUBICThrottle(double rateToUse)
		{
			return default(double);
		}

		protected virtual int CalculateWait(double amount, double currentCapacity, double fillRate)
		{
			return default(int);
		}

		protected virtual void WaitForToken(int delayMs)
		{
		}

		protected virtual double GetTimestamp()
		{
			return default(double);
		}

		private static double GetTimeInSeconds()
		{
			return default(double);
		}
	}
}
