using System;
using System.Collections;
using System.Collections.Generic;

namespace BestHTTP.JSON.LitJson
{
	public sealed class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		private IList<JsonData> inst_array;

		private bool inst_boolean;

		private double inst_double;

		private int inst_int;

		private long inst_long;

		private IDictionary<string, JsonData> inst_object;

		private string inst_string;

		private string json;

		private JsonType type;

		private IList<KeyValuePair<string, JsonData>> object_list;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

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

		public ICollection<string> Keys
		{
			get
			{
				return null;
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

		bool IJsonWrapper.IsArray
		{
			get
			{
				return default(bool);
			}
		}

		bool IJsonWrapper.IsBoolean
		{
			get
			{
				return default(bool);
			}
		}

		bool IJsonWrapper.IsDouble
		{
			get
			{
				return default(bool);
			}
		}

		bool IJsonWrapper.IsInt
		{
			get
			{
				return default(bool);
			}
		}

		bool IJsonWrapper.IsLong
		{
			get
			{
				return default(bool);
			}
		}

		bool IJsonWrapper.IsObject
		{
			get
			{
				return default(bool);
			}
		}

		bool IJsonWrapper.IsString
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

		public JsonData this[string prop_name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JsonData this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		public JsonData()
		{
		}

		public JsonData(bool boolean)
		{
		}

		public JsonData(double number)
		{
		}

		public JsonData(int number)
		{
		}

		public JsonData(long number)
		{
		}

		public JsonData(object obj)
		{
		}

		public JsonData(string str)
		{
		}

		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		public static implicit operator JsonData(double data)
		{
			return null;
		}

		public static implicit operator JsonData(int data)
		{
			return null;
		}

		public static implicit operator JsonData(long data)
		{
			return null;
		}

		public static implicit operator JsonData(string data)
		{
			return null;
		}

		public static explicit operator bool(JsonData data)
		{
			return default(bool);
		}

		public static explicit operator double(JsonData data)
		{
			return default(double);
		}

		public static explicit operator int(JsonData data)
		{
			return default(int);
		}

		public static explicit operator long(JsonData data)
		{
			return default(long);
		}

		public static explicit operator string(JsonData data)
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		void IDictionary.Add(object key, object value)
		{
		}

		void IDictionary.Clear()
		{
		}

		bool IDictionary.Contains(object key)
		{
			return default(bool);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		bool IJsonWrapper.GetBoolean()
		{
			return default(bool);
		}

		double IJsonWrapper.GetDouble()
		{
			return default(double);
		}

		int IJsonWrapper.GetInt()
		{
			return default(int);
		}

		long IJsonWrapper.GetLong()
		{
			return default(long);
		}

		string IJsonWrapper.GetString()
		{
			return null;
		}

		void IJsonWrapper.SetBoolean(bool val)
		{
		}

		void IJsonWrapper.SetDouble(double val)
		{
		}

		void IJsonWrapper.SetInt(int val)
		{
		}

		void IJsonWrapper.SetLong(long val)
		{
		}

		void IJsonWrapper.SetString(string val)
		{
		}

		string IJsonWrapper.ToJson()
		{
			return null;
		}

		void IJsonWrapper.ToJson(JsonWriter writer)
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

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
			return null;
		}

		void IOrderedDictionary.Insert(int idx, object key, object value)
		{
		}

		void IOrderedDictionary.RemoveAt(int idx)
		{
		}

		private ICollection EnsureCollection()
		{
			return null;
		}

		private IDictionary EnsureDictionary()
		{
			return null;
		}

		private IList EnsureList()
		{
			return null;
		}

		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		public int Add(object value)
		{
			return default(int);
		}

		public bool Remove(object obj)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public bool Equals(JsonData x)
		{
			return default(bool);
		}

		public JsonType GetJsonType()
		{
			return default(JsonType);
		}

		public void SetJsonType(JsonType type)
		{
		}

		public string ToJson()
		{
			return null;
		}

		public void ToJson(JsonWriter writer)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
