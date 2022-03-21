using System.Collections;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Interfaces;

namespace Backtrace.Unity.Model
{
	internal class NativeCrashUploader
	{
		private IBacktraceApi _backtraceApi;

		internal string nativeCrashesDir;

		public void SetBacktraceApi(IBacktraceApi backtraceApi)
		{
		}

		[IteratorStateMachine(typeof(<SendUnhandledGameCrashesOnGameStartup>d__3))]
		public IEnumerator SendUnhandledGameCrashesOnGameStartup()
		{
			return null;
		}
	}
}
