using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		private readonly XmlElement _element;

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public XmlElementWrapper(XmlElement element)
		{
		}

		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
