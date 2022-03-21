using System;

namespace Gaia.FullSerializer.Internal
{
	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor
	{
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}
	}
}
