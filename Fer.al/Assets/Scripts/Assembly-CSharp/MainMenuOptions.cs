using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuOptions : MonoBehaviour
{
	public Button SaveButton;

	public Button QuitButton;

	public Dropdown TTSVoiceDropdown;

	public GameObject ConfirmationMenu;

	public Button ConfirmYesButton;

	public Button ConfirmNoButton;

	private EventSystem m_EventSystem;

	private int _selected_tts_voice_index;

	private string tts_voice_setting;

	private GameObject m_optionsMenuPanel
	{
		get
		{
			return null;
		}
	}

	private VivoxVoiceManager _vivoxVoiceManager
	{
		get
		{
			return null;
		}
	}

	private bool isDirty
	{
		get
		{
			return default(bool);
		}
	}

	private void ttsDropdownValueChangedHandler(Dropdown target)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void AddAllTTSVoices()
	{
	}

	private void SelectOptionFromSavedSettings()
	{
	}

	public void ShowOptionsMenu(bool showMenu = false)
	{
	}

	private void ShowConfirmMenu(bool showMenu = false)
	{
	}

	private void MenuInputAction()
	{
	}

	private void SaveAction()
	{
	}

	private void QuitButtonAction()
	{
	}

	private void ConfirmYesButtonAction()
	{
	}

	private void ConfirmNoAction()
	{
	}
}
