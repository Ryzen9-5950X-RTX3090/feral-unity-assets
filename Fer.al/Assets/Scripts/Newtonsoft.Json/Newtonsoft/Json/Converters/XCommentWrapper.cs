using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XCommentWrapper : XObjectWrapper
	{
		private XComment Text
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

		public XCommentWrapper(XComment text)
		{
		}
	}
}
