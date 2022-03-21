using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityHightlightObjectFromCoordinatesCommand : AltUnityCommand
	{
		private Vector2 screenCoordinates;

		private string ColorAndWidth;

		private Vector2 size;

		private AltClientSocketHandler handler;

		public AltUnityHightlightObjectFromCoordinatesCommand(Vector2 screenCoordinates, string colorAndWidth, Vector2 size, AltClientSocketHandler handler)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
