using UnityEngine;

public class LCR : MonoBehaviour
{
	private static bool quitting;

	private static LCR _instance;

	public static LCR instance
	{
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void OnBeforeSceneLoadRuntime()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
