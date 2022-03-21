using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DHParameters : ICipherParameters
	{
		private const int DefaultMinimumLength = 160;

		private readonly BigInteger p;

		private readonly BigInteger g;

		private readonly BigInteger q;

		private readonly BigInteger j;

		private readonly int m;

		private readonly int l;

		private readonly DHValidationParameters validation;

		public BigInteger P
		{
			get
			{
				return null;
			}
		}

		public BigInteger G
		{
			get
			{
				return null;
			}
		}

		public BigInteger Q
		{
			get
			{
				return null;
			}
		}

		public BigInteger J
		{
			get
			{
				return null;
			}
		}

		public int M
		{
			get
			{
				return default(int);
			}
		}

		public int L
		{
			get
			{
				return default(int);
			}
		}

		public DHValidationParameters ValidationParameters
		{
			get
			{
				return null;
			}
		}

		private static int GetDefaultMParam(int lParam)
		{
			return default(int);
		}

		public DHParameters(BigInteger p, BigInteger g)
		{
		}

		public DHParameters(BigInteger p, BigInteger g, BigInteger q)
		{
		}

		public DHParameters(BigInteger p, BigInteger g, BigInteger q, int l)
		{
		}

		public DHParameters(BigInteger p, BigInteger g, BigInteger q, int m, int l)
		{
		}

		public DHParameters(BigInteger p, BigInteger g, BigInteger q, BigInteger j, DHValidationParameters validation)
		{
		}

		public DHParameters(BigInteger p, BigInteger g, BigInteger q, int m, int l, BigInteger j, DHValidationParameters validation)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected virtual bool Equals(DHParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
