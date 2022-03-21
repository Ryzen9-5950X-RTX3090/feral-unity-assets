using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
	internal class ReasonsMask
	{
		private int _reasons;

		internal static readonly ReasonsMask AllReasons;

		internal bool IsAllReasons
		{
			get
			{
				return default(bool);
			}
		}

		public ReasonFlags Reasons
		{
			get
			{
				return null;
			}
		}

		internal ReasonsMask(int reasons)
		{
		}

		internal ReasonsMask()
		{
		}

		internal void AddReasons(ReasonsMask mask)
		{
		}

		internal ReasonsMask Intersect(ReasonsMask mask)
		{
			return null;
		}

		internal bool HasNewReasons(ReasonsMask mask)
		{
			return default(bool);
		}
	}
}
