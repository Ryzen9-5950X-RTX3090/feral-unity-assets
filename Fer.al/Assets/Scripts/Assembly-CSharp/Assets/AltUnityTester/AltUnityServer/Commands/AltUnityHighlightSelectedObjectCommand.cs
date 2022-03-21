using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityHighlightSelectedObjectCommand : AltUnityCommand
	{
		private int id;

		private string ColorAndWidth;

		private Vector2 size;

		private AltClientSocketHandler handler;

		public AltUnityHighlightSelectedObjectCommand(int id, string colorAndWidth, Vector2 size, AltClientSocketHandler handler)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
