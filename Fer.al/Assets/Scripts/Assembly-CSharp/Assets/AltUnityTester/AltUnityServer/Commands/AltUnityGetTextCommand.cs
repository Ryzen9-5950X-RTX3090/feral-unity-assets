namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityGetTextCommand : AltUnityReflectionMethodsCommand
	{
		private static readonly AltUnityObjectProperty[] TextProperties;

		private AltUnityObject altUnityObject;

		public AltUnityGetTextCommand(AltUnityObject altUnityObject)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
