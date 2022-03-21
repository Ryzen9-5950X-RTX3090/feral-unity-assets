namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnitySetKeyPlayerPrefCommand : AltUnityCommand
	{
		private PLayerPrefKeyType type;

		private string keyName;

		private string value;

		public AltUnitySetKeyPlayerPrefCommand(PLayerPrefKeyType type, string keyName, string value)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
