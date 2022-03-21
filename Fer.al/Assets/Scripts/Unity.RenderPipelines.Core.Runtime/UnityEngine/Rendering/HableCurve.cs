using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public class HableCurve
	{
		public class Segment
		{
			public float offsetX;

			public float offsetY;

			public float scaleX;

			public float scaleY;

			public float lnA;

			public float B;

			public float Eval(float x)
			{
				return default(float);
			}
		}

		private struct DirectParams
		{
			internal float x0;

			internal float y0;

			internal float x1;

			internal float y1;

			internal float W;

			internal float overshootX;

			internal float overshootY;

			internal float gamma;
		}

		public class Uniforms
		{
			private HableCurve parent;

			public Vector4 curve
			{
				get
				{
					return default(Vector4);
				}
			}

			public Vector4 toeSegmentA
			{
				get
				{
					return default(Vector4);
				}
			}

			public Vector4 toeSegmentB
			{
				get
				{
					return default(Vector4);
				}
			}

			public Vector4 midSegmentA
			{
				get
				{
					return default(Vector4);
				}
			}

			public Vector4 midSegmentB
			{
				get
				{
					return default(Vector4);
				}
			}

			public Vector4 shoSegmentA
			{
				get
				{
					return default(Vector4);
				}
			}

			public Vector4 shoSegmentB
			{
				get
				{
					return default(Vector4);
				}
			}

			internal Uniforms(HableCurve parent)
			{
			}
		}

		public readonly Segment[] segments;

		public readonly Uniforms uniforms;

		public float whitePoint
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float inverseWhitePoint
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float x0
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float x1
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float Eval(float x)
		{
			return default(float);
		}

		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
		}

		private void InitSegments(DirectParams srcParams)
		{
		}

		private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
		}

		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
		}

		private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			return default(float);
		}
	}
}
