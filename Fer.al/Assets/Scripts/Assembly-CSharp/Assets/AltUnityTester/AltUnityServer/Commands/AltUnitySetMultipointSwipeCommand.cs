using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnitySetMultipointSwipeCommand : AltUnityCommand
	{
		private Vector2 start;

		private Vector2 destination;

		private string duration;

		public AltUnitySetMultipointSwipeCommand(Vector2 start, Vector2 destination, string duration)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
