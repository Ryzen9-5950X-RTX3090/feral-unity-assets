using UnityEngine;

public class PlayerBuildTimeLogger : MonoBehaviour
{
	public static PlayerBuildTimeLogger instance;

	private const int timeBetweenLogs = 30;

	private float lastLoggedTime;

	[RuntimeInitializeOnLoadMethod]
	private static void OnRuntimeMethodLoad()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void Log()
	{
	}
}
