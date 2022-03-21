using UnityEngine;

public class JoystickOnly : MonoBehaviour
{
	public enum JoystickOnlySetting
	{
		EnableForJoytick,
		DisableForJoystick
	}

	[SerializeField]
	private JoystickOnlySetting _setting;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Refresh()
	{
	}

	private void OnControllerConnected(ControllerConnectedMessage inMessage)
	{
	}

	private void OnControllerDisconnected(ControllerDisconnectedMessage inMessage)
	{
	}
}
