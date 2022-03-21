using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.PostProcessing
{
	public abstract class Monitor
	{
		internal bool requested;

		public RenderTexture output
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool IsRequestedAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

		internal virtual bool NeedsHalfRes()
		{
			return default(bool);
		}

		protected void CheckOutput(int width, int height)
		{
		}

		internal virtual void OnEnable()
		{
		}

		internal virtual void OnDisable()
		{
		}

		internal abstract void Render(PostProcessRenderContext context);
	}
}
