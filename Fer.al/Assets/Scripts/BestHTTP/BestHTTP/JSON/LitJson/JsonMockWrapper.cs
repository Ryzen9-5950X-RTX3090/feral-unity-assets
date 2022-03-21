using System;
using System.Collections;

namespace BestHTTP.JSON.LitJson
{
	public sealed class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		public bool IsArray
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsBoolean
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDouble
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsInt
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsLong
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsObject
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsString
		{
			get
			{
				return default(bool);
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		bool IList.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		int ICollection.Count
		{
			get
			{
				return default(int);
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		bool IDictionary.IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		bool IDictionary.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		ICollection IDictionary.Keys
		{
			get
			{
				return null;
			}
		}

		ICollection IDictionary.Values
		{
			get
			{
				return null;
			}
		}

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		object IOrderedDictionary.this[int idx]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool GetBoolean()
		{
			return default(bool);
		}

		public double GetDouble()
		{
			return default(double);
		}

		public int GetInt()
		{
			return default(int);
		}

		public JsonType GetJsonType()
		{
			return default(JsonType);
		}

		public long GetLong()
		{
			return default(long);
		}

		public string GetString()
		{
			return null;
		}

		public void SetBoolean(bool val)
		{
		}

		public void SetDouble(double val)
		{
		}

		public void SetInt(int val)
		{
		}

		public void SetJsonType(JsonType type)
		{
		}

		public void SetLong(long val)
		{
		}

		public void SetString(string val)
		{
		}

		public string ToJson()
		{
			return null;
		}

		public void ToJson(JsonWriter writer)
		{
		}

		int IList.Add(object value)
		{
			return default(int);
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return default(bool);
		}

		int IList.IndexOf(object value)
		{
			return default(int);
		}

		void IList.Insert(int i, object v)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Add(object k, object v)
		{
		}

		void IDictionary.Clear()
		{
		}

		bool IDictionary.Contains(object key)
		{
			return default(bool);
		}

		void IDictionary.Remove(object key)
		{
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
			return null;
		}

		void IOrderedDictionary.Insert(int i, object k, object v)
		{
		}

		void IOrderedDictionary.RemoveAt(int i)
		{
		}
	}
}
