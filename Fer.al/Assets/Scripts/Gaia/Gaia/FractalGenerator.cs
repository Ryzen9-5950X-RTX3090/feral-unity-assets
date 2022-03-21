namespace Gaia
{
	public class FractalGenerator
	{
		public enum Fractals
		{
			Perlin,
			Billow,
			RidgeMulti
		}

		private delegate float GetCalcValue(float x, float z);

		private float m_seed;

		private int m_octaves;

		private float m_persistence;

		private float m_frequency;

		private float m_lacunarity;

		private float m_XOffset;

		private float m_ZOffset;

		private float m_YOffset;

		private Fractals m_fractalType;

		private float[] m_spectralWeights;

		private GetCalcValue m_noiseCalculator;

		public float Seed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int Octaves
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float Persistence
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float Frequency
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float Lacunarity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float XOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ZOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float YOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Fractals FractalType
		{
			get
			{
				return default(Fractals);
			}
			set
			{
			}
		}

		public FractalGenerator()
		{
		}

		public FractalGenerator(float frequency, float lacunarity, int octaves, float persistance, float seed, Fractals type)
		{
		}

		public void SetDefaults()
		{
		}

		public float GetValue(float x, float z)
		{
			return default(float);
		}

		public double GetValue(double x, double z)
		{
			return default(double);
		}

		public float GetNormalisedValue(float x, float z)
		{
			return default(float);
		}

		public double GetNormalisedValue(double x, double z)
		{
			return default(double);
		}

		public float GetValue_Perlin(float x, float z)
		{
			return default(float);
		}

		public float GetValue_Billow(float x, float z)
		{
			return default(float);
		}

		public float GetValue_RidgedMulti(float x, float z)
		{
			return default(float);
		}

		private void CalcSpectralWeights()
		{
		}
	}
}
