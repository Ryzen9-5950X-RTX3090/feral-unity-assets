using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityScreenshotReadyCommand : AltUnityCommand
	{
		private Texture2D screenshot;

		private Vector2 size;

		public AltUnityScreenshotReadyCommand(Texture2D screenshot, Vector2 size)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
