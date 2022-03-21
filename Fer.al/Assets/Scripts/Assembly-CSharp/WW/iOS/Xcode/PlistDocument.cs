using System.IO;
using System.Xml.Linq;

namespace WW.iOS.Xcode
{
	public class PlistDocument
	{
		public PlistElementDict root;

		public string version;

		internal static XDocument ParseXmlNoDtd(string text)
		{
			return null;
		}

		internal static string CleanDtdToString(XDocument doc)
		{
			return null;
		}

		private static string GetText(XElement xml)
		{
			return null;
		}

		private static PlistElement ReadElement(XElement xml)
		{
			return null;
		}

		public void Create()
		{
		}

		public void ReadFromFile(string path)
		{
		}

		public void ReadFromStream(TextReader tr)
		{
		}

		public void ReadFromString(string text)
		{
		}

		private static XElement WriteElement(PlistElement el)
		{
			return null;
		}

		public void WriteToFile(string path)
		{
		}

		public void WriteToStream(TextWriter tw)
		{
		}

		public string WriteToString()
		{
			return null;
		}
	}
}
