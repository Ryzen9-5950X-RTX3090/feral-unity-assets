using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;

namespace Backtrace.Unity.Model
{
	public class BacktraceSourceCode
	{
		internal static string SOURCE_CODE_PROPERTY;

		public readonly string Type;

		public readonly string Title;

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal BacktraceJObject ToJson()
		{
			return null;
		}
	}
}
