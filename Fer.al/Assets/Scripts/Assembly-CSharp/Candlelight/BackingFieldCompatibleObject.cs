using System;

namespace Candlelight
{
	public abstract class BackingFieldCompatibleObject : IPropertyBackingFieldCompatible, ICloneable
	{
		public abstract object Clone();

		public abstract int GetSerializedPropertiesHash();
	}
}
