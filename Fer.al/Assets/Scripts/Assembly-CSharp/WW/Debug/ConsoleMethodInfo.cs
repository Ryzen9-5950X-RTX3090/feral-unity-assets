using System;
using System.Reflection;

namespace WW.Debug
{
	public class ConsoleMethodInfo
	{
		public readonly MethodInfo method;

		public readonly Type[] parameterTypes;

		public readonly object instance;

		public readonly string signature;

		public readonly string command;

		public readonly string group;

		public readonly bool closeOnClick;

		public ConsoleMethodInfo(MethodInfo method, Type[] parameterTypes, object instance, string signature, string command, string group = "", bool closeOnClick = false)
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}
	}
}
