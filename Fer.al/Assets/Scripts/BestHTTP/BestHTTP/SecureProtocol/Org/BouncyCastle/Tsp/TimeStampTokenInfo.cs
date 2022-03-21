using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
	public class TimeStampTokenInfo
	{
		private TstInfo tstInfo;

		private DateTime genTime;

		public bool IsOrdered
		{
			get
			{
				return default(bool);
			}
		}

		public Accuracy Accuracy
		{
			get
			{
				return null;
			}
		}

		public DateTime GenTime
		{
			get
			{
				return default(DateTime);
			}
		}

		public GenTimeAccuracy GenTimeAccuracy
		{
			get
			{
				return null;
			}
		}

		public string Policy
		{
			get
			{
				return null;
			}
		}

		public BigInteger SerialNumber
		{
			get
			{
				return null;
			}
		}

		public GeneralName Tsa
		{
			get
			{
				return null;
			}
		}

		public BigInteger Nonce
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return null;
			}
		}

		public string MessageImprintAlgOid
		{
			get
			{
				return null;
			}
		}

		public TstInfo TstInfo
		{
			get
			{
				return null;
			}
		}

		public TimeStampTokenInfo(TstInfo tstInfo)
		{
		}

		public byte[] GetMessageImprintDigest()
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}
	}
}
