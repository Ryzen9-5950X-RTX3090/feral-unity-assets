using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
	public class TbsRequest : Asn1Encodable
	{
		private static readonly DerInteger V1;

		private readonly DerInteger version;

		private readonly GeneralName requestorName;

		private readonly Asn1Sequence requestList;

		private readonly X509Extensions requestExtensions;

		private bool versionSet;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public GeneralName RequestorName
		{
			get
			{
				return null;
			}
		}

		public Asn1Sequence RequestList
		{
			get
			{
				return null;
			}
		}

		public X509Extensions RequestExtensions
		{
			get
			{
				return null;
			}
		}

		public static TbsRequest GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public static TbsRequest GetInstance(object obj)
		{
			return null;
		}

		public TbsRequest(GeneralName requestorName, Asn1Sequence requestList, X509Extensions requestExtensions)
		{
		}

		private TbsRequest(Asn1Sequence seq)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
