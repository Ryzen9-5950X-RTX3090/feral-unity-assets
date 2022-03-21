using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.PostProcessing
{
	internal sealed class LogHistogram
	{
		public const int rangeMin = -9;

		public const int rangeMax = 9;

		private const int k_Bins = 128;

		public ComputeBuffer data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Generate(PostProcessRenderContext context)
		{
		}

		public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
		{
			return default(Vector4);
		}

		public void Release()
		{
		}
	}
}
