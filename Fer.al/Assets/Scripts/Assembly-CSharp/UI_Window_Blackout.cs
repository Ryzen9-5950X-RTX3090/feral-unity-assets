using UnityEngine;

public class UI_Window_Blackout : UI_Window
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	public static void OpenWindow(float inFadeDuration = 1f)
	{
	}

	public static void QueueWindow(float inFadeDuration = 1f)
	{
	}

	public static void CloseWindow(float inFadeDuration = 1f)
	{
	}

	private void Setup(float inFadeDuration = 1f)
	{
	}

	public void Close(float inFadeDuration = 1f)
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
