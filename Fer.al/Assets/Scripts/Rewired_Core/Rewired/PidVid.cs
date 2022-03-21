using System;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal struct PidVid : IEquatable<PidVid>
	{
		private const string qnFwinHbdbSxOuzzgyWciEJlHZv = "[^a-fA-F0-9]";

		public ushort productId;

		public ushort vendorId;

		public bool isZero
		{
			get
			{
				return default(bool);
			}
		}

		public PidVid(ushort productId, ushort vendorId)
		{
		}

		public PidVid(string pidVid)
		{
		}

		public PidVid(Guid productGuid)
		{
		}

		public bool Equals(string pidVid)
		{
			return default(bool);
		}

		public Guid ToProductGuid()
		{
			return default(Guid);
		}

		private bool FIUpKXqfwFwMbRkVcqLiuqHApWR(string P_0)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(PidVid other)
		{
			return default(bool);
		}

		public static bool operator ==(PidVid x, PidVid y)
		{
			return default(bool);
		}

		public static bool operator !=(PidVid x, PidVid y)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		public static bool ArrayContains(string[] pidVids, ref PidVid vidPid)
		{
			return default(bool);
		}

		private static string qRqEoCBxgxWKqwKgDkLBiIxJpArm(string P_0)
		{
			return null;
		}
	}
}
