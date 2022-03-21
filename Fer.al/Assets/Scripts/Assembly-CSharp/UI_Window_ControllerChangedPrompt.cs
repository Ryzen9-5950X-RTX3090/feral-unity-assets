using TMPro;
using UnityEngine;

public class UI_Window_ControllerChangedPrompt : UI_Window
{
	[SerializeField]
	private GameObject _keepKeyboardBtn;

	[SerializeField]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	private bool _controllerConnected;

	private int _controllerId;

	[RuntimeInitializeOnLoadMethod]
	private static void StaticInit()
	{
	}

	public static void OnControllerConnected(ControllerConnectedMessage inMessage)
	{
	}

	public static void OnControllerPreDisconnected(ControllerPreDisconnectedMessage inMessage)
	{
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(bool inConnected, int inControllerId)
	{
	}

	private void ControllerConnectedWhileOpen()
	{
	}

	private void ControllerDisconnectedWhileOpen()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_UseKeyboard()
	{
	}

	public void BtnClicked_Restart()
	{
	}
}
