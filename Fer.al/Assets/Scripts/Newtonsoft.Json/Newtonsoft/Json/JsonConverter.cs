using System;

namespace Newtonsoft.Json
{
	public abstract class JsonConverter
	{
		public virtual bool CanRead
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		public abstract bool CanConvert(Type objectType);
	}
}
