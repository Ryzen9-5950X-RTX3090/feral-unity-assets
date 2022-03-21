using System.Collections.Generic;

namespace Gaia.FullSerializer.Internal
{
	public class fsCyclicReferenceManager
	{
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
		{
			public static readonly IEqualityComparer<object> Instance;

			bool IEqualityComparer<object>.Equals(object x, object y)
			{
				return default(bool);
			}

			int IEqualityComparer<object>.GetHashCode(object obj)
			{
				return default(int);
			}
		}

		private Dictionary<object, int> _objectIds;

		private int _nextId;

		private Dictionary<int, object> _marked;

		private int _depth;

		public void Enter()
		{
		}

		public bool Exit()
		{
			return default(bool);
		}

		public object GetReferenceObject(int id)
		{
			return null;
		}

		public void AddReferenceWithId(int id, object reference)
		{
		}

		public int GetReferenceId(object item)
		{
			return default(int);
		}

		public bool IsReference(object item)
		{
			return default(bool);
		}

		public void MarkSerialized(object item)
		{
		}
	}
}
