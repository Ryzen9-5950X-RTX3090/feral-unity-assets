using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XContainerWrapper : XObjectWrapper
	{
		private List<IXmlNode> _childNodes;

		private XContainer Container
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

		protected virtual bool HasChildNodes
		{
			get
			{
				return default(bool);
			}
		}

		public override IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		public XContainerWrapper(XContainer container)
		{
		}

		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
