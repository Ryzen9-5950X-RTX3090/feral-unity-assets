public class FastNoise
{
	public enum NoiseType
	{
		Value,
		ValueFractal,
		Perlin,
		PerlinFractal,
		Simplex,
		SimplexFractal,
		Cellular,
		WhiteNoise,
		Cubic,
		CubicFractal
	}

	public enum Interp
	{
		Linear,
		Hermite,
		Quintic
	}

	public enum FractalType
	{
		FBM,
		Billow,
		RigidMulti
	}

	public enum CellularDistanceFunction
	{
		Euclidean,
		Manhattan,
		Natural
	}

	public enum CellularReturnType
	{
		CellValue,
		NoiseLookup,
		Distance,
		Distance2,
		Distance2Add,
		Distance2Sub,
		Distance2Mul,
		Distance2Div
	}

	private struct Float2
	{
		public readonly float x;

		public readonly float y;

		public Float2(float x, float y)
		{
		}
	}

	private struct Float3
	{
		public readonly float x;

		public readonly float y;

		public readonly float z;

		public Float3(float x, float y, float z)
		{
		}
	}

	private const short FN_INLINE = 256;

	private const int FN_CELLULAR_INDEX_MAX = 3;

	private int m_seed;

	private float m_frequency;

	private Interp m_interp;

	private NoiseType m_noiseType;

	private int m_octaves;

	private float m_lacunarity;

	private float m_gain;

	private FractalType m_fractalType;

	private float m_fractalBounding;

	private CellularDistanceFunction m_cellularDistanceFunction;

	private CellularReturnType m_cellularReturnType;

	private FastNoise m_cellularNoiseLookup;

	private int m_cellularDistanceIndex0;

	private int m_cellularDistanceIndex1;

	private float m_cellularJitter;

	private float m_gradientPerturbAmp;

	private static readonly Float2[] GRAD_2D;

	private static readonly Float3[] GRAD_3D;

	private static readonly Float2[] CELL_2D;

	private static readonly Float3[] CELL_3D;

	private const int X_PRIME = 1619;

	private const int Y_PRIME = 31337;

	private const int Z_PRIME = 6971;

	private const int W_PRIME = 1013;

	private const float F3 = 1f / 3f;

	private const float G3 = 1f / 6f;

	private const float G33 = -0.5f;

	private const float F2 = 0.5f;

	private const float G2 = 0.25f;

	private static readonly byte[] SIMPLEX_4D;

	private const float F4 = 0.309017f;

	private const float G4 = 0.1381966f;

	private const float CUBIC_3D_BOUNDING = 8f / 27f;

	private const float CUBIC_2D_BOUNDING = 4f / 9f;

	public FastNoise(int seed = 1337)
	{
	}

	public static float GetDecimalType()
	{
		return default(float);
	}

	public int GetSeed()
	{
		return default(int);
	}

	public void SetSeed(int seed)
	{
	}

	public void SetFrequency(float frequency)
	{
	}

	public void SetInterp(Interp interp)
	{
	}

	public void SetNoiseType(NoiseType noiseType)
	{
	}

	public void SetFractalOctaves(int octaves)
	{
	}

	public void SetFractalLacunarity(float lacunarity)
	{
	}

	public void SetFractalGain(float gain)
	{
	}

	public void SetFractalType(FractalType fractalType)
	{
	}

	public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction)
	{
	}

	public void SetCellularReturnType(CellularReturnType cellularReturnType)
	{
	}

	public void SetCellularDistance2Indicies(int cellularDistanceIndex0, int cellularDistanceIndex1)
	{
	}

	public void SetCellularJitter(float cellularJitter)
	{
	}

	public void SetCellularNoiseLookup(FastNoise noise)
	{
	}

	public void SetGradientPerturbAmp(float gradientPerturbAmp)
	{
	}

	private static int FastFloor(float f)
	{
		return default(int);
	}

	private static int FastRound(float f)
	{
		return default(int);
	}

	private static float Lerp(float a, float b, float t)
	{
		return default(float);
	}

	private static float InterpHermiteFunc(float t)
	{
		return default(float);
	}

	private static float InterpQuinticFunc(float t)
	{
		return default(float);
	}

	private static float CubicLerp(float a, float b, float c, float d, float t)
	{
		return default(float);
	}

	private void CalculateFractalBounding()
	{
	}

	private static int Hash2D(int seed, int x, int y)
	{
		return default(int);
	}

	private static int Hash3D(int seed, int x, int y, int z)
	{
		return default(int);
	}

	private static int Hash4D(int seed, int x, int y, int z, int w)
	{
		return default(int);
	}

	private static float ValCoord2D(int seed, int x, int y)
	{
		return default(float);
	}

	private static float ValCoord3D(int seed, int x, int y, int z)
	{
		return default(float);
	}

	private static float ValCoord4D(int seed, int x, int y, int z, int w)
	{
		return default(float);
	}

	private static float GradCoord2D(int seed, int x, int y, float xd, float yd)
	{
		return default(float);
	}

	private static float GradCoord3D(int seed, int x, int y, int z, float xd, float yd, float zd)
	{
		return default(float);
	}

	private static float GradCoord4D(int seed, int x, int y, int z, int w, float xd, float yd, float zd, float wd)
	{
		return default(float);
	}

	public float GetNoise(float x, float y, float z)
	{
		return default(float);
	}

	public float GetNoise(float x, float y)
	{
		return default(float);
	}

	private int FloatCast2Int(float f)
	{
		return default(int);
	}

	public float GetWhiteNoise(float x, float y, float z, float w)
	{
		return default(float);
	}

	public float GetWhiteNoise(float x, float y, float z)
	{
		return default(float);
	}

	public float GetWhiteNoise(float x, float y)
	{
		return default(float);
	}

	public float GetWhiteNoiseInt(int x, int y, int z, int w)
	{
		return default(float);
	}

	public float GetWhiteNoiseInt(int x, int y, int z)
	{
		return default(float);
	}

	public float GetWhiteNoiseInt(int x, int y)
	{
		return default(float);
	}

	public float GetValueFractal(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleValueFractalFBM(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleValueFractalBillow(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleValueFractalRigidMulti(float x, float y, float z)
	{
		return default(float);
	}

	public float GetValue(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleValue(int seed, float x, float y, float z)
	{
		return default(float);
	}

	public float GetValueFractal(float x, float y)
	{
		return default(float);
	}

	private float SingleValueFractalFBM(float x, float y)
	{
		return default(float);
	}

	private float SingleValueFractalBillow(float x, float y)
	{
		return default(float);
	}

	private float SingleValueFractalRigidMulti(float x, float y)
	{
		return default(float);
	}

	public float GetValue(float x, float y)
	{
		return default(float);
	}

	private float SingleValue(int seed, float x, float y)
	{
		return default(float);
	}

	public float GetPerlinFractal(float x, float y, float z)
	{
		return default(float);
	}

	private float SinglePerlinFractalFBM(float x, float y, float z)
	{
		return default(float);
	}

	private float SinglePerlinFractalBillow(float x, float y, float z)
	{
		return default(float);
	}

	private float SinglePerlinFractalRigidMulti(float x, float y, float z)
	{
		return default(float);
	}

	public float GetPerlin(float x, float y, float z)
	{
		return default(float);
	}

	private float SinglePerlin(int seed, float x, float y, float z)
	{
		return default(float);
	}

	public float GetPerlinFractal(float x, float y)
	{
		return default(float);
	}

	private float SinglePerlinFractalFBM(float x, float y)
	{
		return default(float);
	}

	private float SinglePerlinFractalBillow(float x, float y)
	{
		return default(float);
	}

	private float SinglePerlinFractalRigidMulti(float x, float y)
	{
		return default(float);
	}

	public float GetPerlin(float x, float y)
	{
		return default(float);
	}

	private float SinglePerlin(int seed, float x, float y)
	{
		return default(float);
	}

	public float GetSimplexFractal(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleSimplexFractalFBM(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleSimplexFractalBillow(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleSimplexFractalRigidMulti(float x, float y, float z)
	{
		return default(float);
	}

	public float GetSimplex(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleSimplex(int seed, float x, float y, float z)
	{
		return default(float);
	}

	public float GetSimplexFractal(float x, float y)
	{
		return default(float);
	}

	private float SingleSimplexFractalFBM(float x, float y)
	{
		return default(float);
	}

	private float SingleSimplexFractalBillow(float x, float y)
	{
		return default(float);
	}

	private float SingleSimplexFractalRigidMulti(float x, float y)
	{
		return default(float);
	}

	public float GetSimplex(float x, float y)
	{
		return default(float);
	}

	private float SingleSimplex(int seed, float x, float y)
	{
		return default(float);
	}

	public float GetSimplex(float x, float y, float z, float w)
	{
		return default(float);
	}

	private float SingleSimplex(int seed, float x, float y, float z, float w)
	{
		return default(float);
	}

	public float GetCubicFractal(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleCubicFractalFBM(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleCubicFractalBillow(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleCubicFractalRigidMulti(float x, float y, float z)
	{
		return default(float);
	}

	public float GetCubic(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleCubic(int seed, float x, float y, float z)
	{
		return default(float);
	}

	public float GetCubicFractal(float x, float y)
	{
		return default(float);
	}

	private float SingleCubicFractalFBM(float x, float y)
	{
		return default(float);
	}

	private float SingleCubicFractalBillow(float x, float y)
	{
		return default(float);
	}

	private float SingleCubicFractalRigidMulti(float x, float y)
	{
		return default(float);
	}

	public float GetCubic(float x, float y)
	{
		return default(float);
	}

	private float SingleCubic(int seed, float x, float y)
	{
		return default(float);
	}

	public float GetCellular(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleCellular(float x, float y, float z)
	{
		return default(float);
	}

	private float SingleCellular2Edge(float x, float y, float z)
	{
		return default(float);
	}

	public float GetCellular(float x, float y)
	{
		return default(float);
	}

	private float SingleCellular(float x, float y)
	{
		return default(float);
	}

	private float SingleCellular2Edge(float x, float y)
	{
		return default(float);
	}

	public void GradientPerturb(ref float x, ref float y, ref float z)
	{
	}

	public void GradientPerturbFractal(ref float x, ref float y, ref float z)
	{
	}

	private void SingleGradientPerturb(int seed, float perturbAmp, float frequency, ref float x, ref float y, ref float z)
	{
	}

	public void GradientPerturb(ref float x, ref float y)
	{
	}

	public void GradientPerturbFractal(ref float x, ref float y)
	{
	}

	private void SingleGradientPerturb(int seed, float perturbAmp, float frequency, ref float x, ref float y)
	{
	}
}
