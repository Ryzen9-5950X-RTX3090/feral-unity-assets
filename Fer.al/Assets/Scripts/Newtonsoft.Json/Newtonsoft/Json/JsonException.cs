using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonException : Exception
	{
		public JsonException()
		{
		}

		public JsonException(string message)
		{
		}

		public JsonException(string message, Exception innerException)
		{
		}

		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
