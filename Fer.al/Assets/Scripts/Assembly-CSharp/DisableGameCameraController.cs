using System.Collections.Generic;

public class DisableGameCameraController : MonoBehaviour
{
	private static DisableGameCameraController _instance;

	private static int _disabledCount;

	private List<UI_Window> _disabledGameCameraWindows;

	public static DisableGameCameraController instance
	{
		get
		{
			return null;
		}
	}

	public List<UI_Window> disabledGameCameraWindows
	{
		get
		{
			return null;
		}
	}

	public bool IsEnabled
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnWindowOpenComplete(WindowOpenCompleteMessage inMessage)
	{
	}

	private void OnWindowClosed(WindowClosedMessage inMessage)
	{
	}

	private void OnWindowHidden(WindowHiddenMessage inMessage)
	{
	}

	private void OnWindowShown(WindowShownMessage inMessage)
	{
	}

	private bool HasDisabledGameCamera(UI_Window inWindow)
	{
		return default(bool);
	}

	private void OnDisableGameCameraMessage(DisableGameCameraMessage message)
	{
	}
}
