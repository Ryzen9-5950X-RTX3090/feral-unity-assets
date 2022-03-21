using System.Text;

namespace SimpleJSON
{
	public class JSONNumber : JSONNode
	{
		private double m_Data;

		public override JSONNodeType Tag
		{
			get
			{
				return default(JSONNodeType);
			}
		}

		public override bool IsNumber
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

		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public JSONNumber(double aData)
		{
		}

		public JSONNumber(string aData)
		{
		}

		public override JSONNode Clone()
		{
			return null;
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		private static bool IsNumeric(object value)
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
	}
}
