using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		[CompilerGenerated]
		private readonly XDeclaration <Declaration>k__BackingField;

		internal XDeclaration Declaration
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override XmlNodeType NodeType
		{
			get
			{
				return default(XmlNodeType);
			}
		}

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

		public XDeclarationWrapper(XDeclaration declaration)
		{
		}
	}
}
