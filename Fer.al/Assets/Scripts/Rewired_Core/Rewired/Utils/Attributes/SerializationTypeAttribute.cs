using System;

namespace Rewired.Utils.Attributes
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializationTypeAttribute : Attribute
	{
		public enum SerializationType
		{
			Default,
			Object
		}

		private SerializationType _serializationType;

		public SerializationType serializationType
		{
			get
			{
				return default(SerializationType);
			}
		}

		public SerializationTypeAttribute(SerializationType serializationType)
		{
		}
	}
}
