using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	public class AltUnityClickOnScreenCustom : AltUnityCommand
	{
		private Vector2 position;

		private string count;

		private string interval;

		public AltUnityClickOnScreenCustom(Vector2 position, string count, string interval)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
