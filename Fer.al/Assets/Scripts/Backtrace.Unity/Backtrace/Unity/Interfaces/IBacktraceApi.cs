using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Backtrace.Unity.Model;

namespace Backtrace.Unity.Interfaces
{
	public interface IBacktraceApi
	{
		string ServerUrl { get; }

		Action<Exception> OnServerError { get; set; }

		Action<BacktraceResult> OnServerResponse { get; set; }

		Func<string, BacktraceData, BacktraceResult> RequestHandler { get; set; }

		bool EnablePerformanceStatistics { set; }

		IEnumerator Send(string json, List<string> attachments, Dictionary<string, string> queryAttributes, Action<BacktraceResult> callback);

		IEnumerator SendMinidump(string minidumpPath, IEnumerable<string> attachments, [Optional] Action<BacktraceResult> callback);
	}
}
