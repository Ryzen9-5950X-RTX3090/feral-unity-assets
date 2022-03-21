using System.Security.Cryptography;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal class StandaloneWindowsWorker : BaseWorker
	{
		public static BuildHashes GetBuildHashes(string buildPath, FileFilter[] fileFilters, SHA1Managed sha1)
		{
			return null;
		}

		public override void Execute()
		{
		}

		private void GenerateHashThread(object folder)
		{
		}
	}
}
