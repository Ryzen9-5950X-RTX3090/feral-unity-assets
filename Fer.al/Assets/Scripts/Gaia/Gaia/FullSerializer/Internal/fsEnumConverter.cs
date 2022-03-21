using System;

namespace Gaia.FullSerializer.Internal
{
	public class fsEnumConverter : fsConverter
	{
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		private static bool ArrayContains<T>(T[] values, T value)
		{
			return default(bool);
		}
	}
}
