using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Amazon.Runtime.Internal.Transform
{
	public class XmlUnmarshallerContext : UnmarshallerContext
	{
		private static readonly XmlReaderSettings READER_SETTINGS;

		private static HashSet<XmlNodeType> nodesToSkip;

		private StreamReader streamReader;

		private XmlReader _xmlReader;

		private Stack<string> stack;

		private string stackString;

		private Dictionary<string, string> attributeValues;

		private List<string> attributeNames;

		private IEnumerator<string> attributeEnumerator;

		private XmlNodeType nodeType;

		private string nodeContent;

		private bool disposed;

		public Stream Stream
		{
			get
			{
				return null;
			}
		}

		private XmlReader XmlReader
		{
			get
			{
				return null;
			}
		}

		public override string CurrentPath
		{
			get
			{
				return null;
			}
		}

		public override int CurrentDepth
		{
			get
			{
				return default(int);
			}
		}

		public override bool IsStartElement
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

		public override bool IsStartOfDocument
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsAttribute
		{
			get
			{
				return default(bool);
			}
		}

		public XmlUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		public override bool Read()
		{
			return default(bool);
		}

		public override string ReadText()
		{
			return null;
		}

		private static string StackToPath(Stack<string> stack)
		{
			return null;
		}

		private void ReadElement()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
