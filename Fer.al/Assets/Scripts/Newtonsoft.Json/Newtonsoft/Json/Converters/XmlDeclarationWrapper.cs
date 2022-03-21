using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		private readonly XmlDeclaration _declaration;

		public string Version
		{
			get
			{
				return null;
			}
		}

		public string Encoding
		{
			get
			{
				return null;
			}
		}

		public string Standalone
		{
			get
			{
				return null;
			}
		}

		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}
	}
}
