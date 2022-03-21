using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XObjectWrapper : IXmlNode
	{
		private readonly XObject _xmlObject;

		public object WrappedNode
		{
			get
			{
				return null;
			}
		}

		public virtual XmlNodeType NodeType
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

		public virtual List<IXmlNode> ChildNodes
		{
			get
			{
				return null;
			}
		}

		public virtual List<IXmlNode> Attributes
		{
			get
			{
				return null;
			}
		}

		public virtual IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
		}

		public virtual string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		public XObjectWrapper(XObject xmlObject)
		{
		}

		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
