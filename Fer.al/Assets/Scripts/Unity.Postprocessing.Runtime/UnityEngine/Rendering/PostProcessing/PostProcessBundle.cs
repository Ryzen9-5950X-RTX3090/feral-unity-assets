using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PostProcessBundle
	{
		private PostProcessEffectRenderer m_Renderer;

		public PostProcessAttribute attribute
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

		public PostProcessEffectSettings settings
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

		internal PostProcessEffectRenderer renderer
		{
			get
			{
				return null;
			}
		}

		internal PostProcessBundle(PostProcessEffectSettings settings)
		{
		}

		internal void Release()
		{
		}

		internal void ResetHistory()
		{
		}

		internal T CastSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		internal T CastRenderer<T>() where T : PostProcessEffectRenderer
		{
			return null;
		}
	}
}
