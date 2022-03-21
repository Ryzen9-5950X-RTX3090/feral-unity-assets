using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class PropertyCommentChecker
	{
		private int m_Level;

		private bool m_All;

		private List<List<string>> m_Props;

		protected PropertyCommentChecker(int level, List<List<string>> props)
		{
		}

		public PropertyCommentChecker()
		{
		}

		public PropertyCommentChecker(IEnumerable<string> props)
		{
		}

		private bool CheckContained(string prop)
		{
			return default(bool);
		}

		public bool CheckStringValueInArray(string value)
		{
			return default(bool);
		}

		public bool CheckKeyInDict(string key)
		{
			return default(bool);
		}

		public bool CheckStringValueInDict(string key, string value)
		{
			return default(bool);
		}

		public PropertyCommentChecker NextLevel(string prop)
		{
			return null;
		}
	}
}
