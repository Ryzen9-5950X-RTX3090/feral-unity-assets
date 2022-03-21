using System;
using System.Collections;
using System.Reflection;

namespace Gaia.FullSerializer.Internal
{
	public class fsIEnumerableConverter : fsConverter
	{
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		private bool IsStack(Type type)
		{
			return default(bool);
		}

		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		private static int HintSize(IEnumerable collection)
		{
			return default(int);
		}

		private static Type GetElementType(Type objectType)
		{
			return null;
		}

		private static void TryClear(Type type, object instance)
		{
		}

		private static int TryGetExistingSize(Type type, object instance)
		{
			return default(int);
		}

		private static MethodInfo GetAddMethod(Type type)
		{
			return null;
		}
	}
}
