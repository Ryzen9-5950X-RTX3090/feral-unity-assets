using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
	public class EncKeyWithID : Asn1Encodable
	{
		private readonly PrivateKeyInfo privKeyInfo;

		private readonly Asn1Encodable identifier;

		public virtual PrivateKeyInfo PrivateKey
		{
			get
			{
				return null;
			}
		}

		public virtual bool HasIdentifier
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsIdentifierUtf8String
		{
			get
			{
				return default(bool);
			}
		}

		public virtual Asn1Encodable Identifier
		{
			get
			{
				return null;
			}
		}

		public static EncKeyWithID GetInstance(object obj)
		{
			return null;
		}

		private EncKeyWithID(Asn1Sequence seq)
		{
		}

		public EncKeyWithID(PrivateKeyInfo privKeyInfo)
		{
		}

		public EncKeyWithID(PrivateKeyInfo privKeyInfo, DerUtf8String str)
		{
		}

		public EncKeyWithID(PrivateKeyInfo privKeyInfo, GeneralName generalName)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
