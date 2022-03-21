using System;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Model
{
	public class BacktraceResult
	{
		[Serializable]
		private class BacktraceRawResult
		{
			public string response;

			public string _rxid;
		}

		public string message;

		public string response;

		public BacktraceResultStatus Status;

		public string _rxId;

		public string Message
		{
			set
			{
			}
		}

		internal static BacktraceResult OnNetworkError(Exception exception)
		{
			return null;
		}

		public static BacktraceResult FromJson(string json)
		{
			return null;
		}
	}
}
