namespace Newtonsoft.Json.Linq
{
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		private readonly JToken _root;

		private string _initialPath;

		private JToken _parent;

		private JToken _current;

		public JToken CurrentToken
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

		public override string Path
		{
			get
			{
				return null;
			}
		}

		public JTokenReader(JToken token)
		{
		}

		public override bool Read()
		{
			return default(bool);
		}

		private bool ReadOver(JToken t)
		{
			return default(bool);
		}

		private bool ReadToEnd()
		{
			return default(bool);
		}

		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		private bool ReadInto(JContainer c)
		{
			return default(bool);
		}

		private bool SetEnd(JContainer c)
		{
			return default(bool);
		}

		private void SetToken(JToken token)
		{
		}

		private string SafeToString(object value)
		{
			return null;
		}

		bool IJsonLineInfo.HasLineInfo()
		{
			return default(bool);
		}
	}
}
