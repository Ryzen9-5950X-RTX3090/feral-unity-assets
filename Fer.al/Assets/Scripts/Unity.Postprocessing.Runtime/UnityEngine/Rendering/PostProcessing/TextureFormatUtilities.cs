using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	public static class TextureFormatUtilities
	{
		private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

		private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

		private static Dictionary<int, bool> s_SupportedTextureFormats;

		static TextureFormatUtilities()
		{
		}

		private static bool IsObsolete(object value)
		{
			return default(bool);
		}

		public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
		{
			return default(RenderTextureFormat);
		}

		internal static bool IsSupported(this RenderTextureFormat format)
		{
			return default(bool);
		}

		internal static bool IsSupported(this TextureFormat format)
		{
			return default(bool);
		}
	}
}
