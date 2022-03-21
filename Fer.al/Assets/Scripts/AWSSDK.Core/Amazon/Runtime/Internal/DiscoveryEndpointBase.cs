using System;

namespace Amazon.Runtime.Internal
{
	public abstract class DiscoveryEndpointBase
	{
		private DateTime _createdOn;

		private string _address;

		private long _cachePeriodInMinutes;

		private object objectExtendLock;

		public string Address
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public long CachePeriodInMinutes
		{
			get
			{
				return default(long);
			}
			protected set
			{
			}
		}

		protected DiscoveryEndpointBase(string address, long cachePeriodInMinutes)
		{
		}

		public bool HasExpired()
		{
			return default(bool);
		}

		public void ExtendExpiration(long minutes)
		{
		}
	}
}
