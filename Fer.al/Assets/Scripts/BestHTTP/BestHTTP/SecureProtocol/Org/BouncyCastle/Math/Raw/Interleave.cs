namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
{
	internal abstract class Interleave
	{
		private const ulong M32 = 1431655765uL;

		private const ulong M64 = 6148914691236517205uL;

		private const ulong M64R = 12297829382473034410uL;

		internal static uint Expand8to16(uint x)
		{
			return default(uint);
		}

		internal static uint Expand16to32(uint x)
		{
			return default(uint);
		}

		internal static ulong Expand32to64(uint x)
		{
			return default(ulong);
		}

		internal static void Expand64To128(ulong x, ulong[] z, int zOff)
		{
		}

		internal static void Expand64To128Rev(ulong x, ulong[] z, int zOff)
		{
		}

		internal static uint Shuffle(uint x)
		{
			return default(uint);
		}

		internal static ulong Shuffle(ulong x)
		{
			return default(ulong);
		}

		internal static uint Shuffle2(uint x)
		{
			return default(uint);
		}

		internal static uint Unshuffle(uint x)
		{
			return default(uint);
		}

		internal static ulong Unshuffle(ulong x)
		{
			return default(ulong);
		}

		internal static uint Unshuffle2(uint x)
		{
			return default(uint);
		}
	}
}
