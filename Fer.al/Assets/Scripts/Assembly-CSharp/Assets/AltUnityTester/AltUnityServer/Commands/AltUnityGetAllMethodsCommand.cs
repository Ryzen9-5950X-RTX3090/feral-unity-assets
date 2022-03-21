namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityGetAllMethodsCommand : AltUnityReflectionMethodsCommand
	{
		private AltUnityComponent component;

		private AltUnityMethodSelection methodSelection;

		public AltUnityGetAllMethodsCommand(AltUnityComponent component, AltUnityMethodSelection methodSelection)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
