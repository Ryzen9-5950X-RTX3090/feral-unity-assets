using UnityEngine;

namespace AmplifyImpostors
{
	public static class Texture2DEx
	{
		public enum Compression
		{
			None,
			RLE
		}

		private static readonly byte[] Footer;

		public static byte[] EncodeToTGA(this Texture2D tex, Compression compression = Compression.RLE)
		{
			return null;
		}

		private static bool Equals(Color32 first, Color32 second)
		{
			return default(bool);
		}
	}
}
