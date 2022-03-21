using System;
using Coffee.UIExtensions;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

public class UI_ToggleButtonGraphic : MonoBehaviour
{
	[Serializable]
	public class ToggleGraphic
	{
		[SerializeField]
		private Graphic _graphic;

		[SerializeField]
		private Color _colorOn;

		[SerializeField]
		private Color _colorOff;

		[SerializeField]
		private Color _colorDisabled;

		[SerializeField]
		[Header("Image Only")]
		private Sprite _spriteOn;

		[SerializeField]
		private Sprite _spriteOff;

		private bool _lastIsOnValue;

		private bool _lastIsDisabledValue;

		private Image _image;

		private Rectangle _rectangle;

		public void Init(bool inIsOn, bool inIsDisabled)
		{
		}

		public void OnToggle(bool inIsOn, bool inIsDisabled)
		{
		}
	}

	[Serializable]
	public class ToggleCanvasGroup
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private bool _onState;

		[SerializeField]
		private bool _offState;

		[SerializeField]
		private bool _useDisabledState;

		[SerializeField]
		private bool _disabledState;

		private bool _lastValue;

		public void Init(bool inIsOn, bool inIsDisabled)
		{
		}

		public void OnToggle(bool inIsOn, bool inIsDisabled)
		{
		}
	}

	[Serializable]
	public class ToggleUIEffect
	{
		[SerializeField]
		private UIEffect _effect;

		[SerializeField]
		[Tooltip("if Invert is true, this effect will show only when the toggle is off")]
		private bool _invert;

		private bool _lastValue;

		public void Init(bool inIsOn)
		{
		}

		public void OnToggle(bool inIsOn)
		{
		}
	}

	[Serializable]
	public class CornerNoise
	{
		[SerializeField]
		private Rectangle _rectangle;

		[SerializeField]
		private Vector2 _moveScale;

		[SerializeField]
		private float _speedScale;

		[SerializeField]
		private bool _fromStartOffset;

		[SerializeField]
		private bool _outward;

		private float _currentMoveScale;

		private bool _doUpdate;

		private Vector2 _cornerAStart;

		private Vector2 _cornerBStart;

		private Vector2 _cornerCStart;

		private Vector2 _cornerDStart;

		public void Init()
		{
		}

		public void StartMovement()
		{
		}

		public void EndMovement()
		{
		}

		public void Update()
		{
		}
	}
}
