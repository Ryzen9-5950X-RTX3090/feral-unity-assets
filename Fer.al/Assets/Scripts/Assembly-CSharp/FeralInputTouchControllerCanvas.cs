using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

public class FeralInputTouchControllerCanvas : MonoBehaviour
{
	public static FeralInputTouchControllerCanvas instance;

	public GameObject controlModeContainer_ButtonToInteract;

	public GameObject controlModeContainer_TouchToInteract;

	[SerializeField]
	private GameObject _jumpButtonGroup;

	[SerializeField]
	private WWImage _actionIcon;

	[SerializeField]
	private GameObject _interactButtonGroup;

	[SerializeField]
	private GameObject _glideButtonGroup;

	[SerializeField]
	private TwoFingerCameraPan _cameraPan;

	private Canvas _controllerCanvas;

	[DebugField("Disable Requests", "Controls", true, false)]
	private int _disableRequests;

	private string _lastJumpImageDefId;

	public Canvas ControllerCanvas
	{
		get
		{
			return null;
		}
	}

	public void SetSelfieMode(bool inIsSelfieMode)
	{
	}

	public void SetTobogganMode(bool inIsTobogganMode)
	{
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	internal void SetJumpIcon(string inImageDefId)
	{
	}

	private void SetControlsEnabled(SetControlsEnabledCommand inCommand)
	{
	}

	[DebugButton("Enable Canvas", "Controls", false, false)]
	public void EnableCanvas()
	{
	}

	[DebugButton("Disable Canvas", "Controls", false, false)]
	public void DisableCanvas()
	{
	}

	[DebugButton("Toggle Controls", "Controls", false, false)]
	public void ToggleTouchContolMode()
	{
	}
}
