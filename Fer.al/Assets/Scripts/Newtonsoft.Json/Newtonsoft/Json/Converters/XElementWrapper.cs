using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		private List<IXmlNode> _attributes;

		private XElement Element
		{
			get
			{
				return null;
			}
		}

		public override List<IXmlNode> Attributes
		{
			get
			{
				return null;
			}
		}

		public override string Value
		{
			get
			{
				return null;
			}
		}

		public override string LocalName
		{
			get
			{
				return null;
			}
		}

		public override string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public XElementWrapper(XElement element)
		{
		}

		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		private bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			return default(bool);
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
