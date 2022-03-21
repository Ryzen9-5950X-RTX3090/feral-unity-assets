using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace WW.Debug
{
	public static class DebugConsole
	{
		public delegate bool ParseFunction(string input, out object output);

		private static Dictionary<object, List<ConsoleMethodInfo>> _buttonMethods;

		private static Dictionary<object, List<ConsoleFieldInfo>> _buttonFields;

		private static Dictionary<string, ConsoleMethodInfo> methods;

		public static Action<ConsoleMethodInfo> OnCommandAdded;

		public static Action<ConsoleMethodInfo> OnCommandRemoved;

		public static Action OnDebugMethodsChanged;

		public static Dictionary<Type, ParseFunction> parseFunctions;

		public static Dictionary<Type, string> typeReadableNames;

		private static List<string> commandArguments;

		private static readonly string[] inputDelimiters;

		public static Dictionary<object, List<ConsoleMethodInfo>> ButtonMethods
		{
			get
			{
				return null;
			}
		}

		public static Dictionary<object, List<ConsoleFieldInfo>> ButtonFields
		{
			get
			{
				return null;
			}
		}

		public static Dictionary<string, ConsoleMethodInfo> Methods
		{
			get
			{
				return null;
			}
		}

		private static void InitDebugConsole()
		{
		}

		static DebugConsole()
		{
		}

		[ConsoleCommand("help", "Prints all commands")]
		public static string LogAllCommands()
		{
			return null;
		}

		[ConsoleCommand("sysinfo", "Prints system information")]
		public static string LogSystemInfo()
		{
			return null;
		}

		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, string info, [Optional] string postfix)
		{
			return null;
		}

		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, int info, [Optional] string postfix)
		{
			return null;
		}

		public static void AddCommandInstance(string command, string description, string methodName, object instance)
		{
		}

		public static void AddCommandStatic(string command, string description, string methodName, Type ownerType)
		{
		}

		public static void RemoveCommand(string command)
		{
		}

		private static void AddCommand(string command, string description, string methodName, Type ownerType, [Optional] object instance)
		{
		}

		private static void AddCommand(string command, string description, MethodInfo method, [Optional] object instance)
		{
		}

		public static string ExecuteCommand(string command)
		{
			return null;
		}

		public static void AddDebugButtons(object inObject)
		{
		}

		public static void AddDebugButton<T>(T inDelegate, string inButtonText, object inId, string inButtonGroup = "General", bool inCloseOnClick = false) where T : Delegate
		{
		}

		public static void RemoveDebugButtons(object inId)
		{
		}

		private static void AddDebugButtonMethod(MethodInfo inMethod, DebugButtonAttribute inAttribute, object inTarget, [Optional] object inId)
		{
		}

		public static void AddDebugField(string inFieldName, object inTarget, string inFieldText, object inId, string inGroup = "General", bool inReadonly = false)
		{
		}

		private static void AddDebugButtonField(FieldInfo inField, DebugFieldAttribute inAttribute, object inTarget, object inId)
		{
		}

		private static void AddDebugButtonField(PropertyInfo inProperty, DebugFieldAttribute inAttribute, object inTarget, object inId)
		{
		}

		private static int IndexOfDelimiter(char c)
		{
			return default(int);
		}

		private static int IndexOfChar(string command, char c, int startIndex)
		{
			return default(int);
		}

		private static bool ParseString(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseBool(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseInt(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseUInt(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseLong(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseULong(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseByte(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseSByte(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseShort(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseUShort(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseChar(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseFloat(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseDouble(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseDecimal(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseVector2(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseVector3(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseVector4(string input, out object output)
		{
			return default(bool);
		}

		private static bool ParseGameObject(string input, out object output)
		{
			return default(bool);
		}

		private static bool CreateVectorFromInput(string input, Type vectorType, out object output)
		{
			return default(bool);
		}
	}
}
