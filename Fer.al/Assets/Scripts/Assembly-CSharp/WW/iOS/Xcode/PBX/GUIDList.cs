using System.Collections;
using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class GUIDList : IEnumerable<string>, IEnumerable
	{
		private List<string> m_List;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public GUIDList()
		{
		}

		public GUIDList(List<string> data)
		{
		}

		public static implicit operator List<string>(GUIDList list)
		{
			return null;
		}

		public static implicit operator GUIDList(List<string> data)
		{
			return null;
		}

		public void AddGUID(string guid)
		{
		}

		public void RemoveGUID(string guid)
		{
		}

		public bool Contains(string guid)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
