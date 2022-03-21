using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		private readonly XDocumentType _documentType;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string System
		{
			get
			{
				return null;
			}
		}

		public string Public
		{
			get
			{
				return null;
			}
		}

		public string InternalSubset
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

		public XDocumentTypeWrapper(XDocumentType documentType)
		{
		}
	}
}
