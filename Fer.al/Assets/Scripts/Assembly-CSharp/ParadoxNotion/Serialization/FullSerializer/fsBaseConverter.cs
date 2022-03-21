using System;
using System.Collections.Generic;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public abstract class fsBaseConverter
	{
		public fsSerializer Serializer;

		public virtual object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public virtual bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		public virtual bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

		protected fsResult FailExpectedType(fsData data, fsDataType[] types)
		{
			return default(fsResult);
		}

		protected fsResult CheckType(fsData data, fsDataType type)
		{
			return default(fsResult);
		}

		protected fsResult CheckKey(fsData data, string key, out fsData subitem)
		{
			return default(fsResult);
		}

		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
		{
			return default(fsResult);
		}

		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
		{
			return default(fsResult);
		}

		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
		{
			return default(fsResult);
		}
	}
}
