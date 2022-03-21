using System;

namespace Gaia.FullSerializer.Internal
{
	public class fsSerializationCallbackProcessor : fsObjectProcessor
	{
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		public override void OnAfterSerialize(Type storageType, object instance, ref fsData data)
		{
		}

		public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
		{
		}

		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}
	}
}
