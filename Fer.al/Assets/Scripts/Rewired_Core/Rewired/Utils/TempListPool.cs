using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal static class TempListPool
	{
		private static class MFSEKUYwXMGreEkOsVfzghCrToo
		{
			private static ADictionary<Type, List<object>> MoeVudfSYLRJBRYkkoSIpbeREpO;

			private static ADictionary<Type, List<object>> QjgifPkBJDCZcrYisJgbYmodiibI
			{
				get
				{
					return null;
				}
			}

			public static TList<T> HidcSjbKbECBzYyBnCtcFeYTQWme<T>(List<T> P_0)
			{
				return null;
			}

			public static void yoRCItCPChIXsxwWNFdfdtYCJTlo<T>(TList<T> P_0)
			{
			}

			public static void vMfAexzdpfzhXKkyGdAHmJVnQEr()
			{
			}

			public static void vMfAexzdpfzhXKkyGdAHmJVnQEr(Type P_0)
			{
			}
		}

		[CustomObfuscation]
		[CustomClassObfuscation]
		internal interface ITListSetter<T>
		{
			void SetList(List<T> list);
		}

		[CustomObfuscation]
		[CustomClassObfuscation]
		internal sealed class TList<T> : IDisposable, ITListSetter<T>
		{
			private List<T> QDdpegUvplbleFLzyPPIlUNzJOf;

			private bool vEblpmllYIOuQHCXVghuIpihdSG;

			public List<T> list
			{
				get
				{
					return null;
				}
			}

			public static TList<T> Create()
			{
				return null;
			}

			private TList()
			{
			}

			public void Dispose()
			{
			}

			private void yoRCItCPChIXsxwWNFdfdtYCJTlo()
			{
			}

			void ITListSetter<T>.SetList(List<T> P_0)
			{
			}

			private static void vapHFBEsowtEKFLgbLLbKSuLarb()
			{
			}

			public static implicit operator List<T>(TList<T> obj)
			{
				return null;
			}
		}

		private const int QuobDfExlYAAxiZQbzmJguvSzUER = 3;

		private const int IsDByJwIkEJqdeqHPxuWryIQzjH = 10;

		private static ADictionary<Type, List<IList>> KJAwdZewowmVZDMHhyitjyzKemB;

		private static ADictionary<Type, List<IList>> lists
		{
			get
			{
				return null;
			}
		}

		public static TList<T> GetTList<T>()
		{
			return null;
		}

		public static TList<T> GetTList<T>(int capacity)
		{
			return null;
		}

		public static void ReturnTList<T>(TList<T> tList)
		{
		}

		public static List<T> Get<T>()
		{
			return null;
		}

		public static List<T> Get<T>(int capacity)
		{
			return null;
		}

		public static void Return<T>(List<T> list)
		{
		}

		public static void Return<T>(List<T> list1, List<T> list2)
		{
		}

		public static void Return<T>(List<T> list1, List<T> list2, List<T> list3)
		{
		}

		public static void Clear()
		{
		}

		public static void Clear(Type listType)
		{
		}
	}
}
