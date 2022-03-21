using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleJSON
{
	public class JSONObject : JSONNode
	{
		private Dictionary<string, JSONNode> m_Dict;

		private bool inline;

		public override bool Inline
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override JSONNodeType Tag
		{
			get
			{
				return default(JSONNodeType);
			}
		}

		public override bool IsObject
		{
			get
			{
				return default(bool);
			}
		}

		public override JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int Count
		{
			get
			{
				return default(int);
			}
		}

		public override IEnumerable<JSONNode> Children
		{
			[IteratorStateMachine(typeof(<get_Children>d__26))]
			get
			{
				return null;
			}
		}

		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public override JSONNode Clone()
		{
			return null;
		}

		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
}
