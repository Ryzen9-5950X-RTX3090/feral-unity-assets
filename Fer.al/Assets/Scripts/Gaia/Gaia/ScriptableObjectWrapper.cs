using System;

namespace Gaia
{
	[Serializable]
	public class ScriptableObjectWrapper
	{
		public string m_name;

		public string m_fileName;

		public byte[] m_content;

		public string GetSessionedFileName(string sessionName)
		{
			return null;
		}

		public static string GetSessionedFileName(string sessionName, string soFileName)
		{
			return null;
		}
	}
}
