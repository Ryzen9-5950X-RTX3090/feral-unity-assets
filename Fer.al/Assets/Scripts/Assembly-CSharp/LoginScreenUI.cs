using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginScreenUI : MonoBehaviour
{
	private VivoxVoiceManager _vivoxVoiceManager;

	public Button LoginButton;

	public InputField DisplayNameInput;

	public GameObject LoginScreen;

	private int defaultMaxStringLength;

	private bool PermissionsDenied;

	private EventSystem _evtSystem;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ShowLoginUI()
	{
	}

	private void HideLoginUI()
	{
	}

	private void LoginToVivoxService()
	{
	}

	private void LoginToVivox()
	{
	}

	private void OnUserLoggedIn()
	{
	}

	private void OnUserLoggedOut()
	{
	}
}
