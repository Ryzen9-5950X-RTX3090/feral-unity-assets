using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Control_HSVSliders : MonoBehaviour
{
	[SerializeField]
	[Header("Slider Hue")]
	private Slider _sliderH;

	[SerializeField]
	private WWImage _sliderHHandle;

	[SerializeField]
	private TMP_InputField _sliderHText;

	[SerializeField]
	[Header("Slider Saturation")]
	private Slider _sliderS;

	[SerializeField]
	private WWImage _sliderSHandle;

	[SerializeField]
	private TMP_InputField _sliderSText;

	[SerializeField]
	private UIGradient _sliderSGradient;

	[SerializeField]
	[Header("Slider Value")]
	private Slider _sliderV;

	[SerializeField]
	private WWImage _sliderVHandle;

	[SerializeField]
	private TMP_InputField _sliderVText;

	[SerializeField]
	private UIGradient _sliderVGradient;

	[SerializeField]
	[Header("Hex String")]
	private TMP_InputField _hexInputField;

	private HSVColor _hsvColor;

	private Action<HSVColor> _onColorChanged;

	private bool _ignoreSliderChanges;

	private bool _firstSetup;

	public HSVColor HSVColor
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public void Setup(HSVColor inColor, Action<HSVColor> inOnColorChanged)
	{
	}

	public void OnEndEdit_H(string inValue)
	{
	}

	public void OnEndEdit_S(string inValue)
	{
	}

	public void OnEndEdit_V(string inValue)
	{
	}

	public void OnEndEdit_HexString(string inValue)
	{
	}

	private void OnSliderChanged(float inValue)
	{
	}

	private void RefreshSliderValues()
	{
	}

	private void RefreshSliderDisplay()
	{
	}

	private void RefreshHexValue()
	{
	}
}
