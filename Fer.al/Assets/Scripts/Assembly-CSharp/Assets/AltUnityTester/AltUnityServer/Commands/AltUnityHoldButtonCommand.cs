using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityHoldButtonCommand : AltUnityCommand
	{
		private KeyCode keyCode;

		private float power;

		private float duration;

		public AltUnityHoldButtonCommand(KeyCode keyCode, float power, float duration)
		{
		}

		public override string Execute()
		{
			return null;
		}
	}
}
