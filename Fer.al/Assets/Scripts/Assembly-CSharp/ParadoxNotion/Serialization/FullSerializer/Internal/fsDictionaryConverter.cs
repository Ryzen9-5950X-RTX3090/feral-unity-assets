using System;

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsDictionaryConverter : fsConverter
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

		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}
	}
}
