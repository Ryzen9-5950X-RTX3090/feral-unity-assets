using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityGetScreenshotCommand : AltUnityCommand
	{
		private Vector2 size;

		private AltClientSocketHandler handler;

		public AltUnityGetScreenshotCommand(Vector2 size, AltClientSocketHandler handler)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
