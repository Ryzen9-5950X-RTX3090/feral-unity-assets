using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	public class AltUnitySetMultipointSwipeChainCommand : AltUnityCommand
	{
		private Vector2[] positions;

		private string duration;

		public AltUnitySetMultipointSwipeChainCommand(Vector2[] positions, string duration)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
