namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
{
	internal class PrimeField : IFiniteField
	{
		protected readonly BigInteger characteristic;

		public virtual BigInteger Characteristic
		{
			get
			{
				return null;
			}
		}

		public virtual int Dimension
		{
			get
			{
				return default(int);
			}
		}

		internal PrimeField(BigInteger characteristic)
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
