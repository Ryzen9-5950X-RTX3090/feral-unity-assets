using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Transform
{
	public class JsonUnmarshallerContext : UnmarshallerContext
	{
		private enum PathSegmentType
		{
			Value,
			Delimiter
		}

		private struct PathSegment
		{
			internal PathSegmentType SegmentType
			{
				[CompilerGenerated]
				get
				{
					return default(PathSegmentType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal string Value
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private class JsonPathStack
		{
			private Stack<PathSegment> stack;

			private int currentDepth;

			private StringBuilder stackStringBuilder;

			private string stackString;

			public int CurrentDepth
			{
				get
				{
					return default(int);
				}
			}

			public string CurrentPath
			{
				get
				{
					return null;
				}
			}

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			internal void Push(PathSegment segment)
			{
			}

			internal PathSegment Pop()
			{
				return default(PathSegment);
			}

			internal PathSegment Peek()
			{
				return default(PathSegment);
			}
		}

		private const string DELIMITER = "/";

		private StreamReader streamReader;

		private JsonReader jsonReader;

		private JsonPathStack stack;

		private string currentField;

		private JsonToken? currentToken;

		private bool disposed;

		private bool wasPeeked;

		public override bool IsStartOfDocument
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsEndElement
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsStartElement
		{
			get
			{
				return default(bool);
			}
		}

		public override int CurrentDepth
		{
			get
			{
				return default(int);
			}
		}

		public override string CurrentPath
		{
			get
			{
				return null;
			}
		}

		public JsonToken CurrentTokenType
		{
			get
			{
				return default(JsonToken);
			}
		}

		public Stream Stream
		{
			get
			{
				return null;
			}
		}

		public JsonUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		public override bool Read()
		{
			return default(bool);
		}

		public bool Peek(JsonToken token)
		{
			return default(bool);
		}

		public override string ReadText()
		{
			return null;
		}

		public int Peek()
		{
			return default(int);
		}

		private int StreamPeek()
		{
			return default(int);
		}

		private void UpdateContext()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
