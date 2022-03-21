using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Model
{
	public class BacktraceStackFrame
	{
		private static string[] _frameSeparators;

		public string FunctionName;

		internal BacktraceStackFrameType StackFrameType;

		public int Line;

		public string MemberInfo;

		public string SourceCodeFullPath;

		public int Column;

		public int ILOffset;

		public string SourceCode;

		public string Address;

		public string Assembly;

		public string Library;

		public string FileName
		{
			get
			{
				return null;
			}
		}

		public bool InvalidFrame
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BacktraceJObject ToJson()
		{
			return null;
		}

		public BacktraceStackFrame()
		{
		}

		public BacktraceStackFrame(StackFrame frame, bool generatedByException)
		{
		}

		private string GetMethodName(MethodBase method)
		{
			return null;
		}

		private string GetFileNameFromLibraryName()
		{
			return null;
		}

		private string GetFileNameFromFunctionName()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
