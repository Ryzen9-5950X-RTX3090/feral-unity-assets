using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityDropObjectCommand : AltUnityCommand
	{
		private Vector2 position;

		private AltUnityObject altUnityObject;

		public AltUnityDropObjectCommand(Vector2 position, AltUnityObject altUnityObject)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
