using System;

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsForwardConverter : fsConverter
	{
		private string _memberName;

		public fsForwardConverter(fsForwardAttribute attribute)
		{
		}

		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		private fsResult GetProperty(object instance, out fsMetaProperty property)
		{
			return default(fsResult);
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}
	}
}
