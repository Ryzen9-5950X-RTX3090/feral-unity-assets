using System.Collections.Generic;
using System.Text;

namespace WW.iOS.Xcode.PBX
{
	internal class KnownSectionBase<T> : SectionBase where T : PBXObjectData, new()
	{
		private Dictionary<string, T> m_Entries;

		private string m_Name;

		public T this[string guid]
		{
			get
			{
				return null;
			}
		}

		public KnownSectionBase(string sectionName)
		{
		}

		public IEnumerable<KeyValuePair<string, T>> GetEntries()
		{
			return null;
		}

		public IEnumerable<string> GetGuids()
		{
			return null;
		}

		public IEnumerable<T> GetObjects()
		{
			return null;
		}

		public override void AddObject(string key, PBXElementDict value)
		{
		}

		public override void WriteSection(StringBuilder sb, GUIDToCommentMap comments)
		{
		}

		public bool HasEntry(string guid)
		{
			return default(bool);
		}

		public void AddEntry(T obj)
		{
		}

		public void RemoveEntry(string guid)
		{
		}
	}
}
