using System.Runtime.CompilerServices;

namespace DG.Tweening.Core
{
	internal struct SafeModeReport
	{
		internal enum SafeModeReportType
		{
			Unset,
			TargetOrFieldMissing,
			Callback,
			StartupFailure
		}

		public int totMissingTargetOrFieldErrors
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

		public int totCallbackErrors
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

		public int totStartupErrors
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

		public int totUnsetErrors
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

		public void Add(SafeModeReportType type)
		{
		}

		public int GetTotErrors()
		{
			return default(int);
		}
	}
}
