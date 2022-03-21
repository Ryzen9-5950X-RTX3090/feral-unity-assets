namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnitySetObjectComponentPropertyCommand : AltUnityReflectionMethodsCommand
	{
		private string altObjectString;

		private string propertyString;

		private string valueString;

		public AltUnitySetObjectComponentPropertyCommand(string altObjectString, string propertyString, string valueString)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
