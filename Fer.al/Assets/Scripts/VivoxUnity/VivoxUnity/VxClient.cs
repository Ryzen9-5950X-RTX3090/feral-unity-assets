using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VivoxUnity
{
	public class VxClient : IDisposable
	{
		public delegate void HandleEventMessage(vx_evt_base_t eventMessage);

		private static VxClient _instance;

		private readonly Dictionary<string, AsyncResult<vx_resp_base_t>> _pendingRequests;

		private long _nextRequestId;

		private int _startCount;

		public const string appId = "UNI";

		public VivoxDebug vivoxDebug;

		private bool disposed;

		public static VxClient Instance
		{
			get
			{
				return null;
			}
		}

		public bool Started
		{
			get
			{
				return default(bool);
			}
		}

		public event HandleEventMessage EventMessageReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private VxClient()
		{
		}

		public void Start([Optional] VivoxConfig config)
		{
		}

		public void Start(vx_sdk_config_t config)
		{
		}

		private void InternalStart(vx_sdk_config_t config)
		{
		}

		private void InstanceOnMainLoopRun(ref bool didWork)
		{
		}

		public void Stop()
		{
		}

		public void Cleanup()
		{
		}

		public IAsyncResult BeginIssueRequest(vx_req_base_t request, AsyncCallback callback)
		{
			return null;
		}

		public vx_resp_base_t EndIssueRequest(IAsyncResult result)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~VxClient()
		{
		}

		public static string GetLoginToken(string issuer, TimeSpan expiration, string userUri, string key)
		{
			return null;
		}

		public static string GetJoinToken(string issuer, TimeSpan expiration, string userUri, string conferenceUri, string key)
		{
			return null;
		}

		public static string GetMuteForAllToken(string issuer, TimeSpan expiration, string subject, string fromUserUri, string conferenceUri, string key)
		{
			return null;
		}

		public static string GetTranscriptionToken(string issuer, TimeSpan expiration, string userUri, string conferenceUri, string key)
		{
			return null;
		}

		public static string GetRandomUserId(string prefix)
		{
			return null;
		}

		public static string GetRandomUserIdEx(string prefix, string issuer)
		{
			return null;
		}

		public static string GetRandomChannelUri(string prefix, string realm)
		{
			return null;
		}

		public static string GetVersion()
		{
			return null;
		}
	}
}
