namespace FMODUnity
{
	public class PlatformDefault : Platform
	{
		public const string ConstIdentifier = "default";

		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		public override bool IsIntrinsic
		{
			get
			{
				return default(bool);
			}
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}

		public override void InitializeProperties()
		{
		}

		public override void EnsurePropertiesAreValid()
		{
		}
	}
}
