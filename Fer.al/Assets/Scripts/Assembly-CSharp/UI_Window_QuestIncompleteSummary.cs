using System;
using System.Runtime.InteropServices;

public class UI_Window_QuestIncompleteSummary : UI_Window
{
	private Action<bool> _resultCallback;

	public static void OpenWindow([Optional] Action<bool> inResultCallback)
	{
	}

	public static void QueueWindow([Optional] Action<bool> inResultCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup([Optional] Action<bool> inResultCallback)
	{
	}

	public void BtnClicked_Leave()
	{
	}

	public void BtnClicked_Cancel()
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
