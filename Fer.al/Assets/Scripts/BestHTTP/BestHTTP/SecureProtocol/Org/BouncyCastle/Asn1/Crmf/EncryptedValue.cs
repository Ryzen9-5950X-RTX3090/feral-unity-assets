using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
	public class EncryptedValue : Asn1Encodable
	{
		private readonly AlgorithmIdentifier intendedAlg;

		private readonly AlgorithmIdentifier symmAlg;

		private readonly DerBitString encSymmKey;

		private readonly AlgorithmIdentifier keyAlg;

		private readonly Asn1OctetString valueHint;

		private readonly DerBitString encValue;

		public virtual AlgorithmIdentifier IntendedAlg
		{
			get
			{
				return null;
			}
		}

		public virtual AlgorithmIdentifier SymmAlg
		{
			get
			{
				return null;
			}
		}

		public virtual DerBitString EncSymmKey
		{
			get
			{
				return null;
			}
		}

		public virtual AlgorithmIdentifier KeyAlg
		{
			get
			{
				return null;
			}
		}

		public virtual Asn1OctetString ValueHint
		{
			get
			{
				return null;
			}
		}

		public virtual DerBitString EncValue
		{
			get
			{
				return null;
			}
		}

		private EncryptedValue(Asn1Sequence seq)
		{
		}

		public static EncryptedValue GetInstance(object obj)
		{
			return null;
		}

		public EncryptedValue(AlgorithmIdentifier intendedAlg, AlgorithmIdentifier symmAlg, DerBitString encSymmKey, AlgorithmIdentifier keyAlg, Asn1OctetString valueHint, DerBitString encValue)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
