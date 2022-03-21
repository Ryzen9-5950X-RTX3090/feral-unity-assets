using UnityEngine;

public class UI_Window_DemoWelcome : UI_Window
{
	private static bool _firstLoad;

	[RuntimeInitializeOnLoadMethod]
	private static void StaticInit()
	{
	}

	private static void OnLevelLoaded(Message inMessage)
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

	private void Setup()
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
}
