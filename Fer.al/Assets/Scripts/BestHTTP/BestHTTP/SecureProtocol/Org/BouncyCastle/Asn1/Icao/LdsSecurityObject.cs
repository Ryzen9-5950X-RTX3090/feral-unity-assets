using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
{
	public class LdsSecurityObject : Asn1Encodable
	{
		public const int UBDataGroups = 16;

		private DerInteger version;

		private AlgorithmIdentifier digestAlgorithmIdentifier;

		private DataGroupHash[] datagroupHash;

		private LdsVersionInfo versionInfo;

		public BigInteger Version
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier DigestAlgorithmIdentifier
		{
			get
			{
				return null;
			}
		}

		public LdsVersionInfo VersionInfo
		{
			get
			{
				return null;
			}
		}

		public static LdsSecurityObject GetInstance(object obj)
		{
			return null;
		}

		private LdsSecurityObject(Asn1Sequence seq)
		{
		}

		public LdsSecurityObject(AlgorithmIdentifier digestAlgorithmIdentifier, DataGroupHash[] datagroupHash)
		{
		}

		public LdsSecurityObject(AlgorithmIdentifier digestAlgorithmIdentifier, DataGroupHash[] datagroupHash, LdsVersionInfo versionInfo)
		{
		}

		private void CheckDatagroupHashSeqSize(int size)
		{
		}

		public DataGroupHash[] GetDatagroupHash()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
