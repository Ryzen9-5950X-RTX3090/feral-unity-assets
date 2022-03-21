using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityTapCommand : AltUnityCommand
	{
		private AltUnityObject altUnityObject;

		private int count;

		public AltUnityTapCommand(AltUnityObject altUnityObject, int count)
		{
		}

		public override string Execute()
		{
			return null;
		}

		private void InitiateClick(GameObject gameObject, PointerEventData pointerEventData)
		{
		}
	}
}
