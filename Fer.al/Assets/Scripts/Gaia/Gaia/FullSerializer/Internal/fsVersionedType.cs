using System;

namespace Gaia.FullSerializer.Internal
{
	public struct fsVersionedType
	{
		public fsVersionedType[] Ancestors;

		public string VersionString;

		public Type ModelType;

		public object Migrate(object ancestorInstance)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(fsVersionedType a, fsVersionedType b)
		{
			return default(bool);
		}

		public static bool operator !=(fsVersionedType a, fsVersionedType b)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
