using ThisOtherThing.UI.Shapes;
using UnityEngine;

public class UI_ColorChannelTab : MonoBehaviour
{
	[SerializeField]
	private Rectangle _currentColorFullRectangle;

	[SerializeField]
	private Rectangle _currentColorHalfRectangle;

	[SerializeField]
	private Rectangle _targetColorHalfRectangle;

	[SerializeField]
	private CanvasGroup _colorSelectedGroup;

	[SerializeField]
	private CanvasGroup _clearColorBtnGroup;

	[SerializeField]
	private CanvasGroup _undyeColorBtnGroup;

	private HSVColor _defaultColor;

	private HSVColor _currentColor;

	private HSVColor? _targetColor;

	public HSVColor DefaultColor
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor CurrentColor
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor? TargetColor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
