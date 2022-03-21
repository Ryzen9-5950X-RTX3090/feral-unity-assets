using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
	public sealed class WrapperUtilities
	{
		private enum WrapAlgorithm
		{
			AESWRAP,
			CAMELLIAWRAP,
			DESEDEWRAP,
			RC2WRAP,
			SEEDWRAP,
			DESEDERFC3211WRAP,
			AESRFC3211WRAP,
			CAMELLIARFC3211WRAP
		}

		private class BufferedCipherWrapper : IWrapper
		{
			private readonly IBufferedCipher cipher;

			private bool forWrapping;

			public string AlgorithmName
			{
				get
				{
					return null;
				}
			}

			public BufferedCipherWrapper(IBufferedCipher cipher)
			{
			}

			public void Init(bool forWrapping, ICipherParameters parameters)
			{
			}

			public byte[] Wrap(byte[] input, int inOff, int length)
			{
				return null;
			}

			public byte[] Unwrap(byte[] input, int inOff, int length)
			{
				return null;
			}
		}

		private static readonly IDictionary algorithms;

		private WrapperUtilities()
		{
		}

		static WrapperUtilities()
		{
		}

		public static IWrapper GetWrapper(DerObjectIdentifier oid)
		{
			return null;
		}

		public static IWrapper GetWrapper(string algorithm)
		{
			return null;
		}

		public static string GetAlgorithmName(DerObjectIdentifier oid)
		{
			return null;
		}
	}
}
