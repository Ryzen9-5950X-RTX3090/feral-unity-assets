using System;

namespace Gaia.FullSerializer.Internal
{
	public class fsKeyValuePairConverter : fsConverter
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

		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}
	}
}
