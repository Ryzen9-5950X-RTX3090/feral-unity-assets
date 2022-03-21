using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_CasualGameConfirmation : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _titleText;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private WWImage _bannerImage;

	private BaseDef _casualGameDef;

	public static void OpenWindow(BaseDef inCasualGameDef)
	{
	}

	public static void QueueWindow(BaseDef inCasualGameDef)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(BaseDef inCasualGameDef)
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

	public void BtnClicked_Play()
	{
	}
}
