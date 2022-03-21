using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityTiltCommand : AltUnityCommand
	{
		private Vector3 acceleration;

		private float duration;

		public AltUnityTiltCommand(Vector3 acceleration, float duration)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
