using UnityEngine;

namespace Gaia
{
	public class HeightMap
	{
		public enum CopyType
		{
			AlwaysCopy,
			CopyIfLessThan,
			CopyIfGreaterThan
		}

		protected int m_widthX;

		protected int m_depthZ;

		protected float[,] m_heights;

		protected bool m_isPowerOf2;

		protected float m_widthInvX;

		protected float m_depthInvZ;

		protected float m_statMinVal;

		protected float m_statMaxVal;

		protected double m_statSumVals;

		protected bool m_isDirty;

		protected byte[] m_metaData;

		private const int LEFT = 0;

		private const int RIGHT = 1;

		private const int BOTTOM = 2;

		private const int TOP = 3;

		private const float TIME = 0.2f;

		public float this[int x, int z]
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float this[float x, float z]
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public HeightMap()
		{
		}

		public HeightMap(int width, int depth)
		{
		}

		public HeightMap(float[,] source)
		{
		}

		public HeightMap(float[,,] source, int slice)
		{
		}

		public HeightMap(int[,] source)
		{
		}

		public HeightMap(HeightMap source)
		{
		}

		public HeightMap(string sourceFile)
		{
		}

		public HeightMap(byte[] sourceBytes)
		{
		}

		public int Width()
		{
			return default(int);
		}

		public int Depth()
		{
			return default(int);
		}

		public float MinVal()
		{
			return default(float);
		}

		public float MaxVal()
		{
			return default(float);
		}

		public double SumVal()
		{
			return default(double);
		}

		public byte[] GetMetaData()
		{
			return null;
		}

		public bool IsDirty()
		{
			return default(bool);
		}

		public void SetDirty(bool dirty = true)
		{
		}

		public void ClearDirty()
		{
		}

		public void SetMetaData(byte[] metadata)
		{
		}

		public float[,] Heights()
		{
			return null;
		}

		public float[] Heights1D()
		{
			return null;
		}

		public void SetHeights(float[] heights)
		{
		}

		public void SetHeights(float[,] heights)
		{
		}

		public float GetSafeHeight(int x, int z)
		{
			return default(float);
		}

		public void SetSafeHeight(int x, int z, float height)
		{
		}

		protected float GetInterpolatedHeight(float x, float z)
		{
			return default(float);
		}

		public HeightMap SetHeight(float height)
		{
			return null;
		}

		public void GetHeightRange(ref float minHeight, ref float maxHeight)
		{
		}

		public float GetSlope(int x, int z)
		{
			return default(float);
		}

		public float GetSlope(float x, float z)
		{
			return default(float);
		}

		public float GetSlope_a(float x, float z)
		{
			return default(float);
		}

		public float GetBaseLevel()
		{
			return default(float);
		}

		public bool HasData()
		{
			return default(bool);
		}

		public float[] GetRow(int rowX)
		{
			return null;
		}

		public void SetRow(int rowX, float[] values)
		{
		}

		public float[] GetColumn(int columnZ)
		{
			return null;
		}

		public void SetColumn(int columnZ, float[] values)
		{
		}

		public void Reset()
		{
		}

		public void UpdateStats()
		{
		}

		public HeightMap Smooth(int iterations)
		{
			return null;
		}

		public HeightMap SmoothRadius(int radius)
		{
			return null;
		}

		public HeightMap Convolve(float[,] kernel)
		{
			return null;
		}

		public HeightMap DeNoise(int radius)
		{
			return null;
		}

		public HeightMap GrowEdges(int radius)
		{
			return null;
		}

		public HeightMap ShrinkEdges(int radius)
		{
			return null;
		}

		public HeightMap GetSlopeMap()
		{
			return null;
		}

		public HeightMap Copy(HeightMap heightMap, CopyType copyType = CopyType.AlwaysCopy)
		{
			return null;
		}

		public HeightMap CopyClamped(HeightMap heightMap, float min, float max)
		{
			return null;
		}

		public HeightMap Duplicate()
		{
			return null;
		}

		public HeightMap Invert()
		{
			return null;
		}

		public HeightMap Flip()
		{
			return null;
		}

		public HeightMap Normalise()
		{
			return null;
		}

		public HeightMap ErodeThermal(int iterations, float talusMin, float talusMax, HeightMap hardnessMask)
		{
			return null;
		}

		public HeightMap Quantize(float divisor)
		{
			return null;
		}

		public HeightMap Quantize(float[] startHeights, AnimationCurve[] curves)
		{
			return null;
		}

		public HeightMap CurvatureMap(GaiaConstants.CurvatureType curvatureType)
		{
			return null;
		}

		private float HorizontalCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy)
		{
			return default(float);
		}

		private float VerticalCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy)
		{
			return default(float);
		}

		private float AverageCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy)
		{
			return default(float);
		}

		public HeightMap Aspect(GaiaConstants.AspectType aspectType)
		{
			return null;
		}

		private float Sign(float v)
		{
			return default(float);
		}

		public HeightMap ErodeHydraulic(int iterations, HeightMap hardnessMap, HeightMap rainMap, int rainFrequency, float sedimentDisolveRate, ref HeightMap sedimentMap)
		{
			return null;
		}

		private void CalculateWaterOutflow(HeightMap heightMap, HeightMap waterMap, float[,,] outFlow)
		{
		}

		private void UpdateWaterMap(HeightMap waterMap, float[,,] outFlow)
		{
		}

		public HeightMap FlowMap(int iterations)
		{
			return null;
		}

		private void FillWaterMap(float amount, float[,] waterMap, int width, int height)
		{
		}

		private void ComputeOutflow(float[,] waterMap, float[,,] outFlow, float[] heightMap, int width, int height)
		{
		}

		private void UpdateWaterMap(float[,] waterMap, float[,,] outFlow, int width, int height)
		{
		}

		private void CalculateVelocityField(float[,] velocityMap, float[,,] outFlow, int width, int height)
		{
		}

		private void NormalizeMap(float[,] map, int width, int height)
		{
		}

		public HeightMap SlopeMap()
		{
			return null;
		}

		public HeightMap Add(float value)
		{
			return null;
		}

		public HeightMap Add(HeightMap heightMap)
		{
			return null;
		}

		public HeightMap AddClamped(float value, float min, float max)
		{
			return null;
		}

		public HeightMap AddClamped(HeightMap heightMap, float min, float max)
		{
			return null;
		}

		public HeightMap Subtract(float value)
		{
			return null;
		}

		public HeightMap Subtract(HeightMap heightMap)
		{
			return null;
		}

		public HeightMap SubtractClamped(float value, float min, float max)
		{
			return null;
		}

		public HeightMap SubtractClamped(HeightMap heightMap, float min, float max)
		{
			return null;
		}

		public HeightMap Multiply(float value)
		{
			return null;
		}

		public HeightMap Multiply(HeightMap heightMap)
		{
			return null;
		}

		public HeightMap MultiplyClamped(float value, float min, float max)
		{
			return null;
		}

		public HeightMap MultiplyClamped(HeightMap heightMap, float min, float max)
		{
			return null;
		}

		public HeightMap Divide(float value)
		{
			return null;
		}

		public HeightMap Divide(HeightMap heightMap)
		{
			return null;
		}

		public HeightMap DivideClamped(float value, float min, float max)
		{
			return null;
		}

		public HeightMap DivideClamped(HeightMap heightMap, float min, float max)
		{
			return null;
		}

		public HeightMap Lerp(HeightMap hmNewValues, HeightMap hmLerpMask)
		{
			return null;
		}

		public float Sum()
		{
			return default(float);
		}

		public float Average()
		{
			return default(float);
		}

		public HeightMap Power(float exponent)
		{
			return null;
		}

		public HeightMap Contrast(float contrast)
		{
			return null;
		}

		public void SaveToBinaryFile(string fileName)
		{
		}

		public void LoadFromBinaryFile(string fileName)
		{
		}

		public void LoadFromByteArray(byte[] source)
		{
		}

		public void LoadFromRawFile(string fileName, GaiaConstants.RawByteOrder byteOrder, ref GaiaConstants.RawBitDepth bitDepth, ref int resolution)
		{
		}

		public void DumpMap(float scaleValue, int precision, string spacer, bool flip)
		{
		}

		public void DumpRow(int rowX, float scaleValue, int precision, string spacer)
		{
		}

		public void DumpColumn(int columnZ, float scaleValue, int precision, string spacer)
		{
		}
	}
}
