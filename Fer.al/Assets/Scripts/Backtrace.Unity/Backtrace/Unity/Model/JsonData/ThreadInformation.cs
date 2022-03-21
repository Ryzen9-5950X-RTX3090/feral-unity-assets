using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Backtrace.Unity.Json;

namespace Backtrace.Unity.Model.JsonData
{
	public class ThreadInformation
	{
		internal IEnumerable<BacktraceStackFrame> Stack;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Fault
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BacktraceJObject ToJson()
		{
			return null;
		}

		public ThreadInformation(string threadName, bool fault, IEnumerable<BacktraceStackFrame> stack)
		{
		}

		public ThreadInformation(Thread thread, IEnumerable<BacktraceStackFrame> stack, bool faultingThread = false)
		{
		}
	}
}
