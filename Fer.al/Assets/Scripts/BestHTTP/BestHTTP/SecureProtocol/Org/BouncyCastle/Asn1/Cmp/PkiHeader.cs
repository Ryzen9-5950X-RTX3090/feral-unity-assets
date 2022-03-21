using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
	public class PkiHeader : Asn1Encodable
	{
		public static readonly GeneralName NULL_NAME;

		public static readonly int CMP_1999;

		public static readonly int CMP_2000;

		private readonly DerInteger pvno;

		private readonly GeneralName sender;

		private readonly GeneralName recipient;

		private readonly DerGeneralizedTime messageTime;

		private readonly AlgorithmIdentifier protectionAlg;

		private readonly Asn1OctetString senderKID;

		private readonly Asn1OctetString recipKID;

		private readonly Asn1OctetString transactionID;

		private readonly Asn1OctetString senderNonce;

		private readonly Asn1OctetString recipNonce;

		private readonly PkiFreeText freeText;

		private readonly Asn1Sequence generalInfo;

		public virtual DerInteger Pvno
		{
			get
			{
				return null;
			}
		}

		public virtual GeneralName Sender
		{
			get
			{
				return null;
			}
		}

		public virtual GeneralName Recipient
		{
			get
			{
				return null;
			}
		}

		public virtual DerGeneralizedTime MessageTime
		{
			get
			{
				return null;
			}
		}

		public virtual AlgorithmIdentifier ProtectionAlg
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1OctetString SenderKID
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1OctetString RecipKID
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1OctetString TransactionID
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1OctetString SenderNonce
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1OctetString RecipNonce
		{
			get
			{
				return null;
			}
		}

		public virtual PkiFreeText FreeText
		{
			get
			{
				return null;
			}
		}

		private PkiHeader(Asn1Sequence seq)
		{
		}

		public static PkiHeader GetInstance(object obj)
		{
			return null;
		}

		public PkiHeader(int pvno, GeneralName sender, GeneralName recipient)
		{
		}

		private PkiHeader(DerInteger pvno, GeneralName sender, GeneralName recipient)
		{
		}

		public virtual InfoTypeAndValue[] GetGeneralInfo()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
