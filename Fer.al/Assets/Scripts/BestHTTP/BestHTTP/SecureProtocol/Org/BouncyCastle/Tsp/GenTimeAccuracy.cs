using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
	public class GenTimeAccuracy
	{
		private Accuracy accuracy;

		public int Seconds
		{
			get
			{
				return default(int);
			}
		}

		public int Millis
		{
			get
			{
				return default(int);
			}
		}

		public int Micros
		{
			get
			{
				return default(int);
			}
		}

		public GenTimeAccuracy(Accuracy accuracy)
		{
		}

		private int GetTimeComponent(DerInteger time)
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
