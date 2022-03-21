using System.Runtime.InteropServices;

namespace UniRx.Async
{
	public static class UniTaskLoopRunners
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerInitialization
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerEarlyUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerFixedUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerPreUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerPreLateUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerPostLateUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldInitialization
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldEarlyUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldFixedUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldPreUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldPreLateUpdate
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UniTaskLoopRunnerYieldPostLateUpdate
		{
		}
	}
}
