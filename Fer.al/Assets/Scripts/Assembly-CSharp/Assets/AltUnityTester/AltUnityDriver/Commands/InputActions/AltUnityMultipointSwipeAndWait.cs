using Assets.AltUnityTester.AltUnityDriver.UnityStruct;

namespace Assets.AltUnityTester.AltUnityDriver.Commands.InputActions
{
	public class AltUnityMultipointSwipeAndWait : AltBaseCommand
	{
		private AltUnityVector2[] positions;

		private float duration;

		public AltUnityMultipointSwipeAndWait(SocketSettings socketSettings, AltUnityVector2[] positions, float duration)
		{
		}

		public void Execute()
		{
		}
	}
}
