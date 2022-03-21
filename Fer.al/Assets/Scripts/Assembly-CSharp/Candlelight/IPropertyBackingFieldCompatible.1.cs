using System;

namespace Candlelight
{
	public interface IPropertyBackingFieldCompatible<T> : IPropertyBackingFieldCompatible, ICloneable, IEquatable<T> where T : struct
	{
	}
}
