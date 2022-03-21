using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SettingsPanel_Audio : MonoBehaviour
{
	[SerializeField]
	private Slider _musicSlider;

	[SerializeField]
	private WWTextMeshProUGUI _musicVolumeText;

	[SerializeField]
	private GameObject _noMusicGroup;

	[SerializeField]
	private Slider _sfxSlider;

	[SerializeField]
	private WWTextMeshProUGUI _sfxVolumeText;

	[SerializeField]
	private GameObject _noSfxGroup;

	[SerializeField]
	private Slider _voiceSlider;

	[SerializeField]
	private WWTextMeshProUGUI _voiceVolumeText;

	[SerializeField]
	private GameObject _noVoiceGroup;

	private void OnEnable()
	{
	}

	public void SliderValueChanged_MusicVolume(float inVolume)
	{
	}

	public void SliderValueChanged_SFXVolume(float inVolume)
	{
	}

	public void SliderValueChanged_VoiceVolume(float inVolume)
	{
	}
}
