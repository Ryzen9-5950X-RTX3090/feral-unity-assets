using System;
using System.Runtime.InteropServices;

public class UI_Window_OkErrorPopup : UI_Window_OkPopup
{
	public new static void OpenWindow(string inTitle = "", string inMessage = "", string inOkBtnText = "", [Optional] Action inOkCallback)
	{
	}

	public new static void QueueWindow(string inTitle = "", string inMessage = "", string inOkBtnText = "", [Optional] Action inOkCallback)
	{
	}

	public new static void CloseWindow()
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
