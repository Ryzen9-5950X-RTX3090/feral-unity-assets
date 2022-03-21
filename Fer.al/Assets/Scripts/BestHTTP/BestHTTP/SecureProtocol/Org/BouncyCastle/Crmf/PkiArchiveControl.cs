using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Cms;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crmf
{
	public class PkiArchiveControl : IControl
	{
		public static readonly int encryptedPrivKey;

		public static readonly int keyGenParameters;

		public static readonly int archiveRemGenPrivKey;

		private static readonly DerObjectIdentifier type;

		private readonly PkiArchiveOptions pkiArchiveOptions;

		public DerObjectIdentifier Type
		{
			get
			{
				return null;
			}
		}

		public Asn1Encodable Value
		{
			get
			{
				return null;
			}
		}

		public int ArchiveType
		{
			get
			{
				return default(int);
			}
		}

		public bool EnvelopedData
		{
			get
			{
				return default(bool);
			}
		}

		public PkiArchiveControl(PkiArchiveOptions pkiArchiveOptions)
		{
		}

		public CmsEnvelopedData GetEnvelopedData()
		{
			return null;
		}
	}
}
