using System;
using System.Collections.Generic;

namespace BestHTTP.Caching
{
	public sealed class UriComparer : IEqualityComparer<Uri>
	{
		public bool Equals(Uri x, Uri y)
		{
			return default(bool);
		}

		public int GetHashCode(Uri uri)
		{
			return default(int);
		}
	}
}
