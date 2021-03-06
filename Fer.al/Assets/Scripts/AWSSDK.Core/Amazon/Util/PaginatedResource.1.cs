using System;
using System.Collections;
using System.Collections.Generic;

namespace Amazon.Util
{
	internal class PaginatedResource<U> : IEnumerable<U>, IEnumerable
	{
		internal Func<string, Marker<U>> fetcher;

		internal PaginatedResource(Func<string, Marker<U>> fetcher)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<U> GetEnumerator()
		{
			return null;
		}
	}
}
