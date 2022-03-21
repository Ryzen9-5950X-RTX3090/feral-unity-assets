namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecT131R2Curve : AbstractF2mCurve
	{
		private class SecT131R2LookupTable : AbstractECLookupTable
		{
			private readonly SecT131R2Curve m_outer;

			private readonly ulong[] m_table;

			private readonly int m_size;

			public override int Size
			{
				get
				{
					return default(int);
				}
			}

			internal SecT131R2LookupTable(SecT131R2Curve outer, ulong[] table, int size)
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

		private const int SECT131R2_DEFAULT_COORDS = 6;

		private const int SECT131R2_FE_LONGS = 3;

		private static readonly ECFieldElement[] SECT131R2_AFFINE_ZS;

		protected readonly SecT131R2Point m_infinity;

		public override int FieldSize
		{
			get
			{
				return default(int);
			}
		}

		public override ECPoint Infinity
		{
			get
			{
				return null;
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
