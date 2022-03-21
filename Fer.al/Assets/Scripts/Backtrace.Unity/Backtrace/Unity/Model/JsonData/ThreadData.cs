using System.Collections.Generic;
using Backtrace.Unity.Json;

namespace Backtrace.Unity.Model.JsonData
{
	public class ThreadData
	{
		public Dictionary<string, ThreadInformation> ThreadInformations;

		internal string MainThread;

		internal ThreadData(IEnumerable<BacktraceStackFrame> exceptionStack, bool faultingThread)
		{
		}

		public BacktraceJObject ToJson()
		{
			return null;
		}
	}
}
