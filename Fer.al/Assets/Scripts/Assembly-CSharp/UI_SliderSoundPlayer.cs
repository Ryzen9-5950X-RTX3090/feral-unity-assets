using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(FeralAudioEmitter))]
public class UI_SliderSoundPlayer : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	private FeralAudioEmitter _sliderStartSound;

	[SerializeField]
	private FeralAudioEmitter _sliderEndSound;

	[SerializeField]
	private Slider _slider;

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void Reset()
	{
	}
}
