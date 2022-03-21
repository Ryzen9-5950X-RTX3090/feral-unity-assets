using System;

namespace WW.Debug
{
	[AttributeUsage(AttributeTargets.Method)]
	public class ConsoleCommandAttribute : Attribute
	{
		private string _command;

		private string _description;

		public string Command
		{
			get
			{
				return null;
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
		}

		public ConsoleCommandAttribute(string command, string description)
		{
		}
	}
}
