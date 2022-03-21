using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlNodeWrapper : IXmlNode
	{
		private readonly XmlNode _node;

		private List<IXmlNode> _childNodes;

		private List<IXmlNode> _attributes;

		public object WrappedNode
		{
			get
			{
				return null;
			}
		}

		public XmlNodeType NodeType
		{
			get
			{
				return default(XmlNodeType);
			}
		}

		public virtual string LocalName
		{
			get
			{
				return null;
			}
		}

		public List<IXmlNode> ChildNodes
		{
			get
			{
				return null;
			}
		}

		public List<IXmlNode> Attributes
		{
			get
			{
				return null;
			}
		}

		private bool HasAttributes
		{
			get
			{
				return default(bool);
			}
		}

		public IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		public XmlNodeWrapper(XmlNode node)
		{
		}

		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
