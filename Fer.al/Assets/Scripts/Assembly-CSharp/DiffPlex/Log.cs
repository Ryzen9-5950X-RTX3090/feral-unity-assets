using System.Diagnostics;

namespace DiffPlex
{
	public static class Log
	{
		[Conditional("LOG")]
		public static void WriteLine(string format, object[] args)
		{
		}

		[Conditional("LOG")]
		public static void Write(string format, object[] args)
		{
		}
	}
}
