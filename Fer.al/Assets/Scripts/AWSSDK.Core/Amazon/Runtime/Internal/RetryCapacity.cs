using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class RetryCapacity
	{
		private readonly int _maxCapacity;

		public int AvailableCapacity
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

		public int MaxCapacity
		{
			get
			{
				return default(int);
			}
		}

		public RetryCapacity(int maxCapacity)
		{
		}
	}
}
