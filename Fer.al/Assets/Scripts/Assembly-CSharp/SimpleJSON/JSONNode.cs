using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleJSON
{
	public abstract class JSONNode
	{
		public struct Enumerator
		{
			private enum Type
			{
				None,
				Array,
				Object
			}

			private Type type;

			private Dictionary<string, JSONNode>.Enumerator m_Object;

			private List<JSONNode>.Enumerator m_Array;

			public bool IsValid
			{
				get
				{
					return default(bool);
				}
			}

			public KeyValuePair<string, JSONNode> Current
			{
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}
		}

		public struct ValueEnumerator
		{
			private Enumerator m_Enumerator;

			public JSONNode Current
			{
				get
				{
					return null;
				}
			}

			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		public struct KeyEnumerator
		{
			private Enumerator m_Enumerator;

			public string Current
			{
				get
				{
					return null;
				}
			}

			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			private JSONNode m_Node;

			private Enumerator m_Enumerator;

			public KeyValuePair<string, JSONNode> Current
			{
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			internal LinqEnumerator(JSONNode aNode)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Dispose()
			{
			}

			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			public void Reset()
			{
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static bool forceASCII;

		public static bool longAsString;

		public static bool allowLineComments;

		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		public abstract JSONNodeType Tag { get; }

		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual int Count
		{
			get
			{
				return default(int);
			}
		}

		public virtual bool IsNumber
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsString
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsBoolean
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsNull
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsArray
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsObject
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool Inline
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual IEnumerable<JSONNode> Children
		{
			[IteratorStateMachine(typeof(<get_Children>d__42))]
			get
			{
				return null;
			}
		}

		public IEnumerable<JSONNode> DeepChildren
		{
			[IteratorStateMachine(typeof(<get_DeepChildren>d__44))]
			get
			{
				return null;
			}
		}

		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			get
			{
				return null;
			}
		}

		public KeyEnumerator Keys
		{
			get
			{
				return default(KeyEnumerator);
			}
		}

		public ValueEnumerator Values
		{
			get
			{
				return default(ValueEnumerator);
			}
		}

		public virtual double AsDouble
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public virtual int AsInt
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public virtual bool AsBool
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual long AsLong
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public virtual JSONArray AsArray
		{
			get
			{
				return null;
			}
		}

		public virtual JSONObject AsObject
		{
			get
			{
				return null;
			}
		}

		internal static StringBuilder EscapeBuilder
		{
			get
			{
				return null;
			}
		}

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public virtual JSONNode Clone()
		{
			return null;
		}

		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(int aIndent)
		{
			return null;
		}

		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		public abstract Enumerator GetEnumerator();

		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		public static bool operator !=(JSONNode a, object b)
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

		internal static string Escape(string aText)
		{
			return null;
		}

		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
