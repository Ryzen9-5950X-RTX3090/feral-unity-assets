using System;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal static class MiscTools
	{
		private static uint ofQooKShNmkNpAgPPoWpiAHWHqM;

		private static uint lnmyilEHNcIuQUFyrhGLmNytIts;

		private static uint LFhffykLeDtERfvooOZDoWDGfGh;

		private static int vXyQXKAIVXwFbLVLmpvNZTBfaPC;

		private static int faaLllyvnSjjAjPALFmOZPdBUkV;

		private static int LasfgtUVulhlygDDnoinOMhsnXi;

		public static object Clone(object obj)
		{
			return null;
		}

		public static T Clone<T>(T obj) where T : class, ICloneable
		{
			return null;
		}

		public static T DeepClone<T>(T obj) where T : class, IDeepCloneable
		{
			return null;
		}

		public static T DeepClone<T>(T obj, bool createIfNull) where T : class, IDeepCloneable, new()
		{
			return null;
		}

		public static T[] DeepClone<T>(T[] obj) where T : class, IDeepCloneable
		{
			return null;
		}

		public static List<T> DeepClone<T>(List<T> obj) where T : class, IDeepCloneable
		{
			return null;
		}

		public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary) where TValue : class, IDeepCloneable
		{
			return null;
		}

		public static Guid CreateGuidHashSHA256(string text)
		{
			return default(Guid);
		}

		public static Guid CreateGuidHashSHA1(string text)
		{
			return default(Guid);
		}

		public static Guid CreateHIDProductGuid(int vendorId, int productId)
		{
			return default(Guid);
		}

		public static uint Tick(uint counter)
		{
			return default(uint);
		}

		public static int Tick(int counter)
		{
			return default(int);
		}

		public static uint TickPrev(uint counter)
		{
			return default(uint);
		}

		public static int TickPrev(int counter)
		{
			return default(int);
		}

		public static bool IsTickValid(uint tick)
		{
			return default(bool);
		}

		public static bool IsTickValid(int tick)
		{
			return default(bool);
		}

		public static bool IsTickNewer(uint tick1, uint tick2)
		{
			return default(bool);
		}

		public static bool IsTickNewer(int tick1, int tick2)
		{
			return default(bool);
		}

		public static bool IsTickNewerOrEqualTo(uint tick1, uint tick2)
		{
			return default(bool);
		}

		public static bool IsTickNewerOrEqualTo(int tick1, int tick2)
		{
			return default(bool);
		}

		public static void Swap<T>(ref T a, ref T b)
		{
		}

		public static long ToLongUnchecked(object value)
		{
			return default(long);
		}

		public static bool IsValidGuid(string guid)
		{
			return default(bool);
		}
	}
}
