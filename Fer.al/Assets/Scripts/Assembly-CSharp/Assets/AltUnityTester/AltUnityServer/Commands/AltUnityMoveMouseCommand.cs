using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityMoveMouseCommand : AltUnityCommand
	{
		private Vector2 location;

		private float duration;

		public AltUnityMoveMouseCommand(Vector2 location, float duration)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
