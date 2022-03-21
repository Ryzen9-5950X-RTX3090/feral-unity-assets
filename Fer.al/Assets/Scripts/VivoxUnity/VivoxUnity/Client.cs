using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using VivoxUnity.Common;
using VivoxUnity.Private;

namespace VivoxUnity
{
	public sealed class Client : IDisposable
	{
		private readonly ReadWriteDictionary<AccountId, ILoginSession, LoginSession> _loginSessions;

		private readonly AudioInputDevices _inputDevices;

		private readonly AudioOutputDevices _outputDevices;

		private static int _nextHandle;

		private string _connectorHandle;

		private readonly Queue<IAsyncResult> _pendingConnectorCreateRequests;

		private bool _ttsIsInitialized;

		private uint _ttsManagerId;

		internal uint TTSManagerId
		{
			get
			{
				return default(uint);
			}
		}

		public static string InternalVersion
		{
			get
			{
				return null;
			}
		}

		public bool Initialized
		{
			get
			{
				return default(bool);
			}
		}

		public IReadOnlyDictionary<AccountId, ILoginSession> LoginSessions
		{
			get
			{
				return null;
			}
		}

		public IAudioDevices AudioInputDevices
		{
			get
			{
				return null;
			}
		}

		public IAudioDevices AudioOutputDevices
		{
			get
			{
				return null;
			}
		}

		public bool IsAudioEchoCancellationEnabled
		{
			get
			{
				return default(bool);
			}
		}

		private void CheckInitialized()
		{
		}

		public void Initialize([Optional] VivoxConfig config)
		{
		}

		internal IAsyncResult BeginGetConnectorHandle(Uri server, AsyncCallback callback)
		{
			return null;
		}

		internal string EndGetConnectorHandle(IAsyncResult result)
		{
			return null;
		}

		public void Uninitialize()
		{
		}

		public static void Cleanup()
		{
		}

		public ILoginSession GetLoginSession(AccountId accountId)
		{
			return null;
		}

		public void SetAudioEchoCancellation(bool onOff)
		{
		}

		void IDisposable.Dispose()
		{
		}

		internal static string GetRandomUserId(string prefix)
		{
			return null;
		}

		internal static string GetRandomChannelUri(string prefix, string realm)
		{
			return null;
		}

		public static void Run(LoopDone done)
		{
		}

		public static bool Run(WaitHandle handle, TimeSpan until)
		{
			return default(bool);
		}

		public static void RunOnce()
		{
		}

		internal bool TTSInitialize()
		{
			return default(bool);
		}

		internal void TTSShutdown()
		{
		}
	}
}
