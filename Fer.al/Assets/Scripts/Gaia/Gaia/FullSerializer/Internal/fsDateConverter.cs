using System;

namespace Gaia.FullSerializer.Internal
{
	public class fsDateConverter : fsConverter
	{
		private const string DefaultDateTimeFormatString = "o";

		private const string DateTimeOffsetFormatString = "o";

		private string DateTimeFormatString
		{
			get
			{
				return null;
			}
		}

		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}
	}
}
