using Assets.AltUnityTester.AltUnityDriver.UnityStruct;

namespace Assets.AltUnityTester.AltUnityDriver.Commands.InputActions
{
	public class AltUnityMultipointSwipe : AltBaseCommand
	{
		private AltUnityVector2[] positions;

		private float duration;

		public AltUnityMultipointSwipe(SocketSettings socketSettings, AltUnityVector2[] positions, float duration)
		{
		}

		public void Execute()
		{
		}
	}
}
