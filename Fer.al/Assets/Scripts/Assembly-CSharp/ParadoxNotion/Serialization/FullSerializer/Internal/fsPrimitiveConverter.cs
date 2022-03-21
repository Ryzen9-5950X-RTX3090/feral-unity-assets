using System;

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsPrimitiveConverter : fsConverter
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

		private static bool UseBool(Type type)
		{
			return default(bool);
		}

		private static bool UseInt64(Type type)
		{
			return default(bool);
		}

		private static bool UseDouble(Type type)
		{
			return default(bool);
		}

		private static bool UseString(Type type)
		{
			return default(bool);
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
		{
			return default(fsResult);
		}
	}
}
