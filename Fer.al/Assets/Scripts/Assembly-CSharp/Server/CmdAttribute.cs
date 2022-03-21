using System;

namespace Server
{
	public class CmdAttribute : Attribute
	{
		public string cmd;

		public CmdAttribute(string cmd)
		{
		}
	}
}
