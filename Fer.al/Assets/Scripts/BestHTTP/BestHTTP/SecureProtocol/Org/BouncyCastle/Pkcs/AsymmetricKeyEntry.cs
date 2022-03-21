using System;
using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
	public class AsymmetricKeyEntry : Pkcs12Entry
	{
		private readonly AsymmetricKeyParameter key;

		public AsymmetricKeyParameter Key
		{
			get
			{
				return null;
			}
		}

		public AsymmetricKeyEntry(AsymmetricKeyParameter key)
		{
		}

		[Obsolete]
		public AsymmetricKeyEntry(AsymmetricKeyParameter key, Hashtable attributes)
		{
		}

		public AsymmetricKeyEntry(AsymmetricKeyParameter key, IDictionary attributes)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
