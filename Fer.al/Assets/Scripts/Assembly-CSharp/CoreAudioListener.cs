using UnityEngine;

[AddComponentMenu("Audio/CoreAudioListener")]
public class CoreAudioListener : MonoBehaviour
{
	public bool matchRotation;

	private static CoreAudioListener _instance;

	public static void UpdateListenerTransform(Transform inTransform)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
