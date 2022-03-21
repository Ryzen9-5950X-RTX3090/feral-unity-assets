using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class XRGraphics
	{
		public enum StereoRenderingMode
		{
			MultiPass,
			SinglePass,
			SinglePassInstanced,
			SinglePassMultiView
		}

		public static float eyeTextureResolutionScale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static float renderViewportScale
		{
			get
			{
				return default(float);
			}
		}

		public static bool enabled
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isDeviceActive
		{
			get
			{
				return default(bool);
			}
		}

		public static string loadedDeviceName
		{
			get
			{
				return null;
			}
		}

		public static string[] supportedDevices
		{
			get
			{
				return null;
			}
		}

		public static StereoRenderingMode stereoRenderingMode
		{
			get
			{
				return default(StereoRenderingMode);
			}
		}

		public static RenderTextureDescriptor eyeTextureDesc
		{
			get
			{
				return default(RenderTextureDescriptor);
			}
		}

		public static int eyeTextureWidth
		{
			get
			{
				return default(int);
			}
		}

		public static int eyeTextureHeight
		{
			get
			{
				return default(int);
			}
		}
	}
}
