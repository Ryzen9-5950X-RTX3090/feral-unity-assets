using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XAttributeWrapper : XObjectWrapper
	{
		private XAttribute Attribute
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

		public override IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		public XAttributeWrapper(XAttribute attribute)
		{
		}
	}
}
