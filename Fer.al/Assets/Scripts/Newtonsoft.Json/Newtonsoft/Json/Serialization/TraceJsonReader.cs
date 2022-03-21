using System;
using System.IO;

namespace Newtonsoft.Json.Serialization
{
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		private readonly JsonReader _innerReader;

		private readonly JsonTextWriter _textWriter;

		private readonly StringWriter _sw;

		public override int Depth
		{
			get
			{
				return default(int);
			}
		}

		public override string Path
		{
			get
			{
				return null;
			}
		}

		public override JsonToken TokenType
		{
			get
			{
				return default(JsonToken);
			}
		}

		public override object Value
		{
			get
			{
				return null;
			}
		}

		public override Type ValueType
		{
			get
			{
				return null;
			}
		}

		int IJsonLineInfo.LineNumber
		{
			get
			{
				return default(int);
			}
		}

		int IJsonLineInfo.LinePosition
		{
			get
			{
				return default(int);
			}
		}

		public TraceJsonReader(JsonReader innerReader)
		{
		}

		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		public override bool Read()
		{
			return default(bool);
		}

		public override int? ReadAsInt32()
		{
			return null;
		}

		public override string ReadAsString()
		{
			return null;
		}

		public override byte[] ReadAsBytes()
		{
			return null;
		}

		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		public override double? ReadAsDouble()
		{
			return null;
		}

		public override bool? ReadAsBoolean()
		{
			return null;
		}

		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		public void WriteCurrentToken()
		{
		}

		public override void Close()
		{
		}

		bool IJsonLineInfo.HasLineInfo()
		{
			return default(bool);
		}
	}
}
