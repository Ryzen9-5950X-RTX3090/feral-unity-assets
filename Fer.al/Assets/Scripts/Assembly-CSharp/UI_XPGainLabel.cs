using TMPro;
using UnityEngine;

public class UI_XPGainLabel : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _xpText;

	[SerializeField]
	private float _minFontSize;

	[SerializeField]
	private float _maxFontSize;

	[SerializeField]
	private float _maxExpectedXP;

	[SerializeField]
	private AnimationCurve _positionCurve;

	[SerializeField]
	private AnimationCurve _alphaCurve;

	[SerializeField]
	private AnimationCurve _scaleCurve;

	[SerializeField]
	private float _animationDuration;

	[SerializeField]
	private float _floatDistance;

	[SerializeField]
	private float _randomPositionOffset;

	[SerializeField]
	private Vector2 _fixedOffset;

	public void Setup(int inXPAmount)
	{
	}

	public void OnEnable()
	{
	}
}
