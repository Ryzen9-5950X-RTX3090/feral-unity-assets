using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XTextWrapper : XObjectWrapper
	{
		private XText Text
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

		public override IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		public XTextWrapper(XText text)
		{
		}
	}
}
