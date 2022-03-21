using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Preserve]
	public sealed class SubpixelMorphologicalAntialiasing
	{
		private enum Pass
		{
			EdgeDetection = 0,
			BlendWeights = 3,
			NeighborhoodBlending = 6
		}

		public enum Quality
		{
			Low,
			Medium,
			High
		}

		[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
		public Quality quality;

		public bool IsSupported()
		{
			return default(bool);
		}

		internal void Render(PostProcessRenderContext context)
		{
		}
	}
}
