namespace FMODUnity
{
	public class PlatformMobileLow : Platform
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

		static PlatformMobileLow()
		{
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}
	}
}
