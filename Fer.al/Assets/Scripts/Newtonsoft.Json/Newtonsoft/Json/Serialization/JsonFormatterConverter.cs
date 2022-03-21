using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonFormatterConverter : IFormatterConverter
	{
		private readonly JsonSerializerInternalReader _reader;

		private readonly JsonISerializableContract _contract;

		private readonly JsonProperty _member;

		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
		}

		private T GetTokenValue<T>(object value)
		{
			return (T)null;
		}

		public object Convert(object value, Type type)
		{
			return null;
		}

		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		public int ToInt32(object value)
		{
			return default(int);
		}

		public long ToInt64(object value)
		{
			return default(long);
		}

		public float ToSingle(object value)
		{
			return default(float);
		}

		public string ToString(object value)
		{
			return null;
		}
	}
}
