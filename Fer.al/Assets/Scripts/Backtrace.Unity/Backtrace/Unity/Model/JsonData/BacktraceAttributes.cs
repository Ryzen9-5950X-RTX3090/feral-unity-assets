using System.Collections.Generic;
using Backtrace.Unity.Json;

namespace Backtrace.Unity.Model.JsonData
{
	public class BacktraceAttributes
	{
		public readonly Dictionary<string, string> Attributes;

		private static string _machineId;

		private static string MachineId
		{
			get
			{
				return null;
			}
		}

		public BacktraceAttributes(BacktraceReport report, Dictionary<string, string> clientAttributes, bool onlyBuiltInAttributes = false)
		{
		}

		public BacktraceJObject ToJson()
		{
			return null;
		}

		private void SetScriptingBackend()
		{
		}

		private void SetLibraryAttributes(BacktraceReport report)
		{
		}

		private static string GenerateMachineId()
		{
			return null;
		}

		internal void SetExceptionAttributes(BacktraceReport report)
		{
		}

		internal void SetSceneInformation(bool onlyBuiltInAttributes = false)
		{
		}

		private void SetProcessAttributes(bool onlyBuiltInAttributes = false)
		{
		}

		private void SetGraphicCardInformation()
		{
		}

		private void SetMachineAttributes(bool onlyBuiltInAttributes = false)
		{
		}
	}
}
