using UnityEngine;

public class UI_PlatformActivation : MonoBehaviour
{
	[SerializeField]
	private bool _OSX;

	[SerializeField]
	private bool _WINDOWS;

	[SerializeField]
	private bool _IOS;

	[SerializeField]
	private bool _ANDROID;

	private void OnEnable()
	{
	}

	private bool GetEnabled()
	{
		return default(bool);
	}
}
