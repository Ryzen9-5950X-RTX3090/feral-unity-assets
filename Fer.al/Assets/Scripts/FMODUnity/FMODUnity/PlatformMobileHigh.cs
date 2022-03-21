namespace FMODUnity
{
	public class PlatformMobileHigh : PlatformMobileLow
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		public override float Priority
		{
			get
			{
				return default(float);
			}
		}

		public override bool MatchesCurrentEnvironment
		{
			get
			{
				return default(bool);
			}
		}

		static PlatformMobileHigh()
		{
		}
	}
}
