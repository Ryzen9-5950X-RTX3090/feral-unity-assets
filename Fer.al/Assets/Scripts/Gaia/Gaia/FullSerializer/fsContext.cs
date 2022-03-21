using System;
using System.Collections.Generic;

namespace Gaia.FullSerializer
{
	public sealed class fsContext
	{
		private readonly Dictionary<Type, object> _contextObjects;

		public void Reset()
		{
		}

		public void Set<T>(T obj)
		{
		}

		public bool Has<T>()
		{
			return default(bool);
		}

		public T Get<T>()
		{
			return (T)null;
		}
	}
}
