using System.Collections;
using System.Text;
using System.Xml;
using Iss.Data;

namespace Iss.Util
{
	public class IssObjectSerializer
	{
		private static IssObjectSerializer _instance;

		private static Hashtable asciiTable_e;

		private IssObjectSerializer()
		{
		}

		public static IssObjectSerializer GetInstance()
		{
			return null;
		}

		public string Serialize(IssObject ao)
		{
			return null;
		}

		public IssObject Deserialize(string xmlData)
		{
			return null;
		}

		private void Xml2obj(XmlNode xmlNode, IssObject ao, int depth)
		{
		}

		private void Obj2xml(IssObject ao, int depth, string nodeName, StringBuilder xmlData)
		{
		}

		private static string EncodeEntities(string in_str)
		{
			return null;
		}
	}
}
