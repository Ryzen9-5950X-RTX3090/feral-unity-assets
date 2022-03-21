using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityDragObjectCommand : AltUnityCommand
	{
		private Vector2 position;

		private AltUnityObject altUnityObject;

		public AltUnityDragObjectCommand(Vector2 position, AltUnityObject altUnityObject)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
