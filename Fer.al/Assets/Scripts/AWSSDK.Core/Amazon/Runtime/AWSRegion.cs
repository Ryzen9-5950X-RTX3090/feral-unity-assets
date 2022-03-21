using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public abstract class AWSRegion
	{
		public RegionEndpoint Region
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected void SetRegionFromName(string regionSystemName)
		{
		}
	}
}
