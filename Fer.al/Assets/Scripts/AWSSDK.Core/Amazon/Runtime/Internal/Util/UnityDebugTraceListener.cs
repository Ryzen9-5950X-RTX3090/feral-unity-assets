using System.Diagnostics;

namespace Amazon.Runtime.Internal.Util
{
	public class UnityDebugTraceListener : TraceListener
	{
		public override bool IsThreadSafe
		{
			get
			{
				return default(bool);
			}
		}

		public UnityDebugTraceListener()
		{
		}

		public UnityDebugTraceListener(string name)
		{
		}

		public override void Write(string message)
		{
		}

		public override void WriteLine(string message)
		{
		}

		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, object[] args)
		{
		}

		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
		}

		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
		}

		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object[] data)
		{
		}

		public override void Fail(string message)
		{
		}

		public override void Fail(string message, string detailMessage)
		{
		}

		public override void Write(object o)
		{
		}

		public override void WriteLine(object o)
		{
		}

		public override void WriteLine(object o, string category)
		{
		}

		private void LogMessage(string message, TraceEventType eventType)
		{
		}
	}
}
