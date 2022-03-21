using Backtrace.Unity.Types;

namespace Backtrace.Unity.Model
{
	public class DeduplicationModel
	{
		private readonly BacktraceData _backtraceData;

		private readonly DeduplicationStrategy _strategy;

		public string StackTrace
		{
			get
			{
				return null;
			}
		}

		public string Classifier
		{
			get
			{
				return null;
			}
		}

		public string ExceptionMessage
		{
			get
			{
				return null;
			}
		}

		public DeduplicationModel(BacktraceData backtraceData, DeduplicationStrategy strategy)
		{
		}

		public string GetSha()
		{
			return null;
		}
	}
}
