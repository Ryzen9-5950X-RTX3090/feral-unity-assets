using UnityEngine;

public class UI_Window_GlideTutorial : UI_Window
{
	private static readonly string _saveName;

	private int _tutorialPage;

	[SerializeField]
	private GameObject[] _tutorialPages;

	[SerializeField]
	private GameObject[] _pageDotFills;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	public override void MStart()
	{
	}

	public void NextPage()
	{
	}

	public void SetPage(int inPage)
	{
	}

	public void BtnClicked_TutorialClose()
	{
	}

	public override void MOnDisable()
	{
	}
}
