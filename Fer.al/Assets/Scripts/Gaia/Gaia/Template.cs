using System.Collections.Generic;

namespace Gaia
{
	public class Template
	{
		public string FilePath;

		public TemplateFrame Frame;

		private Dictionary<string, TemplateValue> Variables;

		public Template(string filePath, bool debug)
		{
		}

		private bool findPreviouslyBuiltFrame()
		{
			return default(bool);
		}

		public void Set(string name, string value)
		{
		}

		private int[] CopyIndicies(TemplateFrameVariable tfv)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private void UpdateIndicies(int position, int length)
		{
		}
	}
}
