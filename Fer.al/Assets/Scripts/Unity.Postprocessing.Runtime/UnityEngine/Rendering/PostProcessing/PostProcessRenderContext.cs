using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PostProcessRenderContext
	{
		public enum StereoRenderingMode
		{
			MultiPass,
			SinglePass,
			SinglePassInstanced,
			SinglePassMultiview
		}

		private Camera m_Camera;

		internal PropertySheet uberSheet;

		internal Texture autoExposureTexture;

		internal LogHistogram logHistogram;

		internal Texture logLut;

		internal AutoExposure autoExposure;

		internal int bloomBufferNameID;

		internal bool physicalCamera;

		private RenderTextureDescriptor m_sourceDescriptor;

		public Camera camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CommandBuffer command
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RenderTargetIdentifier source
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RenderTargetIdentifier destination
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RenderTextureFormat sourceFormat
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTextureFormat);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool flip
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PostProcessResources resources
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public PropertySheetFactory propertySheets
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Dictionary<string, object> userData
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

		public PostProcessDebugLayer debugLayer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int width
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int height
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool stereoActive
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int xrActiveEye
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int numberOfEyes
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StereoRenderingMode stereoRenderingMode
		{
			[CompilerGenerated]
			get
			{
				return default(StereoRenderingMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int screenWidth
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int screenHeight
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isSceneView
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public PostProcessLayer.Antialiasing antialiasing
		{
			[CompilerGenerated]
			get
			{
				return default(PostProcessLayer.Antialiasing);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public TemporalAntialiasing temporalAntialiasing
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public void Reset()
		{
		}

		public bool IsTemporalAntialiasingActive()
		{
			return default(bool);
		}

		public bool IsDebugOverlayEnabled(DebugOverlay overlay)
		{
			return default(bool);
		}

		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
		}

		internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
		{
			return default(RenderTextureDescriptor);
		}

		public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
		}

		public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
		{
			return null;
		}

		public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled)
		{
		}
	}
}
