using TMPro;
using UnityEngine;

public class UI_Window_CreateChatConversation : UI_Window
{
	[SerializeField]
	private TMP_InputField _nameInput;

	[SerializeField]
	private TMP_InputField _membersInput;

	private string NameInput
	{
		get
		{
			return null;
		}
	}

	private string[] MemberNames
	{
		get
		{
			return null;
		}
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

	[RuntimeInitializeOnLoadMethod]
	private static void StaticInit()
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

	public void BtnClicked_CreateConversation()
	{
	}
}
