using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public class JProperty : JContainer
	{
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			internal JToken _token;

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			public bool IsReadOnly
			{
				get
				{
					return default(bool);
				}
			}

			public JToken this[int index]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public void Add(JToken item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(JToken item)
			{
				return default(bool);
			}

			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			public bool Remove(JToken item)
			{
				return default(bool);
			}

			public int IndexOf(JToken item)
			{
				return default(int);
			}

			public void Insert(int index, JToken item)
			{
			}

			public void RemoveAt(int index)
			{
			}
		}

		private readonly JPropertyList _content;

		private readonly string _name;

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public JToken Value
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JTokenType Type
		{
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		public JProperty(JProperty other)
		{
		}

		internal override JToken GetItem(int index)
		{
			return null;
		}

		internal override void SetItem(int index, JToken item)
		{
		}

		internal override bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		internal override void RemoveItemAt(int index)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		internal override bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		internal override void ClearItems()
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		internal JProperty(string name)
		{
		}

		public JProperty(string name, object content)
		{
		}

		public override void WriteTo(JsonWriter writer, JsonConverter[] converters)
		{
		}

		public static JProperty Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
