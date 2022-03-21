using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SettingsPanel_Chat : MonoBehaviour
{
	[SerializeField]
	[Header("Chat Bubble")]
	private FeralButton _chatBubbleToggle;

	[SerializeField]
	private WWTextMeshProUGUI _chatBubbleValueText;

	[SerializeField]
	[Header("Chat Filter")]
	private FeralButton _chatFilterToggle;

	[SerializeField]
	private WWTextMeshProUGUI _chatFilterValueText;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void BtnClicked_ChatFilterInfo()
	{
	}

	private void BtnClicked_ChatBubbleToggle(bool inIsOn)
	{
	}

	private void BtnClicked_ChatFilterToggle(bool inIsOn)
	{
	}
}
