namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnitySetTextCommand : AltUnityReflectionMethodsCommand
	{
		private static readonly AltUnityObjectProperty[] TextProperties;

		private AltUnityObject altUnityObject;

		private string inputText;

		public AltUnitySetTextCommand(AltUnityObject altUnityObject, string text)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
