using System;
using System.Runtime.CompilerServices;

namespace Backtrace.Unity.Model
{
	public class BacktraceCredentials
	{
		public Uri BacktraceHostUri
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

		public Uri GetSubmissionUrl()
		{
			return null;
		}

		public Uri GetMinidumpSubmissionUrl()
		{
			return null;
		}

		public BacktraceCredentials(string backtraceSubmitUrl)
		{
		}

		public BacktraceCredentials(Uri backtraceSubmitUrl)
		{
		}
	}
}
