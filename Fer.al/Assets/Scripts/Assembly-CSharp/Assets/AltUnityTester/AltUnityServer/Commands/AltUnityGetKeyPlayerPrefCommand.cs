namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityGetKeyPlayerPrefCommand : AltUnityCommand
	{
		private PLayerPrefKeyType type;

		private string value;

		public AltUnityGetKeyPlayerPrefCommand(PLayerPrefKeyType type, string value)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
