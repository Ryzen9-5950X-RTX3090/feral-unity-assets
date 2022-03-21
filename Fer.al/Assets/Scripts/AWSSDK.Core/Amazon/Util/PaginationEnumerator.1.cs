using System;
using System.Collections;
using System.Collections.Generic;

namespace Amazon.Util
{
	internal class PaginationEnumerator<U> : IEnumerator<U>, IDisposable, IEnumerator
	{
		private PaginatedResource<U> paginatedResource;

		private int position;

		private static Marker<U> blankSpot;

		private Marker<U> currentSpot;

		private bool started;

		object IEnumerator.Current
		{
			get
			{
				return null;
			}
		}

		public U Current
		{
			get
			{
				return (U)null;
			}
		}

		internal PaginationEnumerator(PaginatedResource<U> paginatedResource)
		{
		}

		public bool MoveNext()
		{
			return default(bool);
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}
}
