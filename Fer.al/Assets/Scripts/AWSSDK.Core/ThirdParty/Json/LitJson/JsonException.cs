using System;

namespace ThirdParty.Json.LitJson
{
	[Serializable]
	public class JsonException : Exception
	{
		public JsonException()
		{
		}

		internal JsonException(ParserToken token)
		{
		}

		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		internal JsonException(int c)
		{
		}

		internal JsonException(int c, Exception inner_exception)
		{
		}

		public JsonException(string message)
		{
		}

		public JsonException(string message, Exception inner_exception)
		{
		}
	}
}
