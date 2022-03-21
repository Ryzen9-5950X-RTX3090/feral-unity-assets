namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
{
	internal class GenericPolynomialExtensionField : IPolynomialExtensionField, IExtensionField, IFiniteField
	{
		protected readonly IFiniteField subfield;

		protected readonly IPolynomial minimalPolynomial;

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

		public virtual IFiniteField Subfield
		{
			get
			{
				return null;
			}
		}

		public virtual int Degree
		{
			get
			{
				return default(int);
			}
		}

		public virtual IPolynomial MinimalPolynomial
		{
			get
			{
				return null;
			}
		}

		internal GenericPolynomialExtensionField(IFiniteField subfield, IPolynomial polynomial)
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
