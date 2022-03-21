using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(FeralButton))]
public class UI_ToggleSoundPlayer : MonoBehaviour
{
	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private FeralAudioInfo _audioInfoOn;

	[SerializeField]
	private FeralAudioInfo _audioInfoOff;

	private void Reset()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnToggle(bool inIsOn)
	{
	}
}
