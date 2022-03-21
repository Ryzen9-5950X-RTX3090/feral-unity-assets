using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	public class WWButton : Button, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
	{
		[Serializable]
		public class ProgressEvent : UnityEvent<float>
		{
		}

		protected const float GLOBAL_BUTTON_LONGPRESS_DURATION = 0.5f;

		protected const float GLOBAL_BUTTON_COOLDOWN = 0.25f;

		protected static float _timeOfLastButtonPress;

		[SerializeField]
		private ProgressEvent _onLongPressProgress;

		[SerializeField]
		private UnityEvent _onLongPressCancel;

		[SerializeField]
		private UnityEvent _onLongPress;

		[SerializeField]
		private UnityEvent _onLongPressStay;

		[SerializeField]
		private UnityEvent _onLongPressEnd;

		[SerializeField]
		protected float _customLongPressDuration;

		[SerializeField]
		private bool _ignorePressCooldown;

		private bool _wasLongPressed;

		private bool _isStartingLongPress;

		private bool _isBeingLongPressed;

		private float _longPressCurrentDuration;

		public ProgressEvent onLongPressProgress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent onLongPressCancel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent onLongPress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent onLongPressStay
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent onLongPressEnd
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float LongPressDuration
		{
			get
			{
				return default(float);
			}
		}

		[RuntimeInitializeOnLoadMethod]
		public static void FastPlayModeReset()
		{
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		protected virtual void DoClick(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		protected virtual void Update()
		{
		}

		protected override void OnDisable()
		{
		}

		public void ClearAssetReferences()
		{
		}
	}
}
