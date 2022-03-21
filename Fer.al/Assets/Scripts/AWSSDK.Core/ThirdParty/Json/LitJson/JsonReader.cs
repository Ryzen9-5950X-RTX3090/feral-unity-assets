using System.Collections.Generic;
using System.IO;

namespace ThirdParty.Json.LitJson
{
	public class JsonReader
	{
		private Stack<JsonToken> depth;

		private int current_input;

		private int current_symbol;

		private bool end_of_json;

		private bool end_of_input;

		private Lexer lexer;

		private bool parser_in_string;

		private bool parser_return;

		private bool read_started;

		private TextReader reader;

		private bool reader_is_owned;

		private object token_value;

		private JsonToken token;

		public bool AllowComments
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool AllowSingleQuotedStrings
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EndOfInput
		{
			get
			{
				return default(bool);
			}
		}

		public bool EndOfJson
		{
			get
			{
				return default(bool);
			}
		}

		public JsonToken Token
		{
			get
			{
				return default(JsonToken);
			}
		}

		public object Value
		{
			get
			{
				return null;
			}
		}

		public JsonReader(string json_text)
		{
		}

		public JsonReader(TextReader reader)
		{
		}

		private JsonReader(TextReader reader, bool owned)
		{
		}

		private void ProcessNumber(string number)
		{
		}

		private void ProcessSymbol()
		{
		}

		private bool ReadToken()
		{
			return default(bool);
		}

		public void Close()
		{
		}

		public bool Read()
		{
			return default(bool);
		}
	}
}
