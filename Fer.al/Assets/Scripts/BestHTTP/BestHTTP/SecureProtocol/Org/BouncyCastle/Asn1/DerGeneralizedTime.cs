using System;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerGeneralizedTime : Asn1Object
	{
		private readonly string time;

		public string TimeString
		{
			get
			{
				return null;
			}
		}

		private bool HasFractionalSeconds
		{
			get
			{
				return default(bool);
			}
		}

		public static DerGeneralizedTime GetInstance(object obj)
		{
			return null;
		}

		public static DerGeneralizedTime GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public DerGeneralizedTime(string time)
		{
		}

		public DerGeneralizedTime(DateTime time)
		{
		}

		internal DerGeneralizedTime(byte[] bytes)
		{
		}

		public string GetTime()
		{
			return null;
		}

		private string CalculateGmtOffset()
		{
			return null;
		}

		private static string Convert(int time)
		{
			return null;
		}

		public DateTime ToDateTime()
		{
			return default(DateTime);
		}

		private string FString(int count)
		{
			return null;
		}

		private DateTime ParseDateString(string s, string format, bool makeUniversal)
		{
			return default(DateTime);
		}

		private byte[] GetOctets()
		{
			return null;
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}

		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		protected override int Asn1GetHashCode()
		{
			return default(int);
		}
	}
}
