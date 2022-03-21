namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecT193R1Curve : AbstractF2mCurve
	{
		private class SecT193R1LookupTable : AbstractECLookupTable
		{
			private readonly SecT193R1Curve m_outer;

			private readonly ulong[] m_table;

			private readonly int m_size;

			public override int Size
			{
				get
				{
					return default(int);
				}
			}

			internal SecT193R1LookupTable(SecT193R1Curve outer, ulong[] table, int size)
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

			private ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return null;
			}
		}

		private const int SECT193R1_DEFAULT_COORDS = 6;

		private const int SECT193R1_FE_LONGS = 4;

		private static readonly ECFieldElement[] SECT193R1_AFFINE_ZS;

		protected readonly SecT193R1Point m_infinity;

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

		public override bool IsKoblitz
		{
			get
			{
				return default(bool);
			}
		}

		public virtual int M
		{
			get
			{
				return default(int);
			}
		}

		public virtual bool IsTrinomial
		{
			get
			{
				return default(bool);
			}
		}

		public virtual int K1
		{
			get
			{
				return default(int);
			}
		}

		public virtual int K2
		{
			get
			{
				return default(int);
			}
		}

		public virtual int K3
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
