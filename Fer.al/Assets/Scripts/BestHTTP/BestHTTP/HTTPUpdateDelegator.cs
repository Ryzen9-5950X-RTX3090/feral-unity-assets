using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BestHTTP
{
	[ExecuteInEditMode]
	public sealed class HTTPUpdateDelegator : MonoBehaviour
	{
		public static Func<bool> OnBeforeApplicationQuit;

		public static Action<bool> OnApplicationForegroundStateChanged;

		private static bool IsSetupCalled;

		public static HTTPUpdateDelegator Instance
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

		public static bool IsCreated
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

		public static bool IsThreaded
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

		public static bool IsThreadRunning
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

		public static int ThreadFrequencyInMS
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void ResetSetup()
		{
		}

		static HTTPUpdateDelegator()
		{
		}

		public static void CheckInstance()
		{
		}

		private void Setup()
		{
		}

		private void ThreadFunc()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationPause(bool isPaused)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
