using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public abstract class ECKeyParameters : AsymmetricKeyParameter
	{
		private static readonly string[] algorithms;

		private readonly string algorithm;

		private readonly ECDomainParameters parameters;

		private readonly DerObjectIdentifier publicKeyParamSet;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public ECDomainParameters Parameters
		{
			get
			{
				return null;
			}
		}

		public DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return null;
			}
		}

		protected ECKeyParameters(string algorithm, bool isPrivate, ECDomainParameters parameters)
		{
		}

		protected ECKeyParameters(string algorithm, bool isPrivate, DerObjectIdentifier publicKeyParamSet)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(ECKeyParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		internal ECKeyGenerationParameters CreateKeyGenerationParameters(SecureRandom random)
		{
			return null;
		}

		internal static string VerifyAlgorithmName(string algorithm)
		{
			return null;
		}

		internal static ECDomainParameters LookupParameters(DerObjectIdentifier publicKeyParamSet)
		{
			return null;
		}
	}
}
