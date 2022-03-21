using UnityEngine;

public class UI_SanctuaryDecorationPanel_LightSettings : MonoBehaviour
{
	[SerializeField]
	private UI_LazyItemList_SanctuaryLight _itemList;

	[SerializeField]
	private ConstrainedSlider _rotationSlider;

	[SerializeField]
	private ConstrainedSlider _brightnessSlider;

	private SanctuaryLightDefComponent _currentLight;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLightItemSelected(SanctuaryLightDefComponent inSelectedLight)
	{
	}

	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage)
	{
	}

	private void OnRoomChange()
	{
	}

	private void RefreshSliders()
	{
	}

	public void SliderValueChanged_LightAngle(float inValue)
	{
	}

	public void SliderValueChanged_LightIntensity(float inValue)
	{
	}
}
