using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using UnityEngine.Networking;

namespace Backtrace.Unity.Services
{
	internal class BacktraceApi : IBacktraceApi
	{
		private bool _shouldDisplayFailureMessage;

		private readonly Uri _serverUrl;

		private readonly string _minidumpUrl;

		private readonly BacktraceCredentials _credentials;

		private readonly bool _ignoreSslValidation;

		[Obsolete]
		public Func<string, BacktraceData, BacktraceResult> RequestHandler
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

		public Action<Exception> OnServerError
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

		public Action<BacktraceResult> OnServerResponse
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

		public bool EnablePerformanceStatistics
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

		public string ServerUrl
		{
			get
			{
				return null;
			}
		}

		public BacktraceApi(BacktraceCredentials credentials, bool ignoreSslValidation = false)
		{
		}

		[IteratorStateMachine(typeof(<SendMinidump>d__25))]
		public IEnumerator SendMinidump(string minidumpPath, IEnumerable<string> attachments, [Optional] Action<BacktraceResult> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Send>d__28))]
		public IEnumerator Send(string json, List<string> attachments, Dictionary<string, string> queryAttributes, Action<BacktraceResult> callback)
		{
			return null;
		}

		private List<IMultipartFormSection> CreateJsonFormData(byte[] json, IEnumerable<string> attachments)
		{
			return null;
		}

		private List<IMultipartFormSection> CreateMinidumpFormData(byte[] minidump, IEnumerable<string> attachments)
		{
			return null;
		}

		private void AddAttachmentToFormData(List<IMultipartFormSection> formData, IEnumerable<string> attachments)
		{
		}

		private void PrintLog(UnityWebRequest request)
		{
		}

		private string GetParametrizedQuery(string serverUrl, Dictionary<string, string> queryAttributes)
		{
			return null;
		}
	}
}
