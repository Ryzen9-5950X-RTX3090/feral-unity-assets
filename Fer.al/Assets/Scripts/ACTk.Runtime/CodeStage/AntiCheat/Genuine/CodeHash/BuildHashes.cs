using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class BuildHashes
	{
		[CompilerGenerated]
		private readonly string <BuildPath>k__BackingField;

		[CompilerGenerated]
		private readonly FileHash[] <FileHashes>k__BackingField;

		[CompilerGenerated]
		private readonly string <SummaryHash>k__BackingField;

		public string BuildPath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public FileHash[] FileHashes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string SummaryHash
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal BuildHashes(string buildPath, List<FileHash> fileHashes, SHA1Managed sha1)
		{
		}

		internal BuildHashes(string buildPath, FileHash[] fileHashes, string summaryHash)
		{
		}

		public bool HasFileHash(string hash)
		{
			return default(bool);
		}

		public void PrintToConsole()
		{
		}

		private string CalculateSummaryCodeHash(List<FileHash> fileHashes, SHA1Managed sha1)
		{
			return null;
		}
	}
}
