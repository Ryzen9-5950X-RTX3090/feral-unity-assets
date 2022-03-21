using UnityEngine;

public static class Runtime_FakeServer
{
	private static bool IsInMainScene
	{
		get
		{
			return default(bool);
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Runtime_FakeServer_Init()
	{
	}

	private static void LoadMainSceneAdditive()
	{
	}
}
