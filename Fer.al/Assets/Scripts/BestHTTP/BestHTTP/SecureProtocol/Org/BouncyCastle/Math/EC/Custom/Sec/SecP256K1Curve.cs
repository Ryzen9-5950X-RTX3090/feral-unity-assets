namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP256K1Curve : AbstractFpCurve
	{
		private class SecP256K1LookupTable : AbstractECLookupTable
		{
			private readonly SecP256K1Curve m_outer;

			private readonly uint[] m_table;

			private readonly int m_size;

			public override int Size
			{
				get
				{
					return default(int);
				}
			}

			internal SecP256K1LookupTable(SecP256K1Curve outer, uint[] table, int size)
			{
			}

			public override ECPoint Lookup(int index)
			{
				return null;
			}

			public override ECPoint LookupVar(int index)
			{
				return null;
			}

			private ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return null;
			}
		}

		public static readonly BigInteger q;

		private const int SECP256K1_DEFAULT_COORDS = 2;

		private const int SECP256K1_FE_INTS = 8;

		private static readonly ECFieldElement[] SECP256K1_AFFINE_ZS;

		protected readonly SecP256K1Point m_infinity;

		public virtual BigInteger Q
		{
			get
			{
				return null;
			}
		}

		public override ECPoint Infinity
		{
			get
			{
				return null;
			}
		}

		public override int FieldSize
		{
			get
			{
				return default(int);
			}
		}

		protected override ECCurve CloneCurve()
		{
			return null;
		}

		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
		{
			return null;
		}
	}
}
