using System.Text;

namespace SimpleJSON
{
	public class JSONNull : JSONNode
	{
		private static JSONNull m_StaticInstance;

		public static bool reuseSameInstance;

		public override JSONNodeType Tag
		{
			get
			{
				return default(JSONNodeType);
			}
		}

		public override bool IsNull
		{
			get
			{
				return default(bool);
			}
		}

		public override string Value
		{
			get
			{
				return null;
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

		public static JSONNull CreateOrGet()
		{
			return null;
		}

		private JSONNull()
		{
		}

		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public override JSONNode Clone()
		{
			return null;
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
