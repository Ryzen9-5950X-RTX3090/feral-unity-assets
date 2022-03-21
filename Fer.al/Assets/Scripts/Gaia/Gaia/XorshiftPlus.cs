using UnityEngine;

namespace Gaia
{
	public class XorshiftPlus
	{
		private const ulong m_A_Init = 181353uL;

		private const ulong m_B_Init = 7uL;

		public int m_seed;

		public ulong m_stateA;

		public ulong m_stateB;

		public XorshiftPlus(int seed = 1)
		{
		}

		public void Reset()
		{
		}

		public void Reset(int seed)
		{
		}

		public void Reset(ulong stateA, ulong stateB)
		{
		}

		public void GetState(out int seed, out ulong stateA, out ulong stateB)
		{
		}

		public float Next()
		{
			return default(float);
		}

		public int NextInt()
		{
			return default(int);
		}

		public float Next(float min, float max)
		{
			return default(float);
		}

		public int Next(int min, int max)
		{
			return default(int);
		}

		public Vector3 NextVector()
		{
			return default(Vector3);
		}

		public Vector3 NextVector(float min, float max)
		{
			return default(Vector3);
		}
	}
}
