using System.Runtime.CompilerServices;

namespace VivoxUnity.Private
{
	internal class ArchiveQueryResult : IArchiveQueryResult
	{
		public string QueryId
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

		public int ReturnCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string FirstId
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

		public string LastId
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

		public uint FirstIndex
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint TotalCount
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Running
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

		public ArchiveQueryResult()
		{
		}

		public ArchiveQueryResult(string queryId)
		{
		}

		public ArchiveQueryResult(vx_evt_session_archive_query_end_t evt)
		{
		}

		public ArchiveQueryResult(vx_evt_account_archive_query_end_t evt)
		{
		}
	}
}
