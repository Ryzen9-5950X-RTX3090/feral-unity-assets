using System;

namespace Candlelight
{
	public interface IPropertyBackingFieldCompatible : ICloneable
	{
		int GetSerializedPropertiesHash();
	}
}
