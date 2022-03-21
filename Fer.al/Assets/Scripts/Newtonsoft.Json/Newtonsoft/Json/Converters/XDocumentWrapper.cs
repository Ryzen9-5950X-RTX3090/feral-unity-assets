using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		private XDocument Document
		{
			get
			{
				return null;
			}
		}

		public override List<IXmlNode> ChildNodes
		{
			get
			{
				return null;
			}
		}

		protected override bool HasChildNodes
		{
			get
			{
				return default(bool);
			}
		}

		public IXmlElement DocumentElement
		{
			get
			{
				return null;
			}
		}

		public XDocumentWrapper(XDocument document)
		{
		}

		public IXmlNode CreateComment(string text)
		{
			return null;
		}

		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
