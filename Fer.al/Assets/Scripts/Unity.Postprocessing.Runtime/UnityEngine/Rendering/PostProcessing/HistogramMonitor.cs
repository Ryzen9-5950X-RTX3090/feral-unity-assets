using System;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public sealed class HistogramMonitor : Monitor
	{
		public enum Channel
		{
			Red,
			Green,
			Blue,
			Master
		}

		public int width;

		public int height;

		public Channel channel;

		private ComputeBuffer m_Data;

		private const int k_NumBins = 256;

		private const int k_ThreadGroupSizeX = 16;

		private const int k_ThreadGroupSizeY = 16;

		internal override void OnDisable()
		{
		}

		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		internal override void Render(PostProcessRenderContext context)
		{
		}
	}
}
