using System.IO;
using System.Text;

namespace WW.iOS.Xcode
{
	internal class JsonDocument
	{
		public JsonElementDict root;

		public string indentString;

		private void AppendIndent(StringBuilder sb, int indent)
		{
		}

		private void WriteString(StringBuilder sb, string str)
		{
		}

		private void WriteBoolean(StringBuilder sb, bool value)
		{
		}

		private void WriteInteger(StringBuilder sb, int value)
		{
		}

		private void WriteDictKeyValue(StringBuilder sb, string key, JsonElement value, int indent)
		{
		}

		private void WriteDict(StringBuilder sb, JsonElementDict el, int indent)
		{
		}

		private void WriteArray(StringBuilder sb, JsonElementArray el, int indent)
		{
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
