using System.Collections.Generic;

namespace Gaia
{
	public class TemplateFrame
	{
		public Dictionary<string, TemplateFrameVariable> Variables;

		public string FilePath;

		public string Text;

		private const char BeginChar = '{';

		private const char EndChar = '}';

		private int VariableCount;

		public TemplateFrame(string filePath, bool debug)
		{
		}

		public string Build(string filePath)
		{
			return null;
		}

		private char[] shiftCharArryLeft(char[] arry, int startIndex, int endIndex)
		{
			return null;
		}

		private string getVarName(char[] text, ref int pos)
		{
			return null;
		}

		private static int skipSpaces(char[] text, int pos)
		{
			return default(int);
		}
	}
}
