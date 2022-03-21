namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
{
	internal class GF2Polynomial : IPolynomial
	{
		protected readonly int[] exponents;

		public virtual int Degree
		{
			get
			{
				return default(int);
			}
		}

		internal GF2Polynomial(int[] exponents)
		{
		}

		public virtual int[] GetExponentsPresent()
		{
			return null;
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
