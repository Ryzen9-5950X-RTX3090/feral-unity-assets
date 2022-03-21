using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeBreakerDialogPopup : MonoBehaviour
{
	public List<Sprite> characterEmotes;

	public WWTextMeshProUGUI dialogueText;

	public WWImage dialogEmoteImage;

	public float minDisplayTime;

	private float timer;

	private bool allowSkip;

	private bool skipped;

	private bool hiding;

	private void Update()
	{
	}

	public void ShowDialogTextById(string inLocDefId, int inEmoteIndex, bool inAllowSkip = true)
	{
	}

	public void ShowDialogText(string inText, int inEmoteIndex, bool inAllowSkip = true)
	{
	}

	public void CloseDialogText()
	{
	}

	private void ShowEmote(int inIndex)
	{
	}

	private void ShowPopup()
	{
	}

	private void HidePopup()
	{
	}
}
