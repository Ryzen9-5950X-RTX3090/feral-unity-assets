using System;
using Backtrace.Unity.Types;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	[Serializable]
	public class BacktraceClientConfiguration : ScriptableObject
	{
		public string ServerUrl;

		public int ReportPerMin;

		public bool HandleUnhandledExceptions;

		public bool IgnoreSslValidation;

		public bool DestroyOnLoad;

		public bool HandleANR;

		public bool OomReports;

		public int GameObjectDepth;

		public MiniDumpType MinidumpType;

		public void UpdateServerUrl()
		{
		}

		public bool ValidateServerUrl()
		{
			return default(bool);
		}
	}
}
