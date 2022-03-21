using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class HashGeneratorResult
	{
		private string summaryCodeHash;

		private BuildHashes buildHashes;

		[Obsolete]
		public string CodeHash
		{
			get
			{
				return null;
			}
		}

		public string SummaryHash
		{
			get
			{
				return null;
			}
		}

		public FileHash[] FileHashes
		{
			get
			{
				return null;
			}
		}

		public string ErrorMessage
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

		public bool Success
		{
			get
			{
				return default(bool);
			}
		}

		internal static HashGeneratorResult FromError(string errorMessage)
		{
			return null;
		}

		internal static HashGeneratorResult FromBuildHashes(BuildHashes buildHashes)
		{
			return null;
		}

		public bool HasFileHash(string hash)
		{
			return default(bool);
		}
	}
}
