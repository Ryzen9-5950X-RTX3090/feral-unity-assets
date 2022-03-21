using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	internal class AltUnityLoadSceneCommand : AltUnityCommand
	{
		private string scene;

		private LoadSceneMode mode;

		private AltClientSocketHandler handler;

		public AltUnityLoadSceneCommand(string scene, bool loadSingle, AltClientSocketHandler handler)
		{
		}

		public override string Execute()
		{
			return null;
		}

		private void SceneLoaded(AsyncOperation obj)
		{
		}
	}
}
