namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityGetAllFieldsCommand : AltUnityReflectionMethodsCommand
	{
		private string id;

		private AltUnityComponent component;

		public AltUnityGetAllFieldsCommand(string id, AltUnityComponent component)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
