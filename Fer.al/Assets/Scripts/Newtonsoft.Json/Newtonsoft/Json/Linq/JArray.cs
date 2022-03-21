using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return null;
			}
		}

		public override JTokenType Type
		{
			get
			{
				return default(JTokenType);
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

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public JArray()
		{
		}

		public JArray(JArray other)
		{
		}

		public JArray(object content)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, JsonConverter[] converters)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return default(int);
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

		public IEnumerator<JToken> GetEnumerator()
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
	}
}
