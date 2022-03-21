using UnityEngine.SceneManagement;

namespace Prototype
{
	public class TerrainSceneLoader : ManagedBehaviour
	{
		private static float _timerLoad;

		private static float _timerUnload;

		public override void MAwake()
		{
		}

		public override void MUpdate()
		{
		}

		public override void MOnDestroy()
		{
		}

		private void SceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode)
		{
		}

		private void SceneUnloaded(Scene inScene)
		{
		}

		public static void ResetLoadTimer()
		{
		}

		public static void ResetUnloadTimer()
		{
		}
	}
}
