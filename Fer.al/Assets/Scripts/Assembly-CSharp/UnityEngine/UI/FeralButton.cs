using System;
using System.Collections.Generic;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	public class FeralButton : WWButton
	{
		[Serializable]
		private class ToggleGroup
		{
			public CanvasGroup canvasGroup;

			[Tooltip("Set to true if you want the canvas group to be active, when the toggle is off.")]
			public bool inverted;
		}

		[Serializable]
		private class ToggleGraphic
		{
			public Graphic graphic;

			public Sprite spriteOn;

			public Sprite spriteOff;

			private Rectangle rectangle;

			private Image image;

			public void SetGraphic(bool inIsOn)
			{
			}
		}

		[SerializeField]
		protected CanvasGroup _canvasGroup;

		[SerializeField]
		protected bool _isOn;

		[SerializeField]
		protected bool _toggleOnClick;

		public Toggle.ToggleEvent toggleEvent;

		[SerializeField]
		private UI_ButtonColorSet _colorSet;

		[SerializeField]
		private List<Graphic> _bgGraphics;

		[SerializeField]
		private List<UI_ColorizedIcon> _icons;

		[SerializeField]
		private List<WWTextMeshProUGUI> _textElements;

		[SerializeField]
		private Transform _targetTransform;

		[SerializeField]
		private bool _useOverrideRotation;

		[SerializeField]
		private float _overrideRotation;

		[SerializeField]
		private List<ToggleGroup> _toggleGroups;

		[SerializeField]
		private List<ToggleGraphic> _toggleGraphics;

		private bool _isLocked;

		private float _originalScale;

		private float _originalRotation;

		public CanvasGroup CanvasGroup
		{
			get
			{
				return null;
			}
		}

		public virtual bool IsOn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal UI_ButtonColorSet colorSet
		{
			get
			{
				return null;
			}
		}

		public void SetIsOnNoNotify(bool inIsOn)
		{
		}

		public void SimulateClick()
		{
		}

		protected override void Awake()
		{
		}

		protected override void DoClick(PointerEventData eventData)
		{
		}

		public override void OnSubmit(BaseEventData eventData)
		{
		}

		protected virtual void OnToggleChanged()
		{
		}

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		private void DoBGStateTransition(SelectionState state, bool instant)
		{
		}

		private void DoIconStateTransition(SelectionState state, bool instant)
		{
		}

		private void DoTextStateTransition(SelectionState state, bool instant)
		{
		}

		private void DoTransformStateTransition(SelectionState state, bool instant)
		{
		}

		private void DoToggleGroupStateTransition(bool instant)
		{
		}

		private void DoToggleGraphicStateTransition(bool instant)
		{
		}

		internal void OverrideColorset(UI_ButtonColorSet inOverrideColorSet, bool inIsLocked)
		{
		}
	}
}
