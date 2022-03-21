namespace MimicJava
{
	public class JavaRandom
	{
		private long _seed;

		private double _nextNextGaussian;

		private bool _haveNextNextGaussian;

		public long Seed
		{
			get
			{
				return default(long);
			}
		}

		public JavaRandom(long seed)
		{
		}

		public void SetSeed(long seed, bool seedNeedsHashing = true)
		{
		}

		private int Next(int bits)
		{
			return default(int);
		}

		public int NextInt()
		{
			return default(int);
		}

		public int NextInt(int bound)
		{
			return default(int);
		}

		public long NextLong()
		{
			return default(long);
		}

		public bool NextBool()
		{
			return default(bool);
		}

		public float NextFloat()
		{
			return default(float);
		}

		public double NextDouble()
		{
			return default(double);
		}

		public double NextGaussian()
		{
			return default(double);
		}
	}
}
