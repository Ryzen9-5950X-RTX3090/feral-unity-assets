using System;
using System.Runtime.InteropServices;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ChallengeComplete : UI_Window
{
	[SerializeField]
	private WWImage _affiliationIcon;

	[SerializeField]
	private WWTextMeshProUGUI _titleText;

	[SerializeField]
	private Color _aradiaColor;

	[SerializeField]
	private Color _delilahColor;

	[SerializeField]
	private WWImage _questIcon;

	[SerializeField]
	private WWTextMeshProUGUI _questTitleText;

	[SerializeField]
	private WWTextMeshProUGUI _questLocationText;

	[SerializeField]
	private Rectangle _challengeBannerRectangle;

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

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_Leave()
	{
	}

	public void BtnClicked_Cancel()
	{
	}
}
