namespace UnityEngine.Rendering.PostProcessing
{
	public abstract class PostProcessEffectRenderer
	{
		protected bool m_ResetHistory;

		public virtual void Init()
		{
		}

		public virtual DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		public virtual void ResetHistory()
		{
		}

		public virtual void Release()
		{
		}

		public abstract void Render(PostProcessRenderContext context);

		internal abstract void SetSettings(PostProcessEffectSettings settings);
	}
}
