using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	[AddComponentMenu("UI/WW/WWToggleSlider", 31)]
	[RequireComponent(typeof(RectTransform))]
	public class WWToggleSlider : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		public enum ToggleTransition
		{
			None,
			Fade
		}

		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}

		public ToggleTransition toggleTransition;

		public Graphic graphic;

		public ToggleEvent onValueChanged;

		[SerializeField]
		[FormerlySerializedAs("m_IsActive")]
		[Tooltip("Is the toggle currently on or off?")]
		private bool m_IsOn;

		[SerializeField]
		private RectTransform m_ContentRect;

		[SerializeField]
		private Graphic m_ContentGraphic;

		[SerializeField]
		private Color m_ContentColorOff;

		[SerializeField]
		private Color m_ContentColorOn;

		[SerializeField]
		private RectTransform m_HandleRect;

		[SerializeField]
		private float m_TweenDuration;

		private DrivenRectTransformTracker m_Tracker;

		public RectTransform ContentRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Graphic ContentGrpahic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color ContentColorOff
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color ContentColorOn
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public RectTransform handleRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float TweenDuration
		{
			get
			{
				return default(float);
			}
		}

		public bool isOn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected WWToggleSlider()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		public void SetInstant(bool value, bool sendCallback)
		{
		}

		private void Set(bool value)
		{
		}

		private void Set(bool value, bool sendCallback)
		{
		}

		private void PlayEffect(bool instant)
		{
		}

		private void UpdateSliderVisuals(bool instant)
		{
		}

		protected override void Start()
		{
		}

		private void InternalToggle()
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[SpecialName]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
}
