using UnityEngine;
using UnityEngine.UI;

public class UI_MobileButton : MonoBehaviour
{
	public enum EButtonType
	{
		None,
		Chat,
		VoiceChat
	}

	[SerializeField]
	private EButtonType _buttonType;

	[SerializeField]
	private FeralButton _button;

	private void OnEnable()
	{
	}

	public void OnClick()
	{
	}

	private void UpdateButtonInteraction()
	{
	}
}
