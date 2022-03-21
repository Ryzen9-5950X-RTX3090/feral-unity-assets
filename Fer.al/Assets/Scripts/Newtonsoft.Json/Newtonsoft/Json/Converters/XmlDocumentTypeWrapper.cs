using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		private readonly XmlDocumentType _documentType;

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

		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
		{
		}
	}
}
