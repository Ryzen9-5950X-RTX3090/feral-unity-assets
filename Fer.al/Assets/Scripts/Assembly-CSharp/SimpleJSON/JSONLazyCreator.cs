using System.Text;

namespace SimpleJSON
{
	internal class JSONLazyCreator : JSONNode
	{
		private JSONNode m_Node;

		private string m_Key;

		public override JSONNodeType Tag
		{
			get
			{
				return default(JSONNodeType);
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

		public override int AsInt
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public override float AsFloat
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override double AsDouble
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public override long AsLong
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public override bool AsBool
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override JSONArray AsArray
		{
			get
			{
				return null;
			}
		}

		public override JSONObject AsObject
		{
			get
			{
				return null;
			}
		}

		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public JSONLazyCreator(JSONNode aNode)
		{
		}

		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		public override void Add(JSONNode aItem)
		{
		}

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		public static bool operator !=(JSONLazyCreator a, object b)
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

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
}
